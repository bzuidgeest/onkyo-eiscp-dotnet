using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
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
        private static string[] worksheetsToParse = { "CMND(MAIN)", "CMND(ZONE2)", "CMND(ZONE3)", "CMND(ZONE4)", "CMND(NET USB)" };





        public static string Parse(string file)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(file)))
            {
                // Loop through alls sheets with commands.
                foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets.Where(x => worksheetsToParse.Contains(x.Name)))
                {
                    if (Regex.IsMatch(worksheet.Name, "^CMND\\((?<zoneName>.*)\\)$") == true)
                    {
                        // Extract the "zonename" from the worksheet name
                        string zoneName = Regex.Match(worksheet.Name, "^CMND\\((?<zoneName>.*)\\)$").Groups["zoneName"].ToString();

                        Console.WriteLine(zoneName);

                        int column = worksheet.Dimension.Start.Column;

                        // Loop through all rows documentign the commands listed by the current worksheet.
                        for (int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row; row++)
                        {
                            // very nasty but mostly all commands seem to use background color index 41 first deviation is SPA/SPB
                            //if (worksheet.Cells[row, column].Style.Fill.BackgroundColor.Indexed == 41)
                            if (worksheet.Cells[row, column].Value != null
                                && worksheet.Cells[row, column].Value.GetType() == typeof(String)
                                && Regex.IsMatch(worksheet.Cells[row, column].Value.ToString(), "\"(?<command>.*)\" - (?<description>.*)") == true)
                            {
                                GroupCollection commandGroup = Regex.Match(worksheet.Cells[row, column].Value.ToString(), "\"(?<command>.*)\" - (?<description>.*)").Groups;
                                Console.WriteLine($"{commandGroup["command"]}");


                                //Console.WriteLine($"{worksheet.Cells[row, column].Value} {worksheet.Cells[row, column].Style.Fill.BackgroundColor.Indexed}");
                            }
                        }


                    }
                }
            }

            Console.ReadLine();
            return "";
        }
    }
}
