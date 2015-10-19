using System.Linq;

namespace MySql.Data
{
    using FootballManager.DtoModels;
    using Telerik.OpenAccess;
    using Telerik.OpenAccess.Metadata;

    public partial class FluentModel : OpenAccessContext
    {
        private static string connectionStringName = @"MySqlConnection";

        private static BackendConfiguration backend =
            GetBackendConfiguration();

        private static MetadataSource metadataSource =
            new FluentModelMetadataSource();

        public FluentModel()
            : base(connectionStringName, backend, metadataSource)
        { }

        public IQueryable<TeamReportDto> TeamReports
        {
            get
            {
                return this.GetAll<TeamReportDto>();
            }
        }

        public static BackendConfiguration GetBackendConfiguration()
        {
            BackendConfiguration backend = new BackendConfiguration();
            backend.Backend = "MySql";
            backend.ProviderName = "MySql.Data.MySqlClient";

            return backend;
        }
    }
}
