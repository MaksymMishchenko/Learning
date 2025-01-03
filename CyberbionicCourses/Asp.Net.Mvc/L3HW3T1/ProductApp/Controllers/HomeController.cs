using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Diagnostics;

namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            var products = new ProductItems().GetAllProducts();
            return PartialView("_ProductList", products);
        }
        public IActionResult ProductTable()
        {
            var products = new ProductItems().GetAllProducts();
            return PartialView("_ProductTable", products);
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