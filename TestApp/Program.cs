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

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var zip = System.IO.Compression.ZipFile.Open("../../../Players.zip", ZipArchiveMode.Read);

            using (zip)
            {
                var teams = Utilities.ExcelUtils.GetAllPlayers(zip);
                //var repo = new MSSqlRepository();

                //repo.FillPlayersFromZip(teams);
            }

        }
    }
}
