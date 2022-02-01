using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using WebShopApp.Data.Models;

namespace WebShopApp.Data
{
    public class DbObjects
    {
        private static Dictionary<string, Category> _category;

        public static void Initial(AppDbContent content)
        {
            
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.Car.AddRange(

        new Car()
                 {
                     Name = "Changan",
                     ShortDescription = "Chinese car",
                     LongDescription = "Chinese car has a range of 300 kilometers",
                     Image = "/image/changan.jpg",
                     Price = 12000,
                     IsFavourite = true,
                     Available = true,
                     Category = Categories["Electric Cars"]
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
                     Category = Categories["Electric Cars"]
                 },
                 new Car()
                 {
                     Name = "Toyota",
                     ShortDescription = "Petrol Car",
                     LongDescription = "Powerful petrol car with engine capacity 3.0",
                     Image = "/image/toyota.jpg",
                     Price = 22000,
                     IsFavourite = true,
                     Available = false,
                     Category = Categories["Petrol Cars"]
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
                     Category = Categories["Electric Cars"]
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
                     Category = Categories["Petrol Cars"]
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
                     Category = Categories["Petrol Cars"]
                 });
            }

            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new Category[]
                    {
                        new Category() { Name = "Electric Cars", Description = "Best drivers choice " },
                        new Category() { Name = "Petrol Cars", Description = "Classic Petrol Cars" }
                    };

                    _category = new Dictionary<string, Category>();
                    foreach (Category category in list)
                    {
                        _category.Add(category.Name, category);
                    }
                }

                return _category;
            }
        }
    }

}
