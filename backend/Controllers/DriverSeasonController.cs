using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class DriverSeasonController : ControllerBase
{
    private readonly AppDbContext _context;

    public DriverSeasonController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("GetDriverSeasons")]
    public async Task<ActionResult<IEnumerable<DriverSeason>>> GetDriverSeasons()
    {
        return await _context.DriverSeasons.ToListAsync();
    }

    [HttpPost]
    [Route("AddDriverSeason")]
    public async Task<ActionResult<DriverSeason>> AddDriverSeason(DriverSeason driverSeason)
    {
        _context.DriverSeasons.Add(driverSeason);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetDriverSeasons", new { id = driverSeason.DriverSeasonId }, driverSeason);
    }
}