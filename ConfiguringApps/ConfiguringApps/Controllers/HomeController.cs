using ConfiguringApps.Infrastructures;
using Microsoft.AspNetCore.Mvc;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService _uptime;

        public HomeController(UptimeService up) => _uptime = up;

        public IActionResult Index(bool throwException = false)
        {
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
