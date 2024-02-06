namespace backend.Models {

    public class Winrace{
        public int WinraceId { get; set; }
        public string? Namerace { get; set; }
        public int? DriverId { get; set; }
        public Driver? Driver { get; set; }
    }
}