using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;
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

        [Route("Cars/GetCars")]
        [Route("Cars/GetCars/{category}")]
        public ViewResult GetCars(string category)
        {
            string _category = category;
            IEnumerable<Car> Cars = null;
            string currentCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                Cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    Cars = _allCars.Cars.Where(i => i.Category.Name.Equals("Electric Cars")).OrderBy(i => i.Id);
                    currentCategory = "Electric Cars";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    Cars = _allCars.Cars.Where(i => i.Category.Name.Equals("Petrol Cars")).OrderBy(i => i.Id);
                    currentCategory = "Petrol Cars";
                }

                
            }

            var carObj = new CarsListViewModel
            {
                AllCars = Cars,
                CurrentCategory = currentCategory
            };

            ViewBag.Title = "Main page. Cars";
            return View(carObj);
        }
    }
}
