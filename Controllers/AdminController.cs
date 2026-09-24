using ContactTogetherApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactTogetherApi.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class AdminController : ControllerBase
{
    private readonly ApplicationDbContext _db;
    private readonly ILogger<AdminController> _logger;

    public AdminController(ApplicationDbContext db, ILogger<AdminController> logger)
    {
        _db = db;
        _logger = logger;
    }
}
