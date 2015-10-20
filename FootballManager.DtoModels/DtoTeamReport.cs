namespace FootballManager.DtoModels
{
    /// <summary>
    /// Data transfer object for team reports in excel and JSON
    /// </summary>
    public class DtoTeamReport
    {
        /// <summary>
        /// Gets and sets team's id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets and sets the name of the Team as string
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets and sets the name of the Team's owner as string
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Gets and sets the name of the Team's coach as string
        /// </summary>
        public string Coach { get; set; }

        /// <summary>
        /// Gets and sets the number of players in a Team as integer
        /// </summary>
        public int NumberOfPlayers { get; set; }

        /// <summary>
        /// Gets and sets the number of matches of a Team as integer
        /// </summary>
        public int NumbersOfMatches { get; set; }
    }
}
