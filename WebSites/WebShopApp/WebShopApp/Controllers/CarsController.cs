using Microsoft.AspNetCore.Mvc;
using WebShopApp.Data.Interfaces;

namespace WebShopApp.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _allCars;
        private readonly ICategory _allCategory;

        public CarsController(ICars allCars, ICategory allCategory)
        {
            _allCars = allCars;
            _allCategory = allCategory;
        }

        public ViewResult GetCars()
        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
