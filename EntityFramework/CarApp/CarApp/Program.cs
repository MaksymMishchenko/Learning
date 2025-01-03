using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbContent())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var truck = new CarClassification { Name = "Truck" };
                var car = new CarClassification { Name = "Passenger car" };
                var bus = new CarClassification { Name = "Bus" };
                db.CarClassifications.AddRange(truck, car, bus);

                // truck
                var freightliner = new Car { Name = "Freightliner", CarClassification = truck };
                var volvo = new Car { Name = "Volvo", CarClassification = truck };
                var kenworth = new Car { Name = "Kenworth", CarClassification = truck };

                // car
                var mercedes = new Car { Name = "Freightliner", CarClassification = car };
                var chevrolet = new Car { Name = "Chevrolet", CarClassification = car };
                var volvoCar = new Car { Name = "Volvo", CarClassification = car };

                // bus
                var peterPan = new Car { Name = "Peter Pan", CarClassification = bus };
                var luxBus = new Car { Name = "Lux Bus", CarClassification = bus };
                var megabus = new Car { Name = "Megabus", CarClassification = bus };
                db.Cars.AddRange(freightliner, volvo, kenworth, mercedes, chevrolet, volvoCar, peterPan, luxBus,
                    megabus);
                db.SaveChanges();
            }

            using (var db = new DbContent())
            {
                // get all cars and order by ascending
                var getAllCars = db.Cars
                    .Include(c => c.CarClassification)
                    .Where(c => c.CarClassificationId == 2)
                    .OrderBy(o => o.Name)
                    .ToList();

                foreach (var car in getAllCars)
                {
                    Console.WriteLine($"Car: {car.Name}, Classification: {car.CarClassification?.Name}");
                }

                Console.WriteLine(new string('-', 30));

                // get car by id
                var carId = db.Cars.Find(3);
                Console.WriteLine($"Car: {carId.Name}, ClassificationId: {carId.CarClassificationId}");

                Console.WriteLine(new string('-', 30));

                // get cars by subname
                var getCarsBySubName = db.Cars.Include(c => c.CarClassification).Where(c => EF.Functions.Like(c.Name, "%Vol%"));
                foreach (var car in getCarsBySubName)
                {
                    Console.WriteLine($"Car: {car.Name}, Classification: {car.CarClassification?.Name}");
                }

                Console.WriteLine(new string('-', 30));

                // get first car
                var firstCar = db.Cars.Include(c => c.CarClassification).FirstOrDefault(c => c.Name == "Peter Pan");
                Console.WriteLine($"Car: {carId.Name}, Classification: {carId.CarClassification?.Name}");

                Console.WriteLine(new string('-', 30));

                //get new type with SELECT
                var getCars = db.Cars
                    .Select(c => new
                    {
                        Name = c.Name,
                        Classification = c.CarClassification
                    })
                    .OrderBy(c => c.Name)
                    .ThenBy(c => c.Classification);

                foreach (var car in getCars)
                {
                    Console.WriteLine($"Name: {car.Name}, Classification: {car.Classification?.Name}");
                }
            }
        }
    }
}
