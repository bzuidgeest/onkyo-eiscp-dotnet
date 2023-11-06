using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using System.CodeDom.Compiler;
using System.Net.Http.Headers;
using onkyo;
//using static System.Net.Mime.MediaTypeNames;
//using System.Reflection.Emit;
using Terminal.Gui;
using Eiscp.Core;
using generate;
using Eiscp.Core.Models;

class Program
{
    private static object GetData(Parser r)
    {
        if (r.Accept<Scalar>())
        {
            return r.Expect<Scalar>().Value;
        }
        else if (r.Accept<SequenceStart>())
        {
            var seq = new ArrayList();

            r.Expect<SequenceStart>();

            while (!r.Accept<SequenceEnd>())
            {
                seq.Add(GetData(r));
            }

            r.Expect<SequenceEnd>();

            // Arrays are IStructuralEquatable, ArrayLists are not.
            return seq.ToArray();
        }
        else if (r.Accept<MappingStart>())
        {
            // Since we use sequences as keys...
            var map = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);

            r.Expect<MappingStart>();

            while (!r.Accept<MappingEnd>())
            {
                object key = GetData(r);
                object value = GetData(r);
                map.Add(key, value);
            }

            r.Expect<MappingEnd>();

            return map;
        }
        else
        {
            throw new YamlException("Error!");
        }
    }

    private static IEnumerable FindCommandAliases(OrderedDictionary commandList)
    {
        foreach (DictionaryEntry commandEntry in commandList)
        {
            object name = (commandEntry.Value as IDictionary)["name"];
            var aliases = ((commandEntry.Value as IDictionary)["aliases"] as object[])?.Cast<string>().ToArray();
            if (name is IEnumerable && !(name is string))
            {
                foreach (object item in (IEnumerable)name)
                {
                    yield return new DictionaryEntry(item, commandEntry.Key);
                }
            }
            else
            {

                yield return new DictionaryEntry(name, commandEntry.Key);
                if (aliases?.Length > 0)
                {
                    foreach (var alias in aliases)
                        yield return new DictionaryEntry(alias, commandEntry.Key);
                }
            }
        }
    }

    private static IEnumerable FindValueAliases(OrderedDictionary values)
    {
        foreach (DictionaryEntry valueEntry in values)
        {
            if ((valueEntry.Value as IDictionary).Contains("name"))
            {
                object name = (valueEntry.Value as IDictionary)["name"];
                if (name is IEnumerable && !(name is string))
                {
                    foreach (object item in (IEnumerable)name)
                    {
                        yield return new DictionaryEntry(item, valueEntry.Key);
                    }
                }
                else
                {
                    yield return new DictionaryEntry(name, valueEntry.Key);
                }
            }
        }
    }

    // Taken straight from:
    // http://stackoverflow.com/questions/323640/can-i-convert-a-c-sharp-string-value-to-an-escaped-string-literal
    private static string ToLiteral(string input)
    {
        using (var writer = new StringWriter())
        {
            using (var provider = CodeDomProvider.CreateProvider("CSharp"))
            {
                provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                return writer.ToString();
            }
        }
    }
    private static OrderedDictionary Odict(IEnumerable e)
    {
        OrderedDictionary odict = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);

        foreach (DictionaryEntry entry in e)
        {
            odict[entry.Key] = entry.Value;
        }

        return odict;
    }

    private static string PrintData(bool indent, int nesting, object data)
    {
        var stringOutput = new StringBuilder();

        if (indent)
        {
            stringOutput.Append('\t', repeatCount: nesting);
        }

        if (data == null)
        {
            stringOutput.Append("null");
        }

        else if (data is string)
        {
            stringOutput.Append(ToLiteral((string)data));
        }
        else if (data is Array)
        {
            stringOutput.Append("new string[]\r\n");
            stringOutput.Append('\t', repeatCount: nesting);
            stringOutput.Append("{\r\n");

            bool comma = false;
            foreach (object o in (object[])data)
            {
                if (comma)
                {
                    stringOutput.Append(",\r\n");
                }
                stringOutput.Append(PrintData(true, nesting + 1, o));
                comma = true;
            }

            stringOutput.Append("\r\n");
            stringOutput.Append('\t', repeatCount: nesting);
            stringOutput.Append("}");
        }
        else if (data is OrderedDictionary)
        {
            switch (nesting)
            {
                case 2:
                    stringOutput.AppendLine("new Dictionary<string, Dictionary<string, Dictionary<string, ISCPCommandDocumentation>>>() {");
                    break;
                case 4:
                    stringOutput.Append("new Dictionary<string, Dictionary<string, ISCPCommandDocumentation>>() {");
                    break;
                case 6:
                    stringOutput.AppendLine("new ISCPCommandDocumentation() {");
                    break;
                default:
                    stringOutput.AppendLine("new Dictionary<string, Dictionary<string, Dictionary<string, IValue>>>() {");
                    break;
            }

            bool comma = false;
            foreach (DictionaryEntry entry in (OrderedDictionary)data)
            {
                if (comma)
                {
                    stringOutput.Append(",");
                }

                if (entry.Key is string && (entry.Value is string || entry.Value is object[] || entry.Value is null))
                {
                    //stringOutput.Append('\t', repeatCount: nesting + 1);
                    //stringOutput.AppendLine($"{char.ToUpper(((string)entry.Key)[0])}{((string)entry.Key).Substring(1)} = \"{((string)entry.Value)}\",");
                    stringOutput.AppendLine(PrintClassProperty(entry.Key as string, entry.Value, nesting + 1));
                }
                else if (entry.Key is string && entry.Key as string == "values" && entry.Value is OrderedDictionary)
                {
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.AppendLine($"{char.ToUpper(((string)entry.Key)[0])}{((string)entry.Key).Substring(1)} = new Dictionary<string, ISCPCommandValueDocumentation>() {{ ");

                    foreach (DictionaryEntry value in ((OrderedDictionary)entry.Value))
                    {
                        stringOutput.Append('\t', repeatCount: nesting + 2);
                        stringOutput.AppendLine($"\"{value.Key.ToString()}\", new ISCPCommandValueDocumentation() {{");


                        foreach (DictionaryEntry p in ((OrderedDictionary)value.Value))
                        {
                            stringOutput.AppendLine($"{PrintClassProperty(p.Key as string, p.Value, nesting + 3)}, ");
                        }
                        stringOutput.Length--;
                        stringOutput.Length--;
                        stringOutput.Length--;

                        stringOutput.AppendLine();
                        stringOutput.Append('\t', repeatCount: nesting + 2);
                        stringOutput.AppendLine("}");
                    }
                }
                else
                {
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("{\r\n ");

                    stringOutput.Append(PrintData(true, nesting + 2, entry.Key));

                    //stringOutput.Append(",\r\n");
                    stringOutput.Append(", ");

                    stringOutput.Append(PrintData(false, nesting + 2, entry.Value));

                    stringOutput.Append("\r\n");
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("}");
                }
                comma = true;
            }

            stringOutput.Append("\r\n");
            stringOutput.Append('\t', repeatCount: nesting);
            stringOutput.Append("}");
        }
        else
        {
            throw new ArgumentException();
        }

        return stringOutput.ToString();
    }

    public static string PrintClassProperty(string name, object value, int identCount)
    {
        StringBuilder stringOutput = new StringBuilder();

        if (value is string)
        {
            stringOutput.Append('\t', repeatCount: identCount);
            stringOutput.Append($"{char.ToUpper(name[0])}{name.Substring(1)} = @\"{((string)value)}\",");
        }
        if (value is null)
        {
            stringOutput.Append('\t', repeatCount: identCount);
            stringOutput.Append($"{char.ToUpper(name[0])}{name.Substring(1)} = null,");
        }
        else if (value is object[])
        {
            stringOutput.Append('\t', repeatCount: identCount);
            stringOutput.Append($"{char.ToUpper(name[0])}{name.Substring(1)} =  new string[] {{ ");

            stringOutput.Append(String.Join(",", ((object[])value).Select(x => $"\"{x}\"")));
            stringOutput.Append(" })");
        }

        return stringOutput.ToString();
    }

    private static string PrintCommandMappings(bool indent, int nesting, object data)
    {
        var stringOutput = new StringBuilder();

        if (indent)
        {
            stringOutput.Append('\t', repeatCount: nesting);
        }

        if (data == null)
        {
            stringOutput.Append("null");
        }

        else if (data is string)
        {
            stringOutput.Append(ToLiteral((string)data));
        }
        else if (data is Array)
        {
            stringOutput.Append("new string[]\r\n");
            stringOutput.Append('\t', repeatCount: nesting);
            stringOutput.Append("{\r\n");

            bool comma = false;
            foreach (object o in (object[])data)
            {
                if (comma)
                {
                    stringOutput.Append(",\r\n");
                }
                stringOutput.Append(PrintCommandMappings(true, nesting + 1, o));
                comma = true;
            }

            stringOutput.Append("\r\n");
            stringOutput.Append('\t', repeatCount: nesting);
            stringOutput.Append("}");
        }
        else if (data is OrderedDictionary)
        {
            if (((OrderedDictionary)data)[0] is OrderedDictionary)
            {
                stringOutput.AppendLine("new Dictionary<string, Dictionary<string, string>>() {");
            }
            else if (((OrderedDictionary)data)[0] is string)
            {
                stringOutput.AppendLine("new Dictionary<string, string>() {");
            }
            else
            {
                stringOutput.Append("new Dictionary<string, object>()\r\n");
                stringOutput.Append('\t', repeatCount: nesting);
                stringOutput.Append("{\r\n");
            }



            bool comma = false;
            foreach (DictionaryEntry entry in (OrderedDictionary)data)
            {
                if (comma)
                {
                    stringOutput.Append(",\r\n");
                }



                if (entry.Value is OrderedDictionary)
                {
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("{ ");

                    stringOutput.Append($"{ToLiteral((string)entry.Key)}, {PrintCommandMappings(false, nesting, entry.Value)}");

                    stringOutput.Append("\r\n");
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("}");
                }
                else if (entry.Value is string)
                {
                    stringOutput.Append('\t', repeatCount: nesting + 2);
                    stringOutput.Append($"{{ \"{(string)entry.Key}\", \"{(string)entry.Value}\" }}");
                }
                else
                {
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("{\r\n ");

                    stringOutput.Append(PrintCommandMappings(true, nesting + 2, entry.Key));

                    stringOutput.Append(",\r\n");

                    stringOutput.Append(PrintCommandMappings(true, nesting + 2, entry.Value));

                    stringOutput.Append("\r\n");
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("}");
                }


                comma = true;
            }

            stringOutput.Append("\r\n");
            stringOutput.Append('\t', repeatCount: nesting);
            stringOutput.Append("}");
        }
        else
        {
            throw new ArgumentException();
        }

        return stringOutput.ToString();
    }

    private static string PrintValueMappings(bool indent, int nesting, object data)
    {
        var stringOutput = new StringBuilder();

        if (indent)
        {
            stringOutput.Append('\t', repeatCount: nesting);
        }

        if (data == null)
        {
            stringOutput.Append("null");
        }

        else if (data is string)
        {
            stringOutput.Append(ToLiteral((string)data));
        }
        else if (data is Array)
        {
            stringOutput.Append("new MultiValue<string>(new string[] {");

            bool comma = false;
            foreach (object o in (object[])data)
            {
                if (comma)
                {
                    stringOutput.Append(",");
                }
                stringOutput.Append($"\"{o}\"");
                comma = true;
            }
            stringOutput.Append("})");
        }
        else if (data is OrderedDictionary)
        {
            if (((OrderedDictionary)data)[0] is OrderedDictionary)
            {
                switch (nesting)
                {
                    case 2:
                        stringOutput.AppendLine("new Dictionary<string, Dictionary<string, Dictionary<string, IValue>>>() {");
                        break;
                    case 3:
                        stringOutput.AppendLine("new Dictionary<string, Dictionary<string, IValue>>() {");
                        break;
                    default:
                        stringOutput.AppendLine("new Dictionary<string, Dictionary<string, Dictionary<string, IValue>>>() {");
                        break;
                }
            }
            else if (((OrderedDictionary)data)[0] is string)
            {
                stringOutput.AppendLine("new Dictionary<string, IValue>() {");
            }
            else
            {
                stringOutput.Append("new Dictionary<string, IValue>()\r\n");
                stringOutput.Append('\t', repeatCount: nesting);
                stringOutput.Append("{\r\n");
            }



            bool comma = false;
            foreach (DictionaryEntry entry in (OrderedDictionary)data)
            {
                if (comma)
                {
                    stringOutput.Append(",\r\n");
                }



                if (entry.Value is OrderedDictionary)
                {
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("{ ");

                    stringOutput.Append($"{ToLiteral((string)entry.Key)}, {PrintValueMappings(false, nesting + 1, entry.Value)}");

                    stringOutput.Append("\r\n");
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("}");
                }
                else if (entry.Value is string)
                {
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append($"{{ \"{(string)entry.Key}\", new SingleValue<string>(\"{(string)entry.Value}\") }}");
                }
                else if (entry.Value is Array)
                {
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("{ ");

                    stringOutput.Append(PrintValueMappings(false, nesting + 2, entry.Key));

                    stringOutput.Append(", ");

                    stringOutput.Append(PrintValueMappings(false, nesting + 2, entry.Value));

                    stringOutput.Append(" }");
                }
                else
                {
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("{\r\n ");

                    stringOutput.Append(PrintValueMappings(true, nesting + 2, entry.Key));

                    stringOutput.Append(",\r\n");

                    stringOutput.Append(PrintValueMappings(true, nesting + 2, entry.Value));

                    stringOutput.Append("\r\n");
                    stringOutput.Append('\t', repeatCount: nesting + 1);
                    stringOutput.Append("}");

                }


                comma = true;
            }

            stringOutput.Append("\r\n");
            stringOutput.Append('\t', repeatCount: nesting);
            stringOutput.Append("}");
        }
        else
        {
            throw new ArgumentException();
        }

        return stringOutput.ToString();
    }


    static void Process(string inputFile, string outputClassName)
    {
        OrderedDictionary zones;

        StreamReader inputStream = new StreamReader(inputFile);



        var parser = new Parser(inputStream);


        parser.Consume<StreamStart>();
        parser.Consume<DocumentStart>();
        zones = (OrderedDictionary)GetData(parser);
        parser.Consume<DocumentEnd>();
        parser.Consume<StreamEnd>();


        // Remove modelsets key, not a real zone
        zones.Remove("modelsets");

        // Generate the C# structures
        //
        // We want a command dictionary that does not include the model data, which we
        // are not using.
        var commands = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);
        foreach (DictionaryEntry zoneEntry in zones)
        {
            object zone = zoneEntry.Key;
            OrderedDictionary commandsInZone = (OrderedDictionary)zoneEntry.Value;
            OrderedDictionary newCommands = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);

            foreach (DictionaryEntry commandEntry in commandsInZone)
            {
                object command = commandEntry.Key;
                OrderedDictionary commandData = (OrderedDictionary)commandEntry.Value;

                OrderedDictionary values = (OrderedDictionary)commandData["values"];

                OrderedDictionary newValues = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer);
                foreach (DictionaryEntry valueEntry in values)
                {
                    object value = valueEntry.Key;
                    OrderedDictionary valueData = (OrderedDictionary)valueEntry.Value;

                    OrderedDictionary newValueData = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
                    {
                        { "name", valueData["name"] },
                        { "description", valueData["description"] }
                    };

                    newValues.Add(value, newValueData);
                }

                OrderedDictionary newCommandData = new OrderedDictionary(StructuralComparisons.StructuralEqualityComparer)
                {
                    { "name", commandData["name"] },
                    { "description", commandData["description"] },
                    { "aliases", commandData["aliases"] },
                    { "values", newValues }
                };
                newCommands.Add(command, newCommandData);
            }
            commands.Add(zone, newCommands);
        }


        var commandMappings = Odict(
            from DictionaryEntry zoneEntry in zones
            select new DictionaryEntry
            {
                Key = zoneEntry.Key,
                Value = Odict(FindCommandAliases((OrderedDictionary)zoneEntry.Value))
            }
        );

        var valueMappings = Odict(
            from DictionaryEntry zoneEntry in zones
            let zone = zoneEntry.Key
            let commands_ = zoneEntry.Value
            select new DictionaryEntry
            {
                Key = zone,
                Value = Odict(
                    from DictionaryEntry commandEntry in (IEnumerable)commands_
                    let command = commandEntry.Key
                    let commandData = commandEntry.Value
                    select new DictionaryEntry
                    {
                        Key = command,
                        Value = Odict(FindValueAliases((OrderedDictionary)(commandData as IDictionary)["values"]))
                    }
                )
            }
        );

        StreamWriter outputStream = new StreamWriter($"../../../{outputClassName}.C.generated.cs", append: false);

        outputStream.Write(
            "// Generated\r\n" +
            "// by {0}\r\n" +
            "// from {1}\r\n" +
            "// at {2}\r\n\r\n".ReplaceLineEndings(),
            "", //Path.GetFileName(Environment.GetCommandLineArgs()[0]),
            "", //Path.GetFileName(Environment.GetCommandLineArgs()[1]),
            DateTime.Now
        );

        outputStream.Write(
            "using System.Collections;\r\n" +
            "using System.Collections.Specialized;\r\n\r\n" +
            "namespace Eiscp.Core\r\n" +
            "{\r\n" +
            "\tpublic static partial class EiscpCommands\r\n" +
            "\t{\r\n" +
            $"\t\tpublic static readonly Dictionary<string, object>  Commands = {PrintData(false, 2, commands)};\r\n" +
            "\t}\r\n" +
            "}\r\n".ReplaceLineEndings()
        );
        outputStream.Flush();
        outputStream.Close();

        outputStream = new StreamWriter($"../../../{outputClassName}.CM.generated.cs", append: false);

        outputStream.Write(
            "// Generated\r\n" +
            "// by {0}\r\n" +
            "// from {1}\r\n" +
            "// at {2}\r\n\r\n".ReplaceLineEndings(),
            "", //Path.GetFileName(Environment.GetCommandLineArgs()[0]),
            "", //Path.GetFileName(Environment.GetCommandLineArgs()[1]),
            DateTime.Now
        );

        outputStream.Write(
            "using System.Collections;\r\n" +
            "using System.Collections.Specialized;\r\n\r\n" +
            "namespace Eiscp.Core\r\n" +
            "{\r\n" +
            "\tpublic static partial class EiscpCommands\r\n" +
            "\t{\r\n" +
            $"\t\tpublic static readonly Dictionary<string, Dictionary<string, string>> CommandMappings = {PrintCommandMappings(false, 2, commandMappings)};\r\n" +
            "\t}\r\n" +
            "}\r\n".ReplaceLineEndings()
        );
        outputStream.Flush();
        outputStream.Close();

        outputStream = new StreamWriter($"../../../{outputClassName}.CV.generated.cs", append: false);

        outputStream.Write(
            "// Generated\r\n" +
            "// by {0}\r\n" +
            "// from {1}\r\n" +
            "// at {2}\r\n\r\n".ReplaceLineEndings(),
            "", //Path.GetFileName(Environment.GetCommandLineArgs()[0]),
            "", //Path.GetFileName(Environment.GetCommandLineArgs()[1]),
            DateTime.Now
        );

        outputStream.Write(
            "using System.Collections;\r\n" +
            "using System.Collections.Specialized;\r\n\r\n" +
            "namespace Eiscp.Core\r\n" +
            "{\r\n" +
            "\tpublic static partial class EiscpCommands\r\n" +
            "\t{\r\n" +
            $"\t\tpublic static readonly Dictionary<string, Dictionary<string, Dictionary<string, IValue>>> ValueMappings = {PrintValueMappings(false, 2, valueMappings)};\r\n" +
            "\t}\r\n" +
            "}\r\n".ReplaceLineEndings()
        );
        outputStream.Flush();
        outputStream.Close();
    }

    public static void Main(string[] args)
    {
        string inputFile = "./eiscp-commands.yaml";
        string outputClassName = "ISCPCommands";

        if (args.Length < 2)
        {
            Console.WriteLine("Assuming default file input and outputs");
        }
        else
        {
            inputFile = args[0];
            outputClassName = args[1];
        }

        if (File.Exists(inputFile) == false)
        {
            Console.WriteLine($"Input file not found: {inputFile}");
        }

        ISCPDocumentation iSCPDocumentation = ISCPDocumentationGenerator.Parse("../../../ISCP_AVR_146.xlsx");


        Application.Init();

        DocumentationWindow documentation = new DocumentationWindow(iSCPDocumentation);

        
        Application.Top.Add(documentation);
        Application.Run();
        Application.Shutdown();
        //Process(inputFile, outputClassName);
    }
}


