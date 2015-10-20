namespace Football.Models
{
    public class Coach
    {
        /// <summary>
        /// Gets or sets coach's id as integer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets coach's first name as string
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets coach's last name as string
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets coach's salary as a decimal number
        /// </summary>
        public decimal Salary { get; set; }
    }
}