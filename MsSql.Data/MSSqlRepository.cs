using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football.Models;

namespace MsSql.Data
{
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
