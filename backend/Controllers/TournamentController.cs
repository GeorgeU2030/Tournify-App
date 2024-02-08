using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Data;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class TournamentController : ControllerBase {
    private readonly AppDbContext _context;

    public TournamentController(AppDbContext context){
        _context = context;
    }

    [HttpGet]
    [Route("GetTournaments")]
    public async Task<ActionResult<IEnumerable<Tournament>>> GetTournaments(){
        return await _context.Tournaments.ToListAsync();
    }

    [HttpPost]
    [Route("AddTournament")]
    public async Task<ActionResult<Tournament>> AddTournament(Tournament tournament){
        _context.Tournaments.Add(tournament);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetTournaments", new { id = tournament.TournamentId }, tournament);
    }
}