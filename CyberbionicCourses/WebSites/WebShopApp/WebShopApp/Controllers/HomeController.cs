using Microsoft.AspNetCore.Mvc;
using WebShopApp.Data.Interfaces;
using WebShopApp.ViewModels;

namespace WebShopApp.Controllers
{
    public class HomeController : Controller
    {
        private ICars _carRep;

        public HomeController(ICars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavCars = _carRep.GetFavouriteCars
            };

            return View(homeCars);
        }
    }
}
