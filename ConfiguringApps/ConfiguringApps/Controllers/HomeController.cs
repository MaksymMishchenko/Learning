using ConfiguringApps.Infrastructures;
using Microsoft.AspNetCore.Mvc;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService _uptime;

        public HomeController(UptimeService up) => _uptime = up;

        public IActionResult Index() => View(new Dictionary<string, string>
        {
            ["message"] = "This is the index page",
            ["Uptime"] = $"{_uptime.Uptime}ms"
        });
    }
}
