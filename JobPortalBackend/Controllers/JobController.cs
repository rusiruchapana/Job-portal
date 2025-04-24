using JobPortalBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalBackend.Controllers;

public class JobController: ControllerBase
{
    private readonly IJobService _jobService;
    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }
}