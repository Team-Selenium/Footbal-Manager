namespace TestApp
{
    using Pdf.Data;
    using System;
    using System.Collections.Generic;
    using XML.Data;

    internal class Program
    {
        private const string ZipPlayersPath = "../../../Data Sources/ZIP/Players.zip";
        private const string XmlMatchesPath = "../../../Data Sources/XML/Matches.xml";
        private const string XmlPlayersPath = "../../../Data Sources/XML/Players.xml";
        private const string PdfReportPath = "../../../Data Sources/PDF/Report.pdf";

        private static void Main(string[] args)
        {
            // var zip = System.IO.Compression.ZipFile.Open(ZipPlayersPath, ZipArchiveMode.Read);

            // using (zip)
            // {
            //    var teams = ExcelUtils.GetAllPlayers(zip);
            //   // var repo = new MSSqlRepository();

            //    //repo.FillPlayersFromZip(teams);
            //}

            //var xmlOperator = new XmlOperator();
            //var matches = xmlOperator.GetAllMatches(XmlMatchesPath);
            //var players = xmlOperator.GetAllPlayers(XmlPlayersPath);

            //foreach (var match in matches)
            //{
            //    Console.WriteLine("Match Id: " + match.Id);
            //    Console.WriteLine("HomeTeam Id: " + match.HomeTeamId);
            //    Console.WriteLine("Attendance: " + match.Attendance);
            //}

            //foreach (var player in players)
            //{
            //    Console.WriteLine("Player Id: " + player.Id);
            //    Console.WriteLine("HomeTeam Id: " + player.Position);
            //}
            var columnNames = new string[] { "name", "team", "number" };
            var player1= new string[] { "Gosho", "Ludogorec", "1" };
            var player2 = new string[] { "Barbuka", "Nacionalniq", "9" };
            var allPlayers = new List<string[]>();
            allPlayers.Add(player1);
            allPlayers.Add(player2);

            PdfGenerator pdfGenerator = new PdfGenerator();
            pdfGenerator.GeneratePdfDocument(PdfReportPath, columnNames, allPlayers);
        }
    }
}