using Microsoft.AspNetCore.Mvc;
using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class TrophyController : ControllerBase {
    private readonly AppDbContext _context;

    public TrophyController(AppDbContext context){
        _context = context;
    }

    [HttpGet]
    [Route("GetTrophies")]
    public async Task<ActionResult<IEnumerable<Trophy>>> GetTrophies(){
        return await _context.Trophies.ToListAsync();
    }

    [HttpPost]
    [Route("AddTrophy")]
    public async Task<ActionResult<Trophy>> AddTrophy(Trophy trophy){
        _context.Trophies.Add(trophy);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetTrophies", new { id = trophy.TrophyId }, trophy);
    }
}