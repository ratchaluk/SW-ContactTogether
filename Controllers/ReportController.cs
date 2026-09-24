using ContactTogetherApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactTogetherApi.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class ReportController : ControllerBase
{
    private readonly ApplicationDbContext _db;
    private readonly ILogger<ReportController> _logger;

    public ReportController(ApplicationDbContext db, ILogger<ReportController> logger)
    {
        _db = db;
        _logger = logger;
    }
}
