using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseTracker.Application.Services.Abstractions
{
    public interface IMouseTrackService
    {
        Task SaveMouseTrackAsync(string jsonData);
    }
}
