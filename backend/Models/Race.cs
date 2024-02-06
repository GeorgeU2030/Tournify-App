namespace backend.Models {

    public class Race {
        public int RaceId { get; set; }

        public string? Namerace { get; set; }
        public string? Logorace { get; set; }
        public string? Country { get; set; }

        public int? SeasonraceId { get; set; }
        public Seasonrace? Seasonrace { get; set; }

        public DriverSeason? Winner { get; set; }
        public DriverSeason? Second { get; set; }
        public DriverSeason? Third { get; set; }
        public DriverSeason? Fourth { get; set; }
        public DriverSeason? Fifth { get; set; }
        public DriverSeason? Sixth { get; set; }
        public DriverSeason? Seventh { get; set; }
        public DriverSeason? Eighth { get; set; }
        public DriverSeason? Ninth { get; set; }
        public DriverSeason? Tenth { get; set; }

    }
}