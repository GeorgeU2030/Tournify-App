using backend.Models;
using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class SeasonteamController: ControllerBase {
    private readonly AppDbContext _context;

    public SeasonteamController(AppDbContext context){
        _context = context;
    }

    [HttpGet]
    [Route("GetSeasonteams")]
    public async Task<ActionResult<IEnumerable<SeasonTeam>>> GetSeasonteams(){
        return await _context.SeasonTeams.ToListAsync();
    }

    [HttpPost]
    [Route("AddSeasonteam")]
    public async Task<ActionResult<SeasonTeam>> AddSeasonteam(SeasonTeam seasonteam){
        _context.SeasonTeams.Add(seasonteam);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetSeasonteams", new { id = seasonteam.SeasonTeamId }, seasonteam);
    }
}