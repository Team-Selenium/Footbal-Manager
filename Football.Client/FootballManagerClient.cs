using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDb.Data;
using MsSql.Data;

namespace Football.Client
{
    public partial class FootballManagerClient : Form
    {
        public FootballManagerClient()
        {
            InitializeComponent();
        }

        private async void CreateSqlServerDb_Click(object sender, EventArgs e)
        {
            var repo = new MSSqlRepository();
            await repo.CreteDb();

        }

        private async void GetMongoData_Click(object sender, EventArgs e)
        {
            var repo = new MongoDbRepository();

            var teams = (await repo.GetData()).ToList();

            var ctx = new FootballContext();

            foreach (var team in teams)
            {
                if (!ctx.Teams.Any(pl => pl.Id == team.Id))
                {
                    ctx.Teams.Add(team);
                }
            }

            ctx.SaveChanges();
        }

        private void FillDatFromZip_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var repo = new MSSqlRepository();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                var zip = ZipFile.Open(filePath, ZipArchiveMode.Read);
                using (zip)
                {
                    var teams = Utilities.ExcelUtils.GetAllPlayers(zip);
                    repo.FillPlayersFromZip(teams);
                }
            }
        }
    }
}
