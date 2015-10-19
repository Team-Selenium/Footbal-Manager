namespace MsSql.Data
{
    using System.Data.Entity;
    using Football.Models;
    using Migrations;

    public class FootballContext : DbContext
    {
        public FootballContext()
            : base("name=FootballContext")
        {
            var migrationStrategy = new MigrateDatabaseToLatestVersion<FootballContext, Configuration>();
            Database.SetInitializer(migrationStrategy);
        }

        public virtual DbSet<Team> Teams { get; set; }

        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<Stadium> Stadiums { get; set; }

        public virtual DbSet<Match> Matches { get; set; }

        public virtual DbSet<Coach> Coaches { get; set; }

        public virtual DbSet<Owner> Owners { get; set; }

        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasMany(t => t.Matches).WithRequired(t => t.HomeTeam).HasForeignKey<int>(t => t.HomeTeamId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Team>().HasMany(t => t.Matches).WithRequired(t => t.AwayTeam).HasForeignKey<int>(t => t.AwayTeamId).WillCascadeOnDelete(false);
        }
    }
}