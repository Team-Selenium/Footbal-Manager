namespace Football.Models
{
    public class Player
    {
        /// <summary>
        /// Gets or sets player's id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets player's first name as string
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets player's last name as string
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets player's team id as integer
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Gets or sets player's team as object
        /// </summary>
        public virtual Team Team { get; set; }

        /// <summary>
        /// Gets or sets player's number as integer
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets player's salary as decimal number
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Gets or sets player's position as enumeration
        /// </summary>
        public Position Position { get; set; }
    }
}