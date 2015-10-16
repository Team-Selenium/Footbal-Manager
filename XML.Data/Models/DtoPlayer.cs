namespace XML.Data.Models
{
    using System.Xml.Serialization;
    using Football.Models;

    [XmlRoot(ElementName = "player")]
    public class DtoPlayer
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("firstName")]
        public string FirstName { get; set; }

        [XmlAttribute("lastName")]
        public string LastName { get; set; }

        [XmlAttribute("teamId")]
        public int TeamId { get; set; }

        [XmlAttribute("number")]
        public int Number { get; set; }

        [XmlAttribute("salary")]
        public decimal Salary { get; set; }

        [XmlAttribute("position")]
        public Position Position { get; set; }
    }
}