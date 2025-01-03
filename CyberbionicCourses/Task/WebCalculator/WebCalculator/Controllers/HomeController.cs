using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using WebCalculator.Models;

namespace WebCalculator.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string SumAB(Calculate calculate)
        {
            return calculate.Sum().ToString();
        }

        [HttpPost]
        public int Function(string operations, int numberA, int numberB)
        {
            int res = 0;
            switch (operations)
            {
                case "+":
                    res = Sum(numberA, numberB);
                    break;
                case "-":
                    res = Substract(numberA, numberB);
                    break;
            }

            return res;
        }

        public int Sum(int numberA, int numberB)
        {
            return numberA + numberB;
        }
        public int Substract(int numberA, int numberB)
        {
            return numberA - numberB;
        }
    }

    public class Calculate
    {
        public int A { get; set; }
        public int B { get; set; }

        public int Sum()
        {
            return A + B;
        }
    }
}
