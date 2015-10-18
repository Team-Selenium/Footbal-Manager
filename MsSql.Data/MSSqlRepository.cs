namespace MsSql.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using Football.Models;

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


        public void GetWithDataAccess()
        {
            // Get all assemblies loaded in the current domain.
            System.Text.StringBuilder strbuf = new System.Text.StringBuilder();
            System.Reflection.Assembly[] assemblies =
            System.AppDomain.CurrentDomain.GetAssemblies();
            foreach (System.Reflection.Assembly assembly in assemblies)
            {
                string name = assembly.FullName;
                strbuf.Append(name).Append("\r\n");
                // Check if the current assembly
                // is marked with the EnhancedExAttribute.
                object[] customAttributes = assembly.GetCustomAttributes(typeof(Telerik.OpenAccess.RT.EnhancedExAttribute), false);
                if (customAttributes.Length == 1)
                {
                    strbuf.Append(" Enhanced!\r\n");
                    // Print all persistent capable classes in the assembly.
                    foreach (Type t in assembly.GetTypes())
                        if (typeof(Telerik.OpenAccess.SPI.dataobjects.PersistenceCapable)
                        .IsAssignableFrom(t))
                            strbuf.Append(" Persistent Type: ")
                            .Append(t.FullName).Append("\r\n");
                }
            }
            System.Console.WriteLine(strbuf.ToString());
            var ctx = new FluentModel();

            var teams = ctx.GetAll<Team>();

            Console.WriteLine(teams.Count());


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