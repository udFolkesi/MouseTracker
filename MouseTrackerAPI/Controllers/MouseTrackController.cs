using Microsoft.AspNetCore.Mvc;
using MouseTracker.Application.DTO;
using MouseTracker.Application.Services.Abstractions;
using System.Text.Json;

namespace MouseTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MouseTrackController(IMouseTrackService mouseTrackService) : ControllerBase
    {
        [HttpPost("save")]
        public async Task<IActionResult> SaveMouseTrack([FromBody] List<MouseMovementDto> mouseMovements)
        {
            try
            {
                if (mouseMovements == null || mouseMovements.Count == 0)
                    return BadRequest("Mouse movement data is required.");

                await mouseTrackService.SaveMouseTrackAsync(mouseMovements);
                return Ok(new { message = "Data saved successfully" });
            }
            catch (JsonException ex)
            {
                return BadRequest(new { error = "Invalid JSON format", details = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An unexpected error occurred", details = ex.Message });
            }
        }
    }
}
