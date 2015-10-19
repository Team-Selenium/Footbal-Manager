namespace Sqlite.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using FootballManager.DtoModels;

    public class SqliteRepository
    {
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