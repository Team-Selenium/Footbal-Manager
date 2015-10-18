namespace Football.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

        public int Number { get; set; }

        public decimal Salary { get; set; }

        public Position Position { get; set; }
    }
}