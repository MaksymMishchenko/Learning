using Microsoft.AspNetCore.Mvc;

namespace MedPillCorporationApp.Controllers
{
    public class PillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
