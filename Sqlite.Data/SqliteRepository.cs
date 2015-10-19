namespace Sqlite.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using FootballManager.DtoModels;

    public class SqliteRepository
    {

        public SqliteRepository()
        {
            this.SqliteContext = new TeamInfoEntities();
        }

        public TeamInfoEntities SqliteContext { get; set; }

        public IList<TeamInfoDto> GetProductTaxData()
        {
            return this.SqliteContext.TeamInfoes.Select(ti => new TeamInfoDto
            {
                
                TeamName =  ti.TeamName,
                JerseyColor =  ti.JerseyColor,
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