using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseTracker.Application.DTO
{
    public record MouseMovementDto(int X, int Y, long T);
}
