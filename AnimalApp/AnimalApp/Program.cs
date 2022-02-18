using AnimalApp.Models;
using System;
using System.Linq;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AnimalDb())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var oskar = new Animal
                {
                    Name = "Oskar",
                    Age = 3,
                    FoodInformation = new FoodInformation
                    {
                        Feed = new Food { Key = "Feed", Value = "Pedigree" },
                        Kind = new Food { Key = "Dog", Value = "Dog" }
                    }
                };

                var oliver = new Animal
                {
                    Name = "Oliver",
                    Age = 2,
                    FoodInformation = new FoodInformation
                    {
                        Feed = new Food { Key = "Feed", Value = "Whiskas" },
                        Kind = new Food { Key = "Cat", Value = "Cat" }
                    }
                };

                db.Animals.AddRange(oskar, oliver);
                db.SaveChanges();

                var animalsList = db.Animals.ToList();

                foreach (var animal in animalsList)
                {
                    Console.WriteLine($"Name: \t{animal.Name}");
                    Console.WriteLine($"Age: \t{animal.Age}");
                    Console.WriteLine($"Kind: \t{animal.FoodInformation?.Kind?.Key}");
                    Console.WriteLine($"Feed: \t{animal.FoodInformation?.Feed?.Value}");
                    Console.WriteLine(new string('-', 30));
                }
            }
        }
    }
}
