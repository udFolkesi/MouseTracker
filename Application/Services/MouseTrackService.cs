using MouseTracker.Application.DTO;
using MouseTracker.Application.Services.Abstractions;
using MouseTracker.Domain.Entities;
using MouseTracker.Infrastructure.Repositories.Abstractions;
using System.Text.Json;

namespace MouseTracker.Application.Services
{
    public class MouseTrackService : IMouseTrackService
        
    {
        private readonly IBaseRepository<MouseTrack> _repository;

        public MouseTrackService(IBaseRepository<MouseTrack> repository)
        {
            _repository = repository;
        }

        public async Task SaveMouseTrackAsync(List<MouseMovementDto> mouseMovements)
        {
            var jsonData = JsonSerializer.Serialize(mouseMovements);
            var mouseTrack = new MouseTrack { Data = jsonData };
            await _repository.AddAsync(mouseTrack);
        }
    }
}
