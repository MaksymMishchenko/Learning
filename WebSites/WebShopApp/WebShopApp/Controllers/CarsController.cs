using Microsoft.AspNetCore.Mvc;
using WebShopApp.Data.Interfaces;
using WebShopApp.ViewModels;

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
            ViewBag.Title = "Main page. Cars";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.CurrentCategory = "Electrocar";
            return View(obj);
        }
    }
}
