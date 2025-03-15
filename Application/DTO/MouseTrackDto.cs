using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseTracker.Application.DTO
{
    public class MouseTrackDto
    {
        public List<MouseMoveEventDto> Events { get; set; } = new();
    }

    public class MouseMoveEventDto
    {
        public int X { get; set; }
        public int Y { get; set; }
        public long T { get; set; } 
    }
}
