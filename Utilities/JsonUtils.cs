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

        private static void SaveReport(DtoTeamReport report, string teamName)
        {
            var jsonReport = JsonConvert.SerializeObject(report, Formatting.Indented);
            File.WriteAllText(SaveFilePath + teamName + ".json", jsonReport.ToString());
        }

    }
}
