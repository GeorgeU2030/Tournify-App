using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Data;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class TeamController : ControllerBase {
    private readonly AppDbContext _context;

    public TeamController(AppDbContext context){
        _context = context;
    }

    [HttpGet]
    [Route("GetTeams")]
    public async Task<ActionResult<IEnumerable<Team>>> GetTeams(){
        return await _context.Teams.ToListAsync();
    }

    [HttpPost]
    [Route("AddTeam")]
    public async Task<ActionResult<Team>> AddTeam(Team team){
        _context.Teams.Add(team);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetTeams", new { id = team.TeamId }, team);
    }
}