using System.Collections.Generic;
using BooksApp.Models;

namespace BooksApp.Interfaces
{
    internal interface IPrint
    {
        void PrintBooks(IEnumerable<Book> coll);
        void PrintAuthors(IEnumerable<Author> coll);
        void PrintBooksByAuthor(IEnumerable<Book> coll);
    }  
}
