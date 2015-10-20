namespace FootballManager.DtoModels
{
    /// <summary>
    /// Data transfer object for stadium reports
    /// </summary>
    public class DtoStadiumReport
    {
        /// <summary>
        /// Gets and sets staduium's id 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets and sets stadium's name as string
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets and sets stadium's capacity as integer
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Gets and sets stadium's town name as string
        /// </summary>
        public string TownName { get; set; }
    }
}
