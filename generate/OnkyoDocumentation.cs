using Eiscp.Core;
using generate;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace onkyo
{
    public static class OnkyoDocumentation
    {
        // what to do with these 
        //CMND(via RI)
        //CMND(PORT)
        //CMND(BD via RIHD)
        //CMND(TV via RIHD)
        private static string[] worksheetsToParse = { "CMND(MAIN)", "CMND(ZONE2)", "CMND(ZONE3)", "CMND(ZONE4)", "CMND(NET USB)", "CMND(PORT)" };

        public static ISCPDocumentation Parse(string file)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo documentationFile = new FileInfo(file);

            MatchCollection versionCapture = Regex.Matches(documentationFile.Name, "[0-9]+");
            int fileVerion = 0;
            if (versionCapture.Count > 0)
            {
                fileVerion = int.Parse(versionCapture[0].Value);

            }
            else
            {
                throw new Exception("Could not determine documetation file version");
            }

            ISCPDocumentation documentation = new ISCPDocumentation(new Version(fileVerion / 100, fileVerion % 100));



            using (var package = new ExcelPackage(documentationFile))
            {
                // Loop through alls sheets with commands.
                foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets.Where(x => worksheetsToParse.Contains(x.Name)))
                {
                    Dictionary<int, string[]> modelsInCurrentSheet = new Dictionary<int, string[]>();
                    // Discover all possible models in current sheet and add to the model list.
                    // also used to fix line breaks with "()" attributes
                    for (int s = 0; worksheet.Cells[2, 3 + s].Value != null; s++)
                    {
                        if (worksheet.Cells[2, 3 + s].Value != null)
                        {
                            List<string> tempModels = worksheet.Cells[2, 3 + s].Value.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList<string>();

                            for (int i = 0; i < tempModels.Count; i++)
                            {
                                // Fix for missing line break...
                                if (tempModels[i] == "TX-NR5000ETX-NA1000")
                                {
                                    tempModels.Insert(i + 1, "TX-NA1000");
                                    tempModels[i] = "TX-NR5000E";
                                }

                                if (tempModels[i][0] == '(')
                                {
                                    tempModels[i - 1] += $" {tempModels[i]}";
                                    tempModels.RemoveAt(i);
                                }
                            }
                            modelsInCurrentSheet.Add(3 + s, tempModels.ToArray());
                        }
                    }

                    // Every column can have multiple model names in it.
                    documentation.AddModels(modelsInCurrentSheet.SelectMany(x => x.Value).ToArray());

                    // parse commands
                    if (Regex.IsMatch(worksheet.Name, "^CMND\\((?<zoneName>.*)\\)$") == true)
                    {
                        // Extract the "zonename" from the worksheet name
                        string zoneName = Regex.Match(worksheet.Name, "^CMND\\((?<zoneName>.*)\\)$").Groups["zoneName"].ToString();

                        Debug.WriteLine($"Zone: {zoneName}");

                        int column = worksheet.Dimension.Start.Column;

                        // Loop through all rows documenting the commands listed by the current worksheet.
                        for (int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row;)
                        {

                            // Find commands based on regex
                            if (worksheet.Cells[row, column].Value != null
                                && worksheet.Cells[row, column].Value.GetType() == typeof(String)
                                && Regex.IsMatch(worksheet.Cells[row, column].Value.ToString(), "\"(?<command>.*)\" - (?<description>.*)") == true)
                            {
                                GroupCollection commandGroup = Regex.Match(worksheet.Cells[row, column].Value.ToString(), "\"(?<command>.*)\" - (?<description>.*)").Groups;

                                ISCPCommandDocumentation commandDocumentation = new ISCPCommandDocumentation();
                                commandDocumentation.Zone = zoneName;
                                commandDocumentation.Name = commandGroup["command"].ToString().Trim();
                                commandDocumentation.Description = commandGroup["description"].ToString().Trim();

                                Debug.WriteLine($"Command: {commandGroup["command"]}");
                                //Console.WriteLine($"{worksheet.Cells[row, column].Value} {worksheet.Cells[row, column].Style.Fill.BackgroundColor.Indexed}");

                                // Add values to a command
                                // Go to next row to find first value line
                                row++;
                                while (worksheet.Cells[row, column].Value != null
                                    && worksheet.Cells[row, column].Value.GetType() == typeof(String)
                                    && worksheet.Cells[row, column + 1].Value != null
                                    && worksheet.Cells[row, column + 1].Value.GetType() == typeof(String)
                                    && Regex.IsMatch(worksheet.Cells[row, column].Value.ToString(), "\"(?<command>.*)\" - (?<description>.*)") == false)
                                {
                                    //GroupCollection valueGroup = Regex.Match(worksheet.Cells[row, column].Value.ToString(), "\"(?<command>.*)\" - (?<description>.*)").Groups;

                                    // filter * rows.
                                    if (worksheet.Cells[row, column].Value.ToString().StartsWith("*") == false)
                                    {
                                        //List<string> supportedModels = new List<string>();
                                        //for (int s = 0; worksheet.Cells[2, column + 3 + s].Value != null; s++)
                                        //{
                                        //    if (worksheet.Cells[row, column + 2 + s].Value != null
                                        //        && worksheet.Cells[row, column + 2 + s].Value.ToString().StartsWith("Yes"))
                                        //    {
                                        //        supportedModels.AddRange(worksheet.Cells[2, column + 2 + s].Value.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
                                        //    }
                                        //    //if (worksheet.Cells[2, column + 3 + s].Value == null)
                                        //    //{
                                        //    //    break;
                                        //    //}
                                        //}

                                        List<string> supportedModels = new List<string>();
                                        for (int s = 1; worksheet.Cells[2, 2 + s].Value != null; s++)
                                        {
                                            if (worksheet.Cells[row, 2 + s].Value != null
                                                && worksheet.Cells[row, 2 + s].Value.ToString().StartsWith("Yes"))
                                            {
                                                //supportedModels.AddRange(worksheet.Cells[2, column + 2 + s].Value.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
                                                // Add models from the preparsed and fixed modellist of the current sheet.
                                                supportedModels.AddRange(modelsInCurrentSheet[2 + s]);
                                            }
                                            //if (worksheet.Cells[2, column + 3 + s].Value == null)
                                            //{
                                            //    break;
                                            //}
                                        }

                                        //string temp = string.Join(", ", supportedModels);
                                        //if (temp.Length > 10)
                                        //{
                                        //    Console.WriteLine(temp.Substring(10));
                                        //}
                                        //else
                                        //{
                                        //    Console.WriteLine(temp);
                                        //}

                                        Debug.WriteLine($"Value: {worksheet.Cells[row, column].Value.ToString().Trim('”').Trim('"')}, Value description: {worksheet.Cells[row, column + 1].Value.ToString()}");
                                        commandDocumentation.Values2.Add(new ISCPCommandValueDocumentation()
                                        {
                                            Name = new string[] { worksheet.Cells[row, column].Value.ToString().Trim('”').Trim('"') },
                                            Description = worksheet.Cells[row, column + 1].Value.ToString(),
                                            SupportedDevices = supportedModels.ToArray()
                                        });
                                    }

                                    //Console.WriteLine($"{worksheet.Cells[row, column].Value} {worksheet.Cells[row, column].Style.Fill.BackgroundColor.Indexed}");
                                    row++;
                                }


                                if (string.IsNullOrEmpty(commandDocumentation.Name) == false)
                                {
                                    documentation.Commands.Add(commandDocumentation);
                                }
                            }
                            else
                            {
                                // Check next row for a command
                                row++;
                            }



                        }


                    }
                }
            }

            // fixes

            // split commands like SPA/SPB
            var temp = documentation.Commands.Where(x => x.Name.Contains('/'));


            // Fix conflicting DIF support
            // Get the supported model list 
            List<string> models = documentation.Commands.Single(x => x.Name == "DIF"
                && x.Description == "Display Mode Command")
                .Values2.Single(x => x.Name[0] == "02").SupportedDevices.ToList();
            // Remove incorrect models
            models.Remove("TX-DS989");
            models.Remove("DTR-9.1");
            models.Remove("RDC-7");
            models.Remove("TX-DS989");
            models.Remove("DTC-9.1");
            models.Remove("RDC-7 (Ver2.0)");
            models.Remove("TX-DS787");
            models.Remove("DTR-7.1");
            // replace models list 
            documentation.Commands.Single(x => x.Name == "DIF"
                && x.Description == "Display Mode Command")
                .Values2.Single(x => x.Name[0] == "02").SupportedDevices = models.ToArray();

            Console.WriteLine("Done!");
            //Console.ReadLine();
            return documentation;
        }
    }
}
    