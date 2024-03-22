using Microsoft.AspNetCore.Mvc;
using SportsStoreAPP.Interfaces;

namespace SportsStoreAPP.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository _productRepository;
        public AdminController(IProductRepository repo)
        {
            _productRepository = repo;
        }
        public IActionResult Index() => View(_productRepository.Products);

        public ViewResult Edit(int productId) => View(_productRepository.Products
                .FirstOrDefault(p => p.ProductId == productId));

    }

}
