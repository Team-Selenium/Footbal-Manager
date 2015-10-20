namespace Football.Models
{
    public class Stadium
    {
        /// <summary>
        /// Gets or sets stadium's id as integer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets stadium's name as string
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets stadium's Capacity as integer
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Gets or sets the town id of the stadium as integer
        /// </summary>
        public int TownId { get; set; }

        /// <summary>
        /// Gets or sets the town of the stadium as object
        /// </summary>
        public virtual Town Town { get; set; }
    }
}