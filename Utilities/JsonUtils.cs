using MsSql.Data;

namespace Utilities
{
    public class JsonUtils
    {
        public void JsonCreateReports()
        {
            var repo = new MSSqlRepository();

            var teamReports = repo.GetTeamReport();
        }

    }
}
