using Microsoft.AspNetCore.Mvc;
using ProductListApp.Models;

namespace ProductListApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product(1, "Pen", 1M, "This is a Pen"));
            products.Add(new Product(2, "Pencil", 1.2M, "This is a Pencil"));
            products.Add(new Product(3, "Glue", 0.9M, "This is a Glue"));
            products.Add(new Product(4, "Elastic", 1.1M, "This is a Elastic"));
            products.Add(new Product(5, "Calculator", 1.3M, "This is a Calculator"));

            return View(products);
        }
    }
}
