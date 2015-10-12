using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML.Data.Models
{
    [XmlRoot(ElementName = "match")]
    public class MatchAdapter
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("homeTeamId")]
        public int  HomeTeamId { get; set; }

        [XmlAttribute("awayTeamId")]
        public int  AwayTeamId { get; set; }

        [XmlAttribute("stadiumId")]
        public  int StadiumId { get; set; }

        [XmlAttribute("attendance")]
        public int Attendance { get; set; }

        [XmlAttribute("highScore")]
        public int HomeScore { get; set; }

        [XmlAttribute("awayScore")]
        public int AwayScore { get; set; }

        [XmlAttribute("date")]
        public DateTime Date { get; set; }
    }
}
