using Microsoft.EntityFrameworkCore;
using MobilePhoneApp.Models;
using System;
using System.Linq;

namespace MobilePhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbContent())
            {
                var china = new Country { Name = "China" };
                var usa = new Country { Name = "USA" };
                db.Countries.AddRange(china, usa);

                var beijing = new Headquarters { Name = "Beijing", Country = china };
                var california = new Headquarters { Name = "California", Country = usa };
                db.Headquarters.AddRange(beijing, california);

                var xiaomi = new Manufacturer { Name = "Xiaomi", Headquarters = beijing };
                var apple = new Manufacturer { Name = "Apple", Headquarters = california };
                db.Manufacturers.AddRange(xiaomi, apple);


                var redMi8A = new MobilePhone { Name = "redMi8A", Cost = 150, Manufacturer = xiaomi };
                var redMiNote10 = new MobilePhone { Name = "redMiNote10", Cost = 200, Manufacturer = xiaomi };
                var redMi9A = new MobilePhone { Name = "redMi9A", Cost = 200, Manufacturer = xiaomi };

                var iPhone11 = new MobilePhone { Name = "iPhone 11", Cost = 1000, Manufacturer = apple };
                var iPhone12 = new MobilePhone { Name = "iPhone 12", Cost = 1100, Manufacturer = apple };
                var iPhone13 = new MobilePhone { Name = "iPhone 13", Cost = 1200, Manufacturer = apple };
                db.MobilePhones.AddRange(redMi8A, redMiNote10, redMi9A, iPhone11, iPhone12, iPhone13);

                db.SaveChanges();

                var mobileList = db.MobilePhones
                    .Include(p => p.Manufacturer)
                    .ThenInclude(h => h.Headquarters)
                    .ThenInclude(c => c.Country).ToList();

                foreach (var item in mobileList)
                {
                    Console.WriteLine($"Phone: {item.Name} | Price: {item.Cost}, Manufacturer: {item.Manufacturer?.Name} | Headquarters: {item.Manufacturer?.Headquarters?.Name} | Country: {item.Manufacturer?.Headquarters?.Country?.Name}");
                }

                Console.WriteLine(new string('-', 100));

                var manufacturer = db.Manufacturers.FirstOrDefault();
                db.MobilePhones.Where(p => p.ManufacturerId == manufacturer.Id).Load();

                Console.WriteLine($"Manufacturer: {manufacturer.Name}");

                foreach (var item in manufacturer.MobilePhones)
                {
                    Console.WriteLine($"Mobile phone: {item.Name} | Price: {item.Cost}");
                }

                Console.WriteLine(new string('-', 100));

                var phone = db.MobilePhones.FirstOrDefault();
                db.Entry(phone).Reference(x => x.Manufacturer).Load();

                Console.WriteLine($"Mobile phone: {phone.Name} | Manufacturer: {phone.Manufacturer?.Name}");

                Console.WriteLine(new string('-', 100));

                var manufac = db.Manufacturers.OrderBy(o => o.Id).LastOrDefault();
                db.Entry(manufac).Collection(p => p.MobilePhones).Load();

                Console.WriteLine($"Manufacturer: {manufac.Name}");

                foreach (var item in manufac.MobilePhones)
                {
                    Console.WriteLine($"Mobile phone: {item.Name}");
                }
            }
        }
    }
}
