using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;
using System.Diagnostics;
using System.Text;

namespace RoutingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id)
        {
            return View();
        }

        public IActionResult GetResult(string id)
        {
            if (id != null)
            {
                return Content($"{id}", "text/plain", Encoding.UTF8);
            };

            return NotFound("Data not found");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}