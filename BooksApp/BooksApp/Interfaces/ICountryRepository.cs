using System.Collections.Generic;
using BooksApp.Models;

namespace BooksApp.Interfaces
{
    internal interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries { get; }
    }
}