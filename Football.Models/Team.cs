namespace Football.Models
{
    using System.Collections.Generic;

    public class Team
    {
        private ICollection<Player> players;
        private ICollection<Match> matches;

        public Team()
        {
            this.players = new HashSet<Player>();
            this.matches = new HashSet<Match>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public int CoachId { get; set; }

        public virtual Coach Coach { get; set; }

        public virtual ICollection<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }

        public virtual ICollection<Match> Matches
        {
            get { return this.matches; }
            set { this.matches = value; }
        }
    }
}