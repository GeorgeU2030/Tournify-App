using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Data;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class WinraceController : ControllerBase {
    private readonly AppDbContext _context;

    public WinraceController(AppDbContext context){
        _context = context;
    }

    [HttpGet]
    [Route("GetWinraces")]
    public async Task<ActionResult<IEnumerable<Winrace>>> GetWinraces(){
        return await _context.Winraces.ToListAsync();
    }

    [HttpPost]
    [Route("AddWinrace")]
    public async Task<ActionResult<Winrace>> AddWinrace(Winrace winrace){
        _context.Winraces.Add(winrace);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetWinraces", new { id = winrace.WinraceId }, winrace);
    }
}