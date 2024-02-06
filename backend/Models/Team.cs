
namespace backend.Models{
public class Team
{
    public int TeamId { get; set; }
    public string? NameTeam { get; set; }
    public string? Flag { get; set; }
    public string? Country { get; set; }
    public string? Logo { get; set; }
    public string? Division { get; set; }
    public string? City { get; set; }
    
    public ICollection<Trophy>? Trophies { get; set; }
}

}

