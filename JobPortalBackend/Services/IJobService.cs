using JobPortalBackend.Dtos.request;
using JobPortalBackend.Dtos.response;

namespace JobPortalBackend.Services;

public interface IJobService
{
    Task<JobDtoResponse> CreateJob(JobDtoRequest jobDto);
}