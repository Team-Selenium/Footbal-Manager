﻿namespace Football.Client
{
    using System;
    using System.Data;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Windows.Forms;
    using MongoDb.Data;
    using MsSql.Data;

    public partial class FootballManagerClient : Form
    {
        public FootballManagerClient()
        {
            this.InitializeComponent();
        }

        private async void CreateSqlServerDb_Click(object sender, EventArgs e)
        {
            var repo = new MSSqlRepository();
            try
            {
                await repo.CreteDb();
                MessageBox.Show(
                    "The db is created",
                    "Db creation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // Find appropriate exception
            }
        }

        private async void GetMongoData_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new MongoDbRepository();

                var teams = (await repo.GetTeamsData()).ToList();
                var stadiums= (await repo.GetStadiumsData()).ToList();

                var ctx = new FootballContext();
                using (ctx)
                {
                    foreach (var team in teams)
                    {
                        if (!ctx.Teams.Any(pl => pl.Id == team.Id))
                        {
                            ctx.Teams.Add(team);
                        }
                    }

                    foreach (var stadium in stadiums)
                    {
                        if (!ctx.Stadiums.Any(pl => pl.Id == stadium.Id))
                        {
                            ctx.Stadiums.Add(stadium);
                        }
                    }


                    ctx.SaveChanges();
                }

                MessageBox.Show(
                    "The teams, couches, stadiums and towns are inserted",
                    "Teams insert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (DataException)
            {
                MessageBox.Show(
                    "No connection to MongoDb!!!",
                    "MongoDb",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FillDatFromZip_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var repo = new MSSqlRepository();
            try
            {
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

                MessageBox.Show(
                    "The players are inserted",
                    "Players insert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "Error reading file!",
                    "Players insert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}