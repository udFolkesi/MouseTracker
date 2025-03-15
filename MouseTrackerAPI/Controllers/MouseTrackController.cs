using Microsoft.AspNetCore.Mvc;
using MouseTracker.Application.Services;
using MouseTracker.Application.Services.Abstractions;

namespace MouseTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MouseTrackController(IMouseTrackService mouseTrackService) : ControllerBase
    {
        [HttpPost("save")]
        public async Task<IActionResult> SaveMouseTrack([FromBody] string jsonData)
        {
            if (string.IsNullOrEmpty(jsonData))
                return BadRequest("Invalid data");

            await mouseTrackService.SaveMouseTrackAsync(jsonData);
            return Ok("Data saved");
        }
    }
}
