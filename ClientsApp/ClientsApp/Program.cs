using System;
using System.Collections.Generic;
using System.Linq;
using ClientsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DbClients())
            {
                var initial = new DbObjects(db);
                initial.Initial();

                //getGroupByCity
                var getGroupByCity = from clients in db.Clients.AsEnumerable()
                              join city in db.Cities.AsEnumerable() on clients.CityId equals city.Id
                              group clients by new
                              {
                                  clients.CityId,
                                  city.Name
                              };

                foreach (var item in getGroupByCity)
                {
                    Console.WriteLine($"City: {item.Key.Name}, Count of clients: {item.Count()}");
                }

                Console.WriteLine(new string('-', 30));

                // getClientByCity
                var getClientByCity = (from client in db.Clients.Include(p => p.City)
                    where client.CityId == 1 select client).ToList();

                foreach (var client in getClientByCity)
                {
                    Console.WriteLine($"{client.City?.Name}, {client.Name}");
                }

                Console.WriteLine(new string('-', 30));

                // getAllClients
                var getAllClients = from client in db.Clients
                    join city in db.Cities on client.CityId equals city.Id into clientCityGroup
                    from subCities in clientCityGroup.DefaultIfEmpty()
                    select new { clientName = client.Name, clientCity = subCities.Name };

                foreach (var item in getAllClients)
                {
                    Console.WriteLine($"Client: {item.clientName}, City: {item.clientCity}");
                }

                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
