using JobPortalBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobController: ControllerBase
{
    private readonly IJobService _jobService;
    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }
}