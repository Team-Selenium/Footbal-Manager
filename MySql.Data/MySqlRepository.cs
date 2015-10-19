namespace MySql.Data
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using FootballManager.DtoModels;
    using Newtonsoft.Json;
    using Telerik.OpenAccess;

    public class MySqlRepository
    {
        public void ImportDbDataFromJson(string path)
        {
            var ctx = new FluentModel();


            using (ctx)
            {
                var files = Directory.GetFiles(path);

                var teams = ctx.GetAll<TeamReportDto>().ToList();

                foreach (var file in files)
                {
                    var fileText = File.ReadAllText(file);
                    var teamReport = JsonConvert.DeserializeObject<TeamReportDto>(fileText);

                    var teamReportDb = ctx.TeamReports.FirstOrDefault(t => t.Name == teamReport.Name);
                    if (teamReportDb != null)
                    {
                        teamReportDb.Name = teamReport.Name;
                        teamReportDb.NumberOfPlayers = teamReport.NumberOfPlayers;
                        teamReportDb.NumbersOfMatches = teamReport.NumbersOfMatches;
                        teamReportDb.Coach = teamReport.Coach;
                        teamReportDb.Owner = teamReport.Owner;
                    }
                    else
                    {
                        ctx.Add(teamReport);
                        ctx.SaveChanges();
                    }
                }
            }
        }

        public IList<DtoTeamReport> GetTeamReports()
        {
            var ctx = new FluentModel();

            return ctx.TeamReports.Select(tr => new DtoTeamReport
            {
                Id = tr.Id,
                Name = tr.Name,
                Coach = tr.Coach,
                Owner = tr.Owner,
                NumberOfPlayers = tr.NumberOfPlayers,
                NumbersOfMatches = tr.NumbersOfMatches
            }).ToList();
        }

        public void UpdateDatabase()
        {
            using (var context = new FluentModel())
            {
                var schemaHandler = context.GetSchemaHandler();
                EnsureDB(schemaHandler);
            }
        }

        private void EnsureDB(ISchemaHandler schemaHandler)
        {
            string script = null;
            if (schemaHandler.DatabaseExists())
            {
                script = schemaHandler.CreateUpdateDDLScript(null);
            }
            else
            {
                schemaHandler.CreateDatabase();
                script = schemaHandler.CreateDDLScript();
            }

            if (!string.IsNullOrEmpty(script))
            {
                schemaHandler.ExecuteDDLScript(script);
            }
        }
    }
}
