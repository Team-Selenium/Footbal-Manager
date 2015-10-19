namespace XML.Data.Models
{
    using System;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "match")]
    public class DtoMatch
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("homeTeamId")]
        public int HomeTeamId { get; set; }

        [XmlAttribute("awayTeamId")]
        public int AwayTeamId { get; set; }

        [XmlAttribute("stadiumId")]
        public int StadiumId { get; set; }

        [XmlAttribute("attendance")]
        public int Attendance { get; set; }

        [XmlAttribute("homeScore")]
        public int HomeScore { get; set; }

        [XmlAttribute("awayScore")]
        public int AwayScore { get; set; }

        [XmlAttribute("date")]
        public DateTime Date { get; set; }
    }
}