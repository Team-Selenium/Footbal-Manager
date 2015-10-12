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
        public ICollection<Match> GetAllMatches(string path)
        {
            XDocument doc = XDocument.Load(path);
            var matches = doc.Descendants("match");

            foreach (var  match in matches)
            {
                Console.WriteLine(match.ToString());
                StringReader reader = new StringReader(match.ToString());
                XmlSerializer mySerializer = new XmlSerializer(typeof(MatchAdapter));
                MatchAdapter current=(MatchAdapter)mySerializer.Deserialize(reader);
                Console.WriteLine(current.StadiumId);
            }

            return new List<Match>();
        }
    }
}
