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
            
            using (var ctx = new FootballContext())
            {
                await ctx.Players.ToListAsync();
                await ctx.SaveChangesAsync();

            }
        }
    }
}
