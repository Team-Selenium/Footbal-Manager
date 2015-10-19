namespace MySql.Data
{
    using System.Linq;

    using Telerik.OpenAccess;
    using Telerik.OpenAccess.Metadata;

    public partial class FluentModel : OpenAccessContext
    {
        private const string ConnectionStringName = @"MySqlConnection";
        private const string ProviderName = "MySql.Data.MySqlClient";
        private const string BackEnd = "MySql";

        private static BackendConfiguration backend =
            GetBackendConfiguration();

        private static MetadataSource metadataSource =
            new FluentModelMetadataSource();

        public FluentModel()
            : base(ConnectionStringName, backend, metadataSource)
        {
        }

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
            backend.Backend = BackEnd;
            backend.ProviderName = ProviderName;

            return backend;
        }
    }
}
