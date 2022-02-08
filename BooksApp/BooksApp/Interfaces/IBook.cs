using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Interfaces
{
    internal interface IBook
    {
        IEnumerable<Book> GetAllBooks { get; }
        IEnumerable<Book> GetBookByAuthors(int id);
        IEnumerable<Book> GetBookByAuthorsByCountries { get; }
    }
}
