using JobPortalBackend.Data;

namespace JobPortalBackend.Repositories.impl;

public class JobRepositoryImpl: IJobRepository
{
    private readonly AppDbContext _context;
    public JobRepositoryImpl(AppDbContext context)
    {
        _context = context;
    }
}