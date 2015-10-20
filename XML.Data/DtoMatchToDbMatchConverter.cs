namespace XML.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Football.Models;
    using MsSql.Data;

    public class DtoMatchToDbMatchConverter
    {
        public DtoMatchToDbMatchConverter(IXmlToDtoMatchConverter dtoModels, FootballContext db)
        {
            this.DtoModels = dtoModels;
            this.Db = db;
        }

        internal IXmlToDtoMatchConverter DtoModels { get; set; }

        internal FootballContext Db { get; set; }

        /// <summary>
        /// Gets all matches
        /// </summary>
        /// <returns>Returns a collections of Match</returns>
        public ICollection<Match> GetAllMatches()
        {
            var dtoMatches = this.DtoModels.GetAllDtoMatches();
            var validTeamIds = this.Db.Teams.Select(t => t.Id).ToList();
            var validStadiumIds = this.Db.Stadiums.Select(t => t.Id).ToList();
            var resultMatches = new HashSet<Match>();

            foreach (var dtoMatch in dtoMatches)
            {
                var areValidTeamIds = validTeamIds.Contains(dtoMatch.HomeTeamId) && validTeamIds.Contains(dtoMatch.AwayTeamId);
                var isValidStadiumId = validStadiumIds.Contains(dtoMatch.StadiumId);

                if (areValidTeamIds && isValidStadiumId)
                {
                    var matchToAdd = new Match()
                    {
                        HomeTeamId = dtoMatch.HomeTeamId,
                        AwayTeamId = dtoMatch.AwayTeamId,
                        Attendance = dtoMatch.Attendance,
                        AwayScore = dtoMatch.AwayScore,
                        HomeScore = dtoMatch.HomeScore,
                        Date = dtoMatch.Date,
                        StadiumId = dtoMatch.StadiumId
                    };

                    resultMatches.Add(matchToAdd);
                }
            }

            return resultMatches;
        }
    }
}
