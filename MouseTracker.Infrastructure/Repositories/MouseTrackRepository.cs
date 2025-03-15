using Microsoft.EntityFrameworkCore;
using MouseTracker.Domain.Entities;
using MouseTracker.Infrastructure.Data;
using MouseTracker.Infrastructure.Repositories.Abstractions;

namespace MouseTracker.Infrastructure.Repositories
{
    public class MouseTrackRepository : IBaseRepository<MouseTrack>
    {
        private readonly MouseTrackerDbContext dbContext;
        public MouseTrackRepository(MouseTrackerDbContext context)
        {
            dbContext = context;
        }
        public async Task AddAsync(MouseTrack entity)
        {
            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
