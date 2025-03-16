using MouseTracker.Domain.Entities;
using MouseTracker.Infrastructure.Data;
using MouseTracker.Infrastructure.Repositories.Abstractions;

namespace MouseTracker.Infrastructure.Repositories
{
    public class MouseTrackRepository : IBaseRepository<MouseTrack>
    {
        private readonly MouseTrackerDbContext _dbContext;
        public MouseTrackRepository(MouseTrackerDbContext context)
        {
            _dbContext = context;
        }
        public async Task AddAsync(MouseTrack entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
