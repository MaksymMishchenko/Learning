using Microsoft.AspNetCore.Mvc;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models.ViewModels;

namespace SportsStoreAPP.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        public IActionResult List(string category, int productPage = 1) => View(new ProductListViewModel
        {
            Products = _productRepository.Products
            .Where(p => category == null || p.Category == category)
            .OrderBy(p => p.ProductId)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                _productRepository.Products.Count() :
                _productRepository.Products.Where(e =>
                e.Category == category).Count()
            },
            CurrentCategory = category
        });
    }
}
