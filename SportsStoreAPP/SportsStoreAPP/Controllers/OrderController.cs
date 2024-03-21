using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models;

namespace SportsStoreAPP.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _repository;
        private Cart _cart;
        public OrderController(IOrderRepository repo, Cart cartService)
        {
            _repository = repo;
            _cart = cartService;
        }

        [HttpGet]
        public ViewResult Checkout() => View(new Order());

        [HttpPost]
        public ActionResult Checkout(Order order)
        {
            if (_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty");
            }

            if (ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }

        public ViewResult Completed()
        {
            _cart.Clear();
            return View();
        }
    }
}
