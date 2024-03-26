using Microsoft.AspNetCore.Mvc;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(new Dictionary<string, string>
        {
            ["message"] = "This is the index page"
        });
    }
}
