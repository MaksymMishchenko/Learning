using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Interfaces
{
    internal interface IPrint
    {
        void PrintBooks(IEnumerable<Book> coll);
        void PrintAuthors(IEnumerable<Author> coll);
        void PrintBooksByAuthor(IEnumerable<Book> coll);
        void PrintBooksByAuthorByCountries(IEnumerable<Book> coll);
        void PrintBooksByPublishHouse(IEnumerable<Book> coll);
        void PrintBooksByAuthorCountryCapital(IEnumerable<Book> coll);
    }
}
