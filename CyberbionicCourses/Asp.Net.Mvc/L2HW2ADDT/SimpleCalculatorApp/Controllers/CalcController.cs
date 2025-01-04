using Microsoft.AspNetCore.Mvc;

namespace SimpleCalculatorApp.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Add(double? x, double? y)
        {
            if (x.HasValue && y.HasValue)
            {
                ViewBag.Result = x + y;
            }
            return View("Index");
        }

        public IActionResult Sub(double? x, double? y)
        {
            if (x.HasValue && y.HasValue)
            {
                ViewBag.Result = x - y;
            }
            return View("Index");
        }

        public IActionResult Mul(double? x, double? y)
        {
            if (x.HasValue && y.HasValue)
            {
                ViewBag.Result = x * y;
            }
            return View("Index");
        }

        public IActionResult Div(double? x, double? y)
        {
            if (x.HasValue && y != 0)
            {
                ViewBag.Result = x / y;
            }
            else
            {
                ViewBag.Result = "Error. Division by zero";
            }
            return View("Index");
        }
    }
}
