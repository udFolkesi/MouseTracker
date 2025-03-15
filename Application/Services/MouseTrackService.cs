using MouseTracker.Application.Services.Abstractions;
using MouseTracker.Domain.Entities;
using MouseTracker.Infrastructure.Repositories;
using MouseTracker.Infrastructure.Repositories.Abstractions;

namespace MouseTracker.Application.Services
{
    public class MouseTrackService : IMouseTrackService
        
    {
        private readonly IBaseRepository<MouseTrack> repository;

        public MouseTrackService(IBaseRepository<MouseTrack> repository)
        {
            this.repository = repository;
        }

        public async Task SaveMouseTrackAsync(string jsonData)
        {
            var mouseTrack = new MouseTrack { Data = jsonData };
            await repository.AddAsync(mouseTrack);
        }
    }
}
