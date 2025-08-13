using DockerCompose.Data;
using DockerCompose.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DockerCompose.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController(ApplicationDbContext context) : ControllerBase
{

    private readonly ApplicationDbContext _context = context;

    [HttpGet]

    public async Task<IActionResult> GetEmployees()
    {
        return Ok(await _context.Employees.ToListAsync());
    }

    [HttpPost]

    public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
    {
        await _context.Employees.AddAsync(employee);
        await _context.SaveChangesAsync();
        return Ok(employee);
    }
}
