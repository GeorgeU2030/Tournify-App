namespace backend.Models
{
    public class SeasonTeam
    {
        public int SeasonTeamId { get; set; }
        public int SeasonId { get; set; }
        public Season? Season { get; set; }
      
        public string? Nameseasonteam { get; set; }

        public string? Logost { get; set; }

        public int? Win { get; set; }

        public int? Lose { get; set; }

        public int? Draw { get; set; }

        public int? Points { get; set; }

        public int? Gd { get; set; }
    }
}
