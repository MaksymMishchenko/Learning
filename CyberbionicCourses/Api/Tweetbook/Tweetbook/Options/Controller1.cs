using Microsoft.AspNetCore.Mvc;

namespace Tweetbook.Options
{
    public class Controller1 : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}