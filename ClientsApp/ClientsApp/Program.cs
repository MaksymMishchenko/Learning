using System;
using System.Linq;
using ClientsApp.Interfaces;
using ClientsApp.Mocks;
using ClientsApp.Models;
using Newtonsoft.Json.Linq;

namespace ClientsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbClients())
            {
                var chicago = new City { Name = "Chicago" };
                var washington = new City { Name = "Washington" };
                var california = new City { Name = "California" };
                db.Cities.AddRange(chicago, washington, california);

                var maks = new Client { Name = "Maks", CityId = chicago };
                var sam = new Client { Name = "Sam", CityId = washington };
                var doris = new Client { Name = "Doris", CityId = chicago };
                var maralin = new Client { Name = "Maralin", CityId = chicago };
                var jacob = new Client { Name = "Jacob", CityId = california };
                var william = new Client { Name = "William ", CityId = california };
                var ethan = new Client { Name = "Ethan ", CityId = washington };
                var michael = new Client { Name = "Michael ", CityId = chicago };
                var alexander = new Client { Name = "Alexander ", CityId = chicago };
                var mason = new Client { Name = "Mason ", CityId = null };
                var liam = new Client { Name = "Liam ", CityId = chicago };
                var noah = new Client { Name = "Noah ", CityId = california };
                db.Clients.AddRange(maks, sam,doris,maralin,jacob, william, ethan,michael,alexander, mason, liam, noah);
                db.SaveChanges();

                ICityRepository getCities = new CityRepository(db);
                var cities = getCities.GetAllCity;

                foreach (var city in cities)
                {
                    Console.WriteLine($"Cities: {city.Name}");
                }

                Console.WriteLine(new string('-', 30));

                var cityById = getCities.GetCityById;

                foreach (var city in cityById)
                {
                    Console.WriteLine($"City by id: {city.Name}");
                }

                Console.WriteLine(new string('-', 30));

                IClientRepository getClients = new ClientRepository(db);
                var clientsByCity = getClients.GetClientsByCity;

                foreach (var client in clientsByCity)
                {
                    Console.WriteLine($"City: {client.CityId?.Name}, Client: {client.Name}");
                }
            }
        }
    }
}
