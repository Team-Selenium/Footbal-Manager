namespace FootballManager.DtoModels
{
    /// <summary>
    /// Data transfer object for team info
    /// </summary>
    public class TeamInfoDto
    {
        /// <summary>
        /// Gets and sets Team info's id as an unique integer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets and sets the name of the Team as string
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Gets and sets the color of the Team's jersey as string
        /// </summary>
        public string JerseyColor { get; set; }

        /// <summary>
        /// Gets and sets the color of the Team's shorts as string
        /// </summary>
        public string ShortsColor { get; set; }

        /// <summary>
        /// Gets and sets number of Team's league titles
        /// </summary>
        public int LeagueTitles { get; set; }

        /// <summary>
        /// Gets and sets number of Team's cup titles
        /// </summary>
        public int CupTitles { get; set; }

        /// <summary>
        /// Gets and sets the price of the Team's kits as a decimal number 
        /// </summary>
        public decimal KitsPrice { get; set; }

        /// <summary>
        /// Gets and sets the price of the Team's boots as a decimal number
        /// </summary>
        public decimal BootsPrice { get; set; }
    }
}
