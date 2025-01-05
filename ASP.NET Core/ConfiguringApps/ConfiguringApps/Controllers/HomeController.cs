using ConfiguringApps.Infrastructures;
using Microsoft.AspNetCore.Mvc;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService _uptime;
        private ILogger<HomeController> _logger;

        public HomeController(UptimeService up, ILogger<HomeController> logger)
        {
            _uptime = up;
            _logger = logger;
        }

        public IActionResult Index(bool throwException = false)
        {
            _logger.LogDebug($"Handled {Request.Path} at uptime {_uptime.Uptime}");

            if (throwException)
            {
                throw new NullReferenceException();
            }

            return View(new Dictionary<string, string>
            {
                ["message"] = "This is the index page",
                ["Uptime"] = $"{_uptime.Uptime}ms"
            });
        }

        public ViewResult Error() => View(nameof(Index),
            new Dictionary<string, string> { ["message"] = "This is the error action" });
    }
}
