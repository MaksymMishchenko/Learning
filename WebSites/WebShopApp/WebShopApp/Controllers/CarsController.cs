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
        //private readonly ICategory _allCategory;
        public CarsController(ICars allCars)
        {
            _allCars = allCars;
        }
        public CarsListViewModel GetModel(IEnumerable<Car> car, string category = "null")
        {
            var model = new CarsListViewModel
            {
                AllCars = car,
                CurrentCategory = category
            };

            return model;
        }

        [Route("Cars/GetCars")]
        public ViewResult GetCars(string category)
        {
            //string currentCategory = "";
            IEnumerable<Car> Cars = null;

            if (string.IsNullOrEmpty(category))
            {
                Cars = _allCars.Cars.OrderBy(i => i.Id);
            }

            ViewBag.Title = "Main page. Cars";
            return View(GetModel(Cars));
        }

        [Route("Cars/GetTypeEngine/{category}")]
        public ActionResult GetTypeEngine(string category)
        {
            IEnumerable<Car> Cars = null;
            string currentCategory = "";

            if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
            {
                Cars = _allCars.Cars.Where(i => i.Category.Name.Equals("Electric Cars")).OrderBy(i => i.Id);
                currentCategory = "Electric Cars";
            }

            if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
            {
                Cars = _allCars.Cars.Where(i => i.Category.Name.Equals("Petrol Cars")).OrderBy(i => i.Id);
                currentCategory = "Petrol Cars";
            }

            return View(GetModel(Cars, currentCategory));
        }
    }
}
