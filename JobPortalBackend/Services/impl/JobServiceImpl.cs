using AutoMapper;
using JobPortalBackend.Dtos.request;
using JobPortalBackend.Dtos.response;
using JobPortalBackend.Models;
using JobPortalBackend.Repositories;

namespace JobPortalBackend.Services.impl;

public class JobServiceImpl: IJobService
{
    private readonly IJobRepository _jobRepository;
    private readonly IMapper _mapper;
    public JobServiceImpl(IJobRepository jobRepository , IMapper mapper)
    {
        _jobRepository = jobRepository;
        _mapper = mapper;
    }

    public async Task<JobDtoResponse> CreateJob(JobDtoRequest jobDto)
    {
        Job job = _mapper.Map<Job>(jobDto);
        Job createdJob = await _jobRepository.CreateJob(job);
        JobDtoResponse jobDtoResponse = _mapper.Map<JobDtoResponse>(createdJob);
        return jobDtoResponse;
    }
}