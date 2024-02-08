using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class SeasonraceController : ControllerBase {

    private readonly AppDbContext _context;

    public SeasonraceController(AppDbContext context){
        _context = context;
    }

    [HttpGet]
    [Route("GetSeasonraces")]
    public async Task<ActionResult<IEnumerable<Seasonrace>>> GetSeasonraces(){
        return await _context.Seasonraces.ToListAsync();
    }

    [HttpPost]
    [Route("AddSeasonrace")]
    public async Task<ActionResult<Seasonrace>> AddSeasonrace(Seasonrace seasonrace){
        _context.Seasonraces.Add(seasonrace);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetSeasonraces", new { id = seasonrace.SeasonraceId }, seasonrace);
    }

}