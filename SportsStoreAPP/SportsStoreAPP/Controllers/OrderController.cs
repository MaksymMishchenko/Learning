using Microsoft.AspNetCore.Mvc;
using SportsStoreAPP.Models;

namespace SportsStoreAPP.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout()
        {
            return View(new Order());
        }
    }
}
