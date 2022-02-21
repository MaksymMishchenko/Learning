using System.Collections.Generic;
using ClientsApp.Models;

namespace ClientsApp.Interfaces
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAllCity { get; }
        public IEnumerable<City> GetCityById { get; }
    }
}
