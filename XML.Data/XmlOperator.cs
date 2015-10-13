namespace XML.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using Contracts;
    using Models;

    public class XmlOperator : IXmlOperator
    {
        public IEnumerable<MatchAdapter> GetAllMatches(string path)
        {
            var doc = XDocument.Load(path);
            var xmlFormatMatches = doc.Descendants("match");
            var pocoMatches = new List<MatchAdapter>();

            foreach (var match in xmlFormatMatches)
            {
                var reader = new StringReader(match.ToString());
                var mySerializer = new XmlSerializer(typeof(MatchAdapter));
                var current = (MatchAdapter)mySerializer.Deserialize(reader);

                pocoMatches.Add(current);
            }

            return pocoMatches;
        }

        public IEnumerable<PlayerAdapter> GetAllPlayers(string path)
        {
            var doc = XDocument.Load(path);
            var xmlFormatPlayers = doc.Descendants("player");
            var pocoPlayers = new List<PlayerAdapter>();

            foreach (var player in xmlFormatPlayers)
            {
                var reader = new StringReader(player.ToString());
                var mySerializer = new XmlSerializer(typeof(PlayerAdapter));
                var current = (PlayerAdapter)mySerializer.Deserialize(reader);

                pocoPlayers.Add(current);
            }

            return pocoPlayers;
        }
    }
}