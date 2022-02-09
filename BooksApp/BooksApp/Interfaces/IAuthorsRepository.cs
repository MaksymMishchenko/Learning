using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Interfaces
{
    internal interface IAuthorsRepository
    {
        IEnumerable<Author> GetAllAuthors { get; }
    }
}
