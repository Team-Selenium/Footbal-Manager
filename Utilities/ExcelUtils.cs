namespace Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.IO.Compression;
    using Football.Models;

    public static class ExcelUtils
    {
        public static Dictionary<string, List<Player>> GetAllPlayers(ZipArchive zip)
        {
            var sales = new List<List<string>>();
            var teamPlayers = new Dictionary<string, List<Player>>();

            foreach (var entry in zip.Entries)
            {
                if (entry.FullName.EndsWith(".xls"))
                {
                    using (var ms = new MemoryStream())
                    {
                        var file = File.Create("../../../temp.xls");
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
                        { "Data Source", "../../../temp.xls" }
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
                                    var team = entry.FullName.Split('.')[0];

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

            File.Delete("../../../temp.xls");
            return teamPlayers;
        }


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