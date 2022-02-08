using BooksApp.Interfaces;
using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Repository
{
    class CountryRepository : ICountry
    {
        private readonly DbContent _dbContent;

        public CountryRepository(DbContent dbContent)
        {
            _dbContent = dbContent;
        }

        public IEnumerable<Country> GetAllCountries => _dbContent.Countries;
    }
}
