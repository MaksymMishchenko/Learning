using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models;

namespace SportsStoreAPP.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository _productRepository;
        public AdminController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        public IActionResult Index() => View(_productRepository.Products);

        [HttpGet]
        public ViewResult Edit(int productId) => View(_productRepository?.Products
                .FirstOrDefault(p => p.ProductId == productId));

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(product);
            }
        }

        public IActionResult Create() => View("Edit", new Product());

        [HttpPost]
        public IActionResult DeleteProduct(Product product)
        {
            var deletedProduct = _productRepository.DeleteProduct(product.ProductId);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }

            return RedirectToAction("Index");
        }
    }
}
