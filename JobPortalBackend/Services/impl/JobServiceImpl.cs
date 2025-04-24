using JobPortalBackend.Repositories;

namespace JobPortalBackend.Services.impl;

public class JobServiceImpl: IJobService
{
    private readonly IJobRepository _jobRepository;
    public JobServiceImpl(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }
}