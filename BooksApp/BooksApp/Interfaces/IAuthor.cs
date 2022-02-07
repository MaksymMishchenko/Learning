using System.Collections.Generic;
using BooksApp.Models;

namespace BooksApp.Interfaces
{
    internal interface IAuthor
    {
        IEnumerable<Author> GetAllAuthors { get; }
        IEnumerable<Author> GetBooksByAuthor();
    }
}
