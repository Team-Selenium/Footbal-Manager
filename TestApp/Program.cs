using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;
using MongoDb.Data;
using MsSql.Data;
using Utilities;
using XML.Data;

namespace TestApp
{
    class Program
    {
        private const string zipPlayersPath = "../../../Data Sources/ZIP/Players.zip";
        private const string xmlMatchesPath = "../../../Data Sources/XML/Matches.xml";

        static void Main(string[] args)
        {
            //var zip = System.IO.Compression.ZipFile.Open(zipPlayersPath, ZipArchiveMode.Read);

            //using (zip)
            //{
            //    var teams = ExcelUtils.GetAllPlayers(zip);
            //   // var repo = new MSSqlRepository();

            //    //repo.FillPlayersFromZip(teams);
            //}

            var xmlOperator = new XmlOperator();
            var matches=xmlOperator.GetAllMatches(xmlMatchesPath);

            foreach (var match in matches)
            {
                Console.WriteLine("Match Id: "+match.Id);
                Console.WriteLine("HomeTeam Id: " + match.HomeTeamId);
                Console.WriteLine("Attendance: "+match.Attendance);
            }
        }
    }
}
