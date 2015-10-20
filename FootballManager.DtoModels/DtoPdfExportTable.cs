namespace FootballManager.DtoModels
{
    using System;

    /// <summary>
    /// Data transfer object for reports in PDF
    /// </summary>
    public class DtoPdfExportTable
    {
        /// <summary>
        /// Gets and sets the date of the match as a DateTime object
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets and sets the town of the match as string
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets and sets the stadium of the match as string
        /// </summary>
        public string Stadium { get; set; }

        /// <summary>
        /// Gets and sets the home team as string
        /// </summary>
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets and sets the away team as string
        /// </summary>
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets and sets the result as string
        /// </summary>
        public string Result { get; set; }
    }
}