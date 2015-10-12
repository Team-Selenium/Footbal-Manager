namespace XML.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using contracts;
    using Football.Models;
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using System.Xml;
    using System.IO;
    using Models;

    public class XmlOperator : IXmlOperator
    {
        public IEnumerable<MatchAdapter> GetAllMatches(string path)
        {
            XDocument doc = XDocument.Load(path);
            var xmlFormatMatches = doc.Descendants("match");
            var pocoMatches = new List<MatchAdapter>();

            foreach (var  match in xmlFormatMatches)
            {
                StringReader reader = new StringReader(match.ToString());
                XmlSerializer mySerializer = new XmlSerializer(typeof(MatchAdapter));
                MatchAdapter current=(MatchAdapter)mySerializer.Deserialize(reader);

                pocoMatches.Add(current);
            }

            return pocoMatches;
        }

        public IEnumerable<PlayerAdapter> GetAllPlayers(string path)
        {
            XDocument doc = XDocument.Load(path);
            var xmlFormatPlayers = doc.Descendants("player");
            var pocoPlayers = new List<PlayerAdapter>();

            foreach (var player in xmlFormatPlayers)
            {
                StringReader reader = new StringReader(player.ToString());
                XmlSerializer mySerializer = new XmlSerializer(typeof(PlayerAdapter));
                PlayerAdapter current = (PlayerAdapter)mySerializer.Deserialize(reader);

                pocoPlayers.Add(current);
            }

            return pocoPlayers;
        }
    }
}
