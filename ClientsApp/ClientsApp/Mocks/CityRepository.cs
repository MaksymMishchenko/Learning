using ClientsApp.Interfaces;
using ClientsApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClientsApp.Mocks
{
    class CityRepository : ICityRepository
    {
        private readonly DbClients _db;

        public CityRepository(DbClients clients)
        {
            _db = clients;
        }

        public IEnumerable<City> GetAllCity => _db.Cities.ToList();
        public IEnumerable<City> GetCityById => _db.Cities.Where(c => c.Id == 2);
    }
}
