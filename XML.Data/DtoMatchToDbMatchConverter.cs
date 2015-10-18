namespace XML.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Football.Models;
    using MsSql.Data;
    using Contracts;

    class DtoMatchToDbMatchConverter
    {
        public DtoMatchToDbMatchConverter(IXmlToDtoMatchConverter DtoModels, FootballContext db)
        {
            this.DtoModels = DtoModels;
            this.Db = db;
        }

        IXmlToDtoMatchConverter DtoModels { get; set; }

        FootballContext Db { get; set; }

        public ICollection<Match> GetAllMatches()
        {
            var dtoMatches = this.DtoModels.GetAllDtoMatches();
            var validTeamIds = this.Db.Teams.Select(t => t.Id).ToList();
            var validStadiumIds = this.Db.Stadiums.Select(t => t.Id).ToList();
            var resultMatches = new HashSet<Match>();

            foreach (var dtoMatch in dtoMatches)
            {
                var areValidTeamIds = validStadiumIds.Contains(dtoMatch.HomeTeamId) && validStadiumIds.Contains(dtoMatch.AwayTeamId);
                var isValidStadiumId = validStadiumIds.Contains(dtoMatch.StadiumId);


                if (areValidTeamIds && isValidStadiumId)
                {

                }
            }


            return new List<Match>();
        }
    }
}
