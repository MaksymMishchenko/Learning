using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Repository
{
    public class CarRepository : ICars
    {
        private readonly AppDbContent _appDbContent;

        public CarRepository(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Car> Cars => _appDbContent.Car.Include(c => c.Category);
        public IEnumerable<Car> GetFavouriteCars => _appDbContent.Car.Where(f => f.IsFavourite).Include(c => c.Category);
        public Car GetCar(int carId) => _appDbContent.Car.FirstOrDefault(c => c.Id == carId);
    }
}
