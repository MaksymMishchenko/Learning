using System;
using System.Linq;
using TractorApp.Models;

namespace TractorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbContent())
            {

                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var claas = new Company { Name = "Claas" };
                var fendt = new Company { Name = "Fendt" };
                var deutzFahr = new Company { Name = "Deutz Fahr" };
                db.Company.AddRange(claas, fendt, deutzFahr);

                var axion = new Tractor { Name = "AXION", Company = claas };
                var arion = new Tractor { Name = "ARION", Company = claas };

                var vario = new Tractor { Name = "VARIO 500", Company = fendt };
                var nexys = new Tractor { Name = "Nexys 700", Company = fendt };

                var nitro = new Tractor { Name = "Nitro", Company = deutzFahr };
                var same = new Tractor { Name = "Same", Company = deutzFahr };
                db.Tractor.AddRange(axion, arion, vario, nexys, nitro, same);

                db.SaveChanges();
            }

            using (var db = new DbContent())
            {
                var tractorsList = db.Tractor.ToList();

                foreach (var item in tractorsList)
                {
                    Console.WriteLine($"Tractor: {item.Name} | Company: {item.Company?.Name}");
                }
            }

            Console.WriteLine(new string('-', 50));

            using (var db = new DbContent())
            {
                var companies = db.Company.ToList();

                foreach (var company in companies)
                {
                    Console.WriteLine($"Company: {company.Name}");

                    foreach (var tractor in company.Tractors)
                    {
                        Console.WriteLine($"\tTractor: {tractor.Name}");
                    }
                }
            }
        }
    }
}
