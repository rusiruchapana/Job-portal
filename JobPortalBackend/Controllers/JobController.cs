using JobPortalBackend.Dtos.request;
using JobPortalBackend.Dtos.response;
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


    [HttpPost]
    public async Task<ActionResult<JobDtoResponse>> CreateJob(JobDtoRequest jobDto)
    {
        JobDtoResponse jobDtoResponse = await _jobService.CreateJob(jobDto);
        return Ok(jobDtoResponse);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobDtoResponse>>> GetJobs()
    {
        IEnumerable<JobDtoResponse> jobDtoResponses = await _jobService.GetJobs();
        return Ok(jobDtoResponses);
    }




}