using ClientsApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClientsApp
{
    public class DbObjects
    {
        private  DbClients _db;
        private  Dictionary<string, City> _cities;

        public DbObjects(DbClients clients)
        {
            _db = clients;
        }
        public void Initial()
        {
            if (!_db.Cities.Any())
            {
                _db.Cities.AddRange(Cities.Select(c => c.Value));
            }

            if (!_db.Clients.Any())
            {
                _db.Clients.AddRange(
                    new Client { Name = "Sam", City = Cities["Washington"] },
                    new Client { Name = "Doris", City = Cities["Chicago"] },
                    new Client { Name = "Jacob", City = Cities["Washington"] },
                    new Client { Name = "William", City = Cities["Chicago"] },
                    new Client { Name = "Ethan", City = Cities["California"] },
                    new Client { Name = "Alexander", City = Cities["Chicago"] },
                    new Client { Name = "Mason", City = Cities["Chicago"] },
                    new Client { Name = "Liam", City = Cities["California"] },
                    new Client { Name = "Noah", City = null });
            }

            _db.SaveChanges();
        }

        private Dictionary<string, City> Cities
        {
            get
            {
                if (_cities == null)
                {
                    var listCities = new City[]
                    {
                        new City { Name = "Washington" },
                        new City { Name = "Chicago" },
                        new City { Name = "California" }
                    };
                    _cities = new Dictionary<string, City>();

                    foreach (var city in listCities)
                    {
                        _cities.Add(city.Name, city);
                    }
                }

                return _cities;
            }
        }
    }
}
