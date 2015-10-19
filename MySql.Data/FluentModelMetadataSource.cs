namespace MySql.Data
{
    using System.Collections.Generic;
    using Telerik.OpenAccess.Metadata;
    using Telerik.OpenAccess.Metadata.Fluent;

    public partial class FluentModelMetadataSource : FluentMetadataSource
    {
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> configurations =
                new List<MappingConfiguration>();

            var teamReportMapping = new MappingConfiguration<TeamReportDto>();

            teamReportMapping.MapType(tr => new
            {
                Name = tr.Name,
                Owner = tr.Owner,
                Coach = tr.Coach,
                NumberOfPlayers = tr.NumberOfPlayers,
                NumberOfMatches = tr.NumbersOfMatches
            }).ToTable("TeamReports");



            teamReportMapping.HasProperty(c => c.Id).IsIdentity(KeyGenerator.Autoinc);

            configurations.Add(teamReportMapping);

            return configurations;
        }
    }
}