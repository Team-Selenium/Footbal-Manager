namespace Utilities
{
    using System.Diagnostics;
    using System.IO;
    using FootballManager.DtoModels;
    using MsSql.Data;
    using Newtonsoft.Json;

    public static class JsonUtils
    {
        private const string SaveFilePath = @"..\..\..\Data Sources\JSON\";

        /// <summary>
        /// Creates all JSON reports and save them in text file
        /// </summary>
        public static void JsonCreateReports()
        {
            var repo = new MSSqlRepository();

            var teamReports = repo.GetTeamReport();

            foreach (var report in teamReports)
            {
                SaveReport(report, report.Name);
            }

            Process.Start(SaveFilePath);
        }

        /// <summary>
        /// Save report in text file
        /// </summary>
        /// <param name="report">Gets a report of type DtoTeamReport</param>
        /// <param name="teamName">Gets a string - name of team</param>
        private static void SaveReport(DtoTeamReport report, string teamName)
        {
            var jsonReport = JsonConvert.SerializeObject(report, Formatting.Indented);
            File.WriteAllText(SaveFilePath + teamName + ".json", jsonReport.ToString());
        }
    }
}
