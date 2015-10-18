namespace MsSql.Data
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using Football.Models;
    using Newtonsoft.Json;
    using FootballManager.DtoModels;

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
    }
}