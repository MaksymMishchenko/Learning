using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Mocks
{
    public class MockCars : ICars
    {
        private readonly ICategory _category = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>()
                {
                    new Car()
                    {
                        Name = "Changan",
                        ShortDescription = "Chinese car",
                        LongDescription = "Chinese car has a range of 300 kilometers",
                        Image = "/image/changan.jpg",
                        Price = 12000,
                        IsFavourite = true,
                        Available = true,
                        Category =_category.AllCategories.First()
                    },

                    new Car()
                    {
                        Name = "Nissan",
                        ShortDescription = "Liaf",
                        LongDescription = "Electric Car has a range of 100 kilometers",
                        Image = "/image/nissan.jpg",
                        Price = 10000,
                        IsFavourite = true,
                        Available = true,
                        Category =_category.AllCategories.First()
                    }, 
                    new Car()
                    {
                        Name = "Toyota",
                        ShortDescription = "Petrol Car",
                        LongDescription = "Powerful petrol car with engine capacity 3.0",
                        Image = "/image/toyota.jpg",
                        Price = 22000,
                        IsFavourite = false,
                        Available = false,
                        Category =_category.AllCategories.Last()
                    },

                    new Car()
                    {
                        Name = "Mercedes",
                        ShortDescription = "EQC class",
                        LongDescription = "Electric Car has a range of 471 kilometers",
                        Image = "/image/mercedes.jpg",
                        Price = 20000,
                        IsFavourite = true,
                        Available = true,
                        Category =_category.AllCategories.First()
                    },

                    new Car()
                    {
                        Name = "KIA",
                        ShortDescription = "Ceed",
                        LongDescription = "Powerful petrol car with engine capacity 1.5",
                        Image = "/image/kia_ceed.jpg",
                        Price = 25000,
                        IsFavourite = true,
                        Available = true,
                        Category =_category.AllCategories.Last()
                    },

                    new Car()
                    {
                        Name = "Volkswagen",
                        ShortDescription = "Taigun",
                        LongDescription = "Powerful petrol car with engine capacity 2.5",
                        Image = "/image/volkswagen.jpg",
                        Price = 40000,
                        IsFavourite = true,
                        Available = true,
                        Category =_category.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavouriteCars { get; set; }
        public Car GetCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
