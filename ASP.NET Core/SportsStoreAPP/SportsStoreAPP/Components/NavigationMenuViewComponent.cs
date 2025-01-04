using Microsoft.AspNetCore.Mvc;
using SportsStoreAPP.Interfaces;

namespace SportsStoreAPP.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly IProductRepository _repository;
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            _repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            //ViewData["SelectedCategory"] = RouteData?.Values["category"];
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            var categories = _repository.Products.Select(p => p.Category).Distinct().OrderBy(c => c);
            return View("_Menu", categories);
        }
    }
}
