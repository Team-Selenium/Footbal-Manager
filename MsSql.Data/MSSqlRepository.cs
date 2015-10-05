using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSql.Data
{
    public class MSSqlRepository
    {
        public async Task CreteDb()
        {
            var ctx = new FootballContext();
            using (ctx)
            {
                var players = ctx.Players.ToListAsync();
                var task = ctx.SaveChangesAsync();

                await Task.WhenAll(players, task);
            }
        }
    }
}
