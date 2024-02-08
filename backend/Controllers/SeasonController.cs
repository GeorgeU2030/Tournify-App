using backend.Models;
using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]

public class SeasonController : ControllerBase{

    private readonly AppDbContext _context;

    public SeasonController(AppDbContext context){
        _context = context;
    }

    [HttpGet]
    [Route("GetSeasons")]
    public async Task<ActionResult<IEnumerable<Season>>> GetSeasons(){
        return await _context.Seasons.ToListAsync();
    }

    [HttpPost]
    [Route("AddSeason")]
    public async Task<ActionResult<Season>> AddSeason(Season season){
        _context.Seasons.Add(season);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetSeasons", new { id = season.SeasonId }, season);
    }
    
}