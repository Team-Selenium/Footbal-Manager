namespace Football.Models
{
    public class Owner
    {
        /// <summary>
        /// Gets or sets owner's id as integer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets owner's first name as string
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets owner's last name as string
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets owner's money as a decimal number
        /// </summary>
        public decimal Money { get; set; }
    }
}