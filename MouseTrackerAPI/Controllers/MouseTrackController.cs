using Microsoft.AspNetCore.Mvc;

namespace MouseTrackerAPI.Controllers
{
    [ApiController]
    public class MouseTrackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
