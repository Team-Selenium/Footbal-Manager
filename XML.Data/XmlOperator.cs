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
    }
}
