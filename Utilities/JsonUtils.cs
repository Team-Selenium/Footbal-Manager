namespace Utilities
{
    using FootballManager.DtoModels;
    using MsSql.Data;
    using Newtonsoft.Json;
    using System.IO;

    public class JsonUtils
    {
        public void JsonCreateReports()
        {
            var repo = new MSSqlRepository();

            var teamReports = repo.GetTeamReport();

            foreach (var report in teamReports)
            {
                SaveReport(report, report.Id);
            }
        }

        private void SaveReport(DtoTeamReport report, int id)
        {
            var jsonReport = JsonConvert.SerializeObject(report, Formatting.Indented);
            File.WriteAllText("../../../Data Sources/JSON/" + id + ".json", jsonReport.ToString());
        }

    }
}
