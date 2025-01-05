using Microsoft.AspNetCore.Mvc;
using TemplateApp.Models;

namespace TemplateApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Products(int count = 5)
        {
            var productManager = new ProductManager().GetAllProducts().Take(count);
            return View(productManager);
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}