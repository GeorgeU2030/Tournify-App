using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class RaceController : ControllerBase
{
    private readonly AppDbContext _context;
    public RaceController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("GetRaces")]
    public async Task<ActionResult<IEnumerable<Race>>> GetPlayers()
    {
        return await _context.Races.ToListAsync();
    }

    [HttpPost]
    [Route("AddRace")]
    public async Task<ActionResult<Race>> AddRace(Race race){
        _context.Races.Add(race);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetRaces", new { id = race.RaceId }, race);
    }
   
}