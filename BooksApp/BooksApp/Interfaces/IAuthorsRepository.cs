using System.Collections.Generic;
using BooksApp.Models;

namespace BooksApp.Interfaces
{
    internal interface IAuthorsRepository
    {
        IEnumerable<Author> GetAllAuthors { get; }
    }
}
