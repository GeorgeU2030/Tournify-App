namespace backend.Models {
    public class Seasonrace {
        public int SeasonraceId { get; set; }
        public int? Edition { get; set; }
        public ICollection<DriverSeason>? DriverSeasons { get; set; }
        public ICollection<Race>? Races { get; set; }
    }
}