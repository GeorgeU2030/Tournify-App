namespace backend.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public int? Edition { get; set; }
        public Team? Champion { get; set; }
        public Team? SubChampion { get; set; }
        public int? TournamentId { get; set; }
        public Tournament? Tournament { get; set; }
        public ICollection<Team>? Teams { get; set; }
    }
}