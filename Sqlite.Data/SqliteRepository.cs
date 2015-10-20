namespace Sqlite.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using FootballManager.DtoModels;

    /// <summary>
    /// SQLite repository
    /// </summary>
    public class SqliteRepository
    {
        /// <summary>
        /// Gets product data - TeamName, JerseyColor, ShortsColor, LeagueTitles, Cuptitles, KitsPrice, BootsPrice and Id
        /// </summary>
        /// <returns>Returns an IList of TeamInfoDto</returns>
        public IList<TeamInfoDto> GetProductTaxData()
        {
            var ctx = new TeamInfoEntities();

            return ctx.TeamInfoes.Select(ti => new TeamInfoDto
            {
                TeamName = ti.TeamName,
                JerseyColor = ti.JerseyColor,
                ShortsColor = ti.ShortsColor,
                LeagueTitles = ti.LeagueTitles,
                CupTitles = ti.CupTitles,
                KitsPrice = ti.KitsPrice,
                BootsPrice = ti.BootsPrice,
                Id = ti.Id
            }).ToList();
        }
    }
}