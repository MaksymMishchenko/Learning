using System;
using BooksApp.Repository;

namespace BooksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DbContent();
            DbObjects.Initial(db);

            AuthorsRepository author = new AuthorsRepository(db);
            BooksRepository book = new BooksRepository(db);

            var getAllAuthors = author.GetAllAuthors;

            Console.WriteLine("Contains the following list of authors: ");

            foreach (var authors in getAllAuthors)
            {
                Console.WriteLine($"{authors.Name}");
            }

            var getAllBooks = book.GetAllBooks;
            Console.WriteLine("Contains the following list of books: ");

            foreach (var books in getAllBooks)
            {
                Console.WriteLine($"{books.Name}");
            }
        }
    }
}
