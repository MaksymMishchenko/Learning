using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Interfaces
{
    internal interface IBooksRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
        IEnumerable<Book> GetBookByAuthors(int id);
        IEnumerable<Book> GetBookByAuthorsByCountries { get; }
        IEnumerable<Book> GetBookByPublishHouse { get; }
        IEnumerable<Book> GetBookByAuthorsByCountriesCapitals { get; }
    }
}
