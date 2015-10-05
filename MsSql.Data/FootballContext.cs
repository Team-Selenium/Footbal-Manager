using Football.Models;
using MsSql.Data.Migrations;

namespace MsSql.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FootballContext : DbContext
    {
        public FootballContext()
            : base("name=FootballContext")
        {
            var migrationStrategy = new MigrateDatabaseToLatestVersion<FootballContext, Configuration>();
            Database.SetInitializer(migrationStrategy);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasMany(t => t.Matches).WithRequired(t => t.HomeTeam);
            modelBuilder.Entity<Team>().HasMany(t => t.Matches).WithRequired(t => t.AwayTeam);
        }

        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Stadium> Stadiums { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
    }

}