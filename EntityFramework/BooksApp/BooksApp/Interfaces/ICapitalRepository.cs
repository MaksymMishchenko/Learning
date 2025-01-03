using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Interfaces
{
    internal interface ICapitalRepository
    {
        IEnumerable<Capital> GetAllCapitals { get; }
        IEnumerable<Capital> GetCapitalsById(int id);
    }
}
