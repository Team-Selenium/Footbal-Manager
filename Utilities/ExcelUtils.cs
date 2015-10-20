namespace Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using Football.Models;
    using FootballManager.DtoModels;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    /// <summary>
    /// Generator for an Excel report file holding information about players and teams
    /// </summary>
    public static class ExcelUtils
    {
        private const string ExcelReportFilePath = @"..\..\..\Data Sources\Excel";
        private const string ExcelReportFileName = @"\Teams-Info.xlsx";
        private const int NeededBootsPairs = 2;
        private const int NeededKits = 2;
        private const int Columns = 12;
        private const string TempFile = "temp.xls";

        /// <summary>
        /// Gets all players from a ZIP archive
        /// </summary>
        /// <param name="zip">Gets a ZIP archive</param>
        /// <returns>Returns a Dictionary with a key of type string and value ot type List<Player></returns>
        public static Dictionary<string, List<Player>> GetAllPlayers(ZipArchive zip)
        {
            var sales = new List<List<string>>();
            var teamPlayers = new Dictionary<string, List<Player>>();

            foreach (var entry in zip.Entries)
            {
                if (entry.FullName.EndsWith(".xls"))
                {
                    var entryParts = entry.FullName.Split(new char[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
                    var fileName = entry.FullName;
                    if (entryParts.Length > 1)
                    {
                        fileName = entryParts[entryParts.Length - 1];
                    }

                    using (var ms = new MemoryStream())
                    {
                        var file = File.Create(TempFile);
                        using (file)
                        {
                            CopyStream(entry.Open(), ms);
                            ms.WriteTo(file);
                        }
                    }

                    var connection = new OleDbConnection();
                    var connectionString = new OleDbConnectionStringBuilder
                    {
                        { "Provider", "Microsoft.ACE.OLEDB.12.0" },
                        { "Extended Properties", "Excel 12.0 XML" },
                        { "Data Source", TempFile }
                    };

                    connection.ConnectionString = connectionString.ToString();

                    using (connection)
                    {
                        connection.Open();

                        var excelSchema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                        var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();

                        var oleDbCommand = new OleDbCommand("SELECT * FROM [" + sheetName + "]", connection);

                        using (var adapter = new OleDbDataAdapter(oleDbCommand))
                        {
                            var dataSet = new DataSet();
                            adapter.Fill(dataSet);

                            using (var reader = dataSet.CreateDataReader())
                            {
                                while (reader.Read())
                                {
                                    var team = fileName.Split('.')[0];
                                    if (!teamPlayers.ContainsKey(team))
                                    {
                                        teamPlayers.Add(team, new List<Player>());
                                    }

                                    var player = new Player()
                                    {
                                        FirstName = reader["FirstName"].ToString(),
                                        LastName = reader["LastName"].ToString(),
                                        Number = int.Parse(reader["Number"].ToString()),
                                        Position =
                                            (Position)Enum.Parse(typeof(Position), reader["Position"].ToString()),
                                        Salary = decimal.Parse(reader["Salary"].ToString()),
                                    };
                                    Console.WriteLine(player.FirstName);
                                    teamPlayers[team].Add(player);
                                }
                            }
                        }
                    }
                }
            }

            File.Delete(TempFile);
            return teamPlayers;
        }

        /// <summary>
        /// Generate reporting Excel for teams
        /// </summary>
        /// <param name="teamInfos">Gets as first argument a list of TeamInfoDto and list of DtomTeamReport as second argument</param>
        /// <param name="teamReports"></param>
        public static void GenerateExcelReportForTeams(IList<TeamInfoDto> teamInfos, IList<DtoTeamReport> teamReports)
        {
            var newFile = CreateFile();

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Teams Info");

                worksheet.Cells[1, 1].Value = "Team";
                worksheet.Cells[1, 2].Value = "Coach";
                worksheet.Cells[1, 3].Value = "Owner";
                worksheet.Cells[1, 4].Value = "Jersey Color";
                worksheet.Cells[1, 5].Value = "Shorts Color";
                worksheet.Cells[1, 6].Value = "League Titles";
                worksheet.Cells[1, 7].Value = "Cup Titles";
                worksheet.Cells[1, 8].Value = "Needed Kits";
                worksheet.Cells[1, 9].Value = "Needed Boots";
                worksheet.Cells[1, 10].Value = "Kits Price";
                worksheet.Cells[1, 11].Value = "Boots Price";
                worksheet.Cells[1, 12].Value = "Total Costs";

                var currentRow = 2;
                for (int i = 0; i < teamInfos.Count; i++, currentRow++)
                {
                    var teamName = teamInfos[i].TeamName;
                    worksheet.Cells[currentRow, 1].Value = teamName;

                    var teamReportForCurrentTeam = teamReports.FirstOrDefault(tr => tr.Name.ToLower() == teamName.ToLower());

                    worksheet.Cells[currentRow, 2].Value = teamReportForCurrentTeam == null
                        ? "N/A"
                        : teamReportForCurrentTeam.Coach;

                    worksheet.Cells[currentRow, 3].Value = teamReportForCurrentTeam == null
                        ? "N/A"
                        : teamReportForCurrentTeam.Owner;

                    worksheet.Cells[currentRow, 4].Value = teamInfos[i].JerseyColor;
                    worksheet.Cells[currentRow, 5].Value = teamInfos[i].ShortsColor;
                    worksheet.Cells[currentRow, 6].Value = teamInfos[i].LeagueTitles;
                    worksheet.Cells[currentRow, 7].Value = teamInfos[i].CupTitles;

                    var playersCount = 0;
                    if (teamReportForCurrentTeam != null)
                    {
                        playersCount = teamReportForCurrentTeam.NumberOfPlayers;
                    }

                    worksheet.Cells[currentRow, 8].Value = teamReportForCurrentTeam == null
                        ? "N/A"
                        : (NeededKits * playersCount).ToString();

                    worksheet.Cells[currentRow, 9].Value = teamReportForCurrentTeam == null
                        ? "N/A"
                        : (NeededBootsPairs * playersCount).ToString();

                    worksheet.Cells[currentRow, 10].Value = teamReportForCurrentTeam == null
                        ? "N/A"
                        : teamInfos[i].KitsPrice.ToString();

                    worksheet.Cells[currentRow, 11].Value = teamReportForCurrentTeam == null
                        ? "N/A"
                        : teamInfos[i].BootsPrice.ToString();

                    worksheet.Cells[currentRow, 12].Value = teamReportForCurrentTeam == null
                        ? "N/A"
                        : ((teamInfos[i].BootsPrice * NeededBootsPairs * playersCount) + (teamInfos[i].KitsPrice * NeededKits * playersCount)).ToString();
                }

                worksheet.Calculate();
                worksheet.PrinterSettings.Orientation = eOrientation.Landscape;
                worksheet.PrinterSettings.HorizontalCentered = true;
                worksheet.Row(1).Style.Font.Bold = true;
                worksheet.PrinterSettings.PaperSize = ePaperSize.A3;
                worksheet.Cells.AutoFitColumns(0);
                worksheet.View.PageLayoutView = true;
                worksheet.HeaderFooter.FirstHeader.CenteredText = "Team Reports";

                package.Workbook.Properties.Title = "Product Taxes";
                package.Workbook.Properties.Author = "Kor";
                package.Workbook.Properties.Comments = "Fok diz sh*t";

                worksheet.PrinterSettings.ShowGridLines = false;
                for (int i = 1; i <= teamInfos.Count + 1; i++)
                {
                    for (int j = 1; j <= Columns; j++)
                    {
                        if (i == 1)
                        {
                            worksheet.Cells[i, j].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[i, j].Style.Fill.BackgroundColor.SetColor(Color.LightSkyBlue);
                        }

                        worksheet.Cells[i, j].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }
                }

                package.Save();
            }

            Process.Start(ExcelReportFilePath);
        }

        /// <summary>
        /// Creates a file. First check the directory. If it doesn't exist creates a new one then creates a new file
        /// </summary>
        /// <returns>Returns FileInfo</returns>
        private static FileInfo CreateFile()
        {
            if (!Directory.Exists(ExcelReportFilePath))
            {
                Directory.CreateDirectory(ExcelReportFilePath);
            }

            FileInfo newFile = new FileInfo(ExcelReportFilePath + ExcelReportFileName);

            if (newFile.Exists)
            {
                newFile.Delete();
                newFile = new FileInfo(ExcelReportFilePath + ExcelReportFileName);
            }

            return newFile;
        }

        /// <summary>
        /// Copy stream using input and output parameters
        /// </summary>
        /// <param name="input">Gets an input of type Stream</param>
        /// <param name="output">Gets an output of type Stream</param>
        private static void CopyStream(Stream input, Stream output)
        {
            var buffer = new byte[2048];
            var read = input.Read(buffer, 0, buffer.Length);
            while (read > 0)
            {
                output.Write(buffer, 0, read);
                read = input.Read(buffer, 0, buffer.Length);
            }
        }
    }
}