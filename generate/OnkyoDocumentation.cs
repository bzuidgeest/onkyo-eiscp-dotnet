using Eiscp.Core;
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

        public static List<ISCPCommandDocumentation> Parse(string file)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            List<ISCPCommandDocumentation> commands = new List<ISCPCommandDocumentation>();

            using (var package = new ExcelPackage(new FileInfo(file)))
            {
                // Loop through alls sheets with commands.
                foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets.Where(x => worksheetsToParse.Contains(x.Name)))
                {
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
                                commandDocumentation.Name = commandGroup["command"].ToString();
                                commandDocumentation.Description = commandGroup["description"].ToString();

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
                                        List<string> supportedModels = new List<string>();
                                        for (int s = 0; worksheet.Cells[2, column + 3 + s].Value != null; s++)
                                        {
                                            if (worksheet.Cells[row, column + 2 + s].Value != null
                                                && worksheet.Cells[row, column + 2 + s].Value.ToString().StartsWith("Yes"))
                                            {
                                                supportedModels.AddRange(worksheet.Cells[2, column + 2 + s].Value.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
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
                                        commandDocumentation.Values2.Add(new ISCPCommandValueDocumentation() { 
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
                                    commands.Add(commandDocumentation);
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
            var temp = commands.Where(x => x.Name.Contains('/'));


            Console.WriteLine("Done!");
            //Console.ReadLine();
            return commands;
        }
    }
}
