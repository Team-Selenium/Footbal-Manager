using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            var players = (await repo.GetPlayers()).ToList();

            var ctx = new FootballContext();

            foreach (var player in players)
            {
                if (!ctx.Players.Any(pl => pl.Id == player.Id))
                {
                    ctx.Players.Add(player);
                }
            }

            ctx.SaveChanges();
        }
    }
}
