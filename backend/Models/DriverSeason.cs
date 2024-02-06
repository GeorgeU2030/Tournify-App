namespace backend.Models {
    public class DriverSeason{

        public int DriverSeasonId {get;set;}
        public string? NameDriverseason {get;set;}
        public string? Photo {get;set;}
        public string? RacingTeam {get;set;}
        public string? LogoTeam {get;set;}
        public int? Seasonpoints {get;set;}
        public int? Seasonwins {get;set;}
        public int? SeasonraceId {get;set;}
        public Seasonrace? Seasonrace {get;set;}

    }
}