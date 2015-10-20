namespace Football.Models
{
    public class Coach
    {
        /// <summary>
        /// Gets or sets coach's id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets coach's id
        /// </summary>
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }
    }
}