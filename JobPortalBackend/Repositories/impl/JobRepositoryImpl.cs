using JobPortalBackend.Data;
using JobPortalBackend.Models;

namespace JobPortalBackend.Repositories.impl;

public class JobRepositoryImpl: IJobRepository
{
    private readonly AppDbContext _context;
    public JobRepositoryImpl(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Job> CreateJob(Job job)
    {
        await _context.Jobs.AddAsync(job);
        await _context.SaveChangesAsync();
        return job;
    }
}