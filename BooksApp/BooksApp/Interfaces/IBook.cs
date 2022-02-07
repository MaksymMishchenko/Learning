using System.Collections.Generic;
using BooksApp.Models;

namespace BooksApp.Interfaces
{
    internal interface IBook
    {
         IEnumerable<Book> GetAllBooks { get; }
         IEnumerable<Book> GetBookByAuthors(int id);
    }
}
