namespace backend.Models {

    public class Driver {

        public int DriverId { get; set; }
        public string? NameDriver { get; set; }
        public string? Photo { get; set; }
        public int? Points { get; set; }
        public string? RacingTeam { get; set; }
        public string? LogoTeam { get; set; }
        public int? Titles { get; set; }
        public string? Country { get; set; }
        public ICollection<Winrace>? Winraces { get; set; }
    }
}