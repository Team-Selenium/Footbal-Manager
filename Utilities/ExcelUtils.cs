using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Excel;
using Football.Models;
using ICSharpCode.SharpZipLib.Zip;

namespace Utilities
{
    public static class ExcelUtils
    {
        public static Dictionary<string, List<Player>> GetAllPlayers(ZipArchive zip)
        {
            List<List<string>> sales = new List<List<string>>();
            var teamPlayers = new Dictionary<string, List<Player>>();

            foreach (var entry in zip.Entries)
            {
                if (entry.FullName.EndsWith(".xls"))
                {
                    using (var ms = new MemoryStream())
                    {
                        CopyStream(entry.Open(), ms);

                        var excelReader = ExcelReaderFactory.CreateBinaryReader(ms);
                        excelReader.IsFirstRowAsColumnNames = true;
                        var dataSet = excelReader.AsDataSet();

                        var team = entry.FullName.Split('.')[0];

                        if (!teamPlayers.ContainsKey(team))
                        {
                            teamPlayers.Add(team, new List<Player>());
                        }
                        

                        for (int i = 0; i < dataSet.Tables.Count; i++)
                        {
                            for (int j = 0; j < dataSet.Tables[i].Rows.Count; j++)
                            {
                                var player = new Player()
                                {
                                    FirstName = dataSet.Tables[i].Rows[j][1].ToString(),
                                    LastName = dataSet.Tables[i].Rows[j][2].ToString(),
                                    Number = int.Parse(dataSet.Tables[i].Rows[j][3].ToString()),
                                    Position =
                                        (Position) Enum.Parse(typeof(Position),dataSet.Tables[i].Rows[j][4].ToString()),
                                    Salary = decimal.Parse(dataSet.Tables[i].Rows[j][6].ToString()),
                                };

                                teamPlayers[team].Add(player);
                            }
                        }
                    }
                }
            }

            return teamPlayers;
        }




        private static void CopyStream(Stream input, Stream output)
        {
            var buffer = new byte[2048];
            int read = input.Read(buffer, 0, buffer.Length);
            while (read > 0)
            {
                output.Write(buffer, 0, read);
                read = input.Read(buffer, 0, buffer.Length);
            }
        }
    }
}
