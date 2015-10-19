namespace XML.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using Contracts;
    using Models;

    public class XmlToDtoMatchConverter : IXmlToDtoMatchConverter
    { 
        public XmlToDtoMatchConverter(string path)
        {
            this.Path = path;
        }

        public string Path { get; set; }

        public IEnumerable<DtoMatch> GetAllDtoMatches()
        {
            var doc = XDocument.Load(this.Path);
            var xmlFormatMatches = doc.Descendants("match");
            var pocoMatches = new List<DtoMatch>();

            foreach (var match in xmlFormatMatches)
            {
                var reader = new StringReader(match.ToString());
                var mySerializer = new XmlSerializer(typeof(DtoMatch));
                var current = (DtoMatch)mySerializer.Deserialize(reader);

                pocoMatches.Add(current);
            }

            return pocoMatches;
        }
    }
}