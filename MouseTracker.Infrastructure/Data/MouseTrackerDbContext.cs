using Microsoft.EntityFrameworkCore;
using MouseTracker.Domain.Entities;

namespace MouseTracker.Infrastructure.Data
{
    public class MouseTrackerDbContext: DbContext
    {
        public MouseTrackerDbContext(DbContextOptions<MouseTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<MouseTrack> MouseTracks { get; set; }
    }
}
