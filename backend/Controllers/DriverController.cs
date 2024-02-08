
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("API/[controller]")]
[ApiController]
public class DriverController : ControllerBase{

    private readonly AppDbContext _context;

    public DriverController(AppDbContext context){
        _context = context;
    }

    [HttpGet]
    [Route("GetDrivers")]
    public async Task<ActionResult<IEnumerable<Driver>>> GetDrivers(){
        return await _context.Drivers.ToListAsync();
    }
    
    [HttpPost]
    [Route("AddDriver")]
    public async Task<ActionResult<Driver>> AddDriver(Driver driver){
        _context.Drivers.Add(driver);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetDrivers", new { id = driver.DriverId }, driver);
    }
}