using MouseTracker.Domain.Entities.Abstractions;

namespace MouseTracker.Domain.Entities
{
    public class MouseTrack: BaseEntity
    {
        public string Data { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
