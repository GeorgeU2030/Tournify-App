using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data {
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverSeason> DriverSeasons { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Seasonrace> Seasonraces { get; set; }
        public DbSet<SeasonTeam> SeasonTeams {get;set;}
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments {get;set;}
        public DbSet<Trophy> Trophies {get;set;}
        public DbSet<Winrace> Winraces { get; set; }
    }
}