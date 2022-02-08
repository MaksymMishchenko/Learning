using System.Collections.Generic;
using BooksApp.Models;

namespace BooksApp.Interfaces
{
    internal interface ICountry
    {
        IEnumerable<Country> GetAllCountries { get; }
    }
}