using MouseTracker.Application.DTO;

namespace MouseTracker.Application.Services.Abstractions
{
    public interface IMouseTrackService
    {
        Task SaveMouseTrackAsync(List<MouseMovementDto> mouseMovements);
    }
}
