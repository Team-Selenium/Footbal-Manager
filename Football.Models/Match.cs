namespace Football.Models
{
    using System;

    public class Match
    {
        /// <summary>
        /// Gets or sets match's id as integer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets home team's id as integer
        /// </summary>
        public int HomeTeamId { get; set; }

        /// <summary>
        /// Gets or sets home team as object
        /// </summary>
        public virtual Team HomeTeam { get; set; }

        /// <summary>
        /// Gets or sets away team's id as integer
        /// </summary>
        public int AwayTeamId { get; set; }

        /// <summary>
        /// Gets or sets away team as object
        /// </summary>
        public virtual Team AwayTeam { get; set; }

        /// <summary>
        /// Gets or sets stadium's id as integer
        /// </summary>
        public int StadiumId { get; set; }

        /// <summary>
        /// Gets or sets stadium as object
        /// </summary>
        public virtual Stadium Stadium { get; set; }

        /// <summary>
        /// Gets or sets match's attendance as integer
        /// </summary>
        public int Attendance { get; set; }

        /// <summary>
        /// Gets or sets match's home team score as integer
        /// </summary>
        public int HomeScore { get; set; }

        /// <summary>
        /// Gets or sets match's away team score as integer
        /// </summary>
        public int AwayScore { get; set; }

        /// <summary>
        /// Gets or sets match's date as DateTime object
        /// </summary>
        public DateTime Date { get; set; }
    }
}