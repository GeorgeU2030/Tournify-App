namespace backend.Models{
    public class Tournament {
        public int TournamentId { get; set; }

        public string? NameTournament { get; set; }

        public string? Logo { get; set; }

        public ICollection<Season>? Seasons { get; set; }
    }
}