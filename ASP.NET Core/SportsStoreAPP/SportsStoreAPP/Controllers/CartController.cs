using Microsoft.AspNetCore.Mvc;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models;
using SportsStoreAPP.Models.ViewModels;

namespace SportsStoreAPP.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository _repository;
        private Cart _cart;

        public CartController(IProductRepository repo, Cart cart)
        {
            _repository = repo;
            _cart = cart;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel { Cart = _cart, ReturnUrl = returnUrl });
        }

        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            var product = _repository.Products
                .FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                _cart.AddItem(product, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            var product = _repository.Products
                    .FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                _cart.RemoveLine(product);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
