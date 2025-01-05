using Microsoft.AspNetCore.Mvc;
using SportsStoreAPP.Models;

namespace SportsStoreAPP.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart _cart;

        public CartSummaryViewComponent(Cart cartServise)
        {
            _cart = cartServise;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
