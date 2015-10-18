namespace MsSql.Data
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using Football.Models;
    using Newtonsoft.Json;
    using FootballManager.DtoModels;
    using Pdf.Data.Models;

    public class MSSqlRepository
    {
        public async Task CreteDb()
        {
            using (var ctx = new FootballContext())
            {
                await ctx.Players.ToListAsync();
                await ctx.SaveChangesAsync();
            }
        }

        public ICollection<DtoTeamReport> GetTeamReport()
        {
            var ctx = new FootballContext();

            using (ctx)
            {
                var teamReports = ctx.Teams.Select(t => new DtoTeamReport
                {
                    Id = t.Id,
                    Name = t.Name,
                    Owner = t.Owner.FirstName + " " + t.Owner.LastName,
                    Coach = t.Coach.FirstName + " " + t.Coach.LastName,
                    NumberOfPlayers = t.Players.Count,
                    NumbersOfMatches = t.Matches.Count
                }).ToList();

                return teamReports;
            }
        }

        public void FillMatchesFromXml(ICollection<Match> matches)
        {
            var ctx = new FootballContext();

            using (ctx)
            {
                foreach (var match in matches)
                {
                    ctx.Matches.Add(match);
                }

                ctx.SaveChanges();
            }
        }

        public void FillPlayersFromZip(Dictionary<string, List<Player>> teams)
        {
            var ctx = new FootballContext();

            using (ctx)
            {
                foreach (var team in teams)
                {
                    var team1 = ctx.Teams.FirstOrDefault(t => t.Name == team.Key);

                    if (team1 == null)
                    {
                        continue;
                    }

                    foreach (var player in team.Value)
                    {
                        var currPlayer = ctx.Players
                            .SingleOrDefault(pl => pl.Number == player.Number && pl.Team.Name == team.Key);

                        if (currPlayer == null)
                        {
                            player.Team = team1;
                            ctx.Players.Add(player);
                        }
                        else
                        {
                            currPlayer.Salary = player.Salary;
                            currPlayer.Position = player.Position;
                            currPlayer.FirstName = player.FirstName;
                            currPlayer.LastName = player.LastName;
                        }
                    }
                }

                ctx.SaveChanges();
            }
        }

        public Dictionary<string, List<DtoPdfExportTable>> GetDataForPdfExport()
        {
            using (var ctx = new FootballContext())
            {
                Dictionary<string, List<DtoPdfExportTable>> dataForPdfExport = ctx.Matches
                     .Select(m => new DtoPdfExportTable
                     {
                         Date = m.Date,
                         Town = m.Stadium.Town.Name,
                         Stadium = m.Stadium.Name,
                         HomeTeam = m.HomeTeam.Name,
                         AwayTeam = m.AwayTeam.Name,
                         Result = m.HomeScore + " : " + m.AwayScore
                     })
                     .GroupBy(g => g.Town)
                     .ToDictionary(k => k.Key, v => v.ToList());

                return dataForPdfExport;
            }
        }
    }
}