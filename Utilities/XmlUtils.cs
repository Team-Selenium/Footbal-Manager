namespace Utilities
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Xml;
    using FootballManager.DtoModels;
    using MsSql.Data;

    /// <summary>
    /// Generator for XML reports and saving them
    /// </summary>
    public static class XmlUtils
    {
        private const string SaveFilePath = @"..\..\..\Data Sources\XML\XML Reports\";
        private const string FileName = "StadiumsReport.xml";
        private const string Version = "1.0";
        private const string Encoding = "UTF-8";
        private const string RootName = "stadiums";

        /// <summary>
        /// Creates XML reports and save them as a XML file
        /// </summary>
        public static void XmlCreateReports(ICollection<DtoStadiumReport> stadiumReports)
        {
            var stadiumReport = stadiumReports;

            XmlDocument xmlReport = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlReport.CreateXmlDeclaration(Version, Encoding, null);
            XmlElement root = xmlReport.CreateElement(RootName);
            
            foreach (var stadium in stadiumReport)
            {
                XmlElement stadiumElement = xmlReport.CreateElement("stadium");
                stadiumElement.SetAttribute("id", stadium.Id.ToString());
                
                XmlElement stadiumName = xmlReport.CreateElement("name");
                stadiumName.InnerText = stadium.Name;

                XmlElement stadiumCapacity = xmlReport.CreateElement("capacity");
                stadiumCapacity.InnerText = stadium.Capacity.ToString();

                XmlElement stadiumTownName = xmlReport.CreateElement("town");
                stadiumTownName.InnerText = stadium.TownName;

                stadiumElement.AppendChild(stadiumName);
                stadiumElement.AppendChild(stadiumCapacity);
                stadiumElement.AppendChild(stadiumTownName);
                root.AppendChild(stadiumElement);
            }

            xmlReport.AppendChild(xmlDeclaration);
            xmlReport.AppendChild(root);
            xmlReport.Save(SaveFilePath+FileName);
            Process.Start(SaveFilePath);
        }
    }
}
