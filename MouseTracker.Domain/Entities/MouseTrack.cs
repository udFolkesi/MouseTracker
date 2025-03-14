using MouseTracker.Domain.Entities.Abstractions;

namespace MouseTracker.Domain.Entities
{
    public class MouseTrack: BaseEntity
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
