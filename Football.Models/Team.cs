namespace Football.Models
{
    using System.Collections.Generic;

    public class Team
    {
        private ICollection<Player> players;
        private ICollection<Match> matches;

        /// <summary>
        /// Constructor for team object
        /// </summary>
        public Team()
        {
            this.players = new HashSet<Player>();
            this.matches = new HashSet<Match>();
        }

        /// <summary>
        /// Gets or sets the team id as integer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the team name as string
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the owner's id as integer
        /// </summary>
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the owner of the team as object
        /// </summary>
        public virtual Owner Owner { get; set; }

        /// <summary>
        /// Gets or sets the coach's id as integer
        /// </summary>
        public int CoachId { get; set; }

        /// <summary>
        /// Gets or sets the coach of the team as object
        /// </summary>
        public virtual Coach Coach { get; set; }

        /// <summary>
        /// Gets or sets the players of the team as collection
        /// </summary>
        public virtual ICollection<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }

        /// <summary>
        /// Gets or sets the matches of the team as collection
        /// </summary>
        public virtual ICollection<Match> Matches
        {
            get { return this.matches; }
            set { this.matches = value; }
        }
    }
}