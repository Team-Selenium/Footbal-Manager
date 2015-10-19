namespace Utilities
{
    using FootballManager.DtoModels;
    using MsSql.Data;
    using Newtonsoft.Json;
    using System.IO;

    public static class JsonUtils
    {
        public static void JsonCreateReports()
        {
            var repo = new MSSqlRepository();

            var teamReports = repo.GetTeamReport();

            foreach (var report in teamReports)
            {
                SaveReport(report, report.Id);
            }
        }

        private static void SaveReport(DtoTeamReport report, int id)
        {
            var jsonReport = JsonConvert.SerializeObject(report, Formatting.Indented);
            File.WriteAllText("../../../Data Sources/JSON/" + id + ".json", jsonReport.ToString());
        }

    }
}
