using BooksApp.Interfaces;
using BooksApp.Repository;
using System;

namespace BooksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DbContent();
            DbObjects.Initial(db);

            ICountry country = new CountryRepository(db);
            IAuthor author = new AuthorsRepository(db);
            IBook book = new BooksRepository(db);
            IPrint print = new Print();

            var getAllAuthors = author.GetAllAuthors;
            Console.WriteLine("Contains the following list of authors: ");
            Console.WriteLine(new string('-', 50));

            print.PrintAuthors(getAllAuthors);
            Console.WriteLine(new string('-', 50));

            var getAllBooks = book.GetAllBooks;
            Console.WriteLine("Contains the following list of books: ");
            Console.WriteLine(new string('-', 50));

            print.PrintBooks(getAllBooks);
            Console.WriteLine(new string('-', 50));

            var getBooksByAuthor = book.GetBookByAuthors(1);
            Console.WriteLine("Contains the following books by Authors: ");
            Console.WriteLine(new string('-', 50));

            print.PrintBooksByAuthor(getBooksByAuthor);

            var getBooksByAuthorbyCoutries = book.GetBookByAuthorsByCountries;
            Console.WriteLine("Contains the following books by Authors by Coutries: ");
            Console.WriteLine(new string('-', 50));

            print.PrintBooksByAuthorByCountries(getBooksByAuthorbyCoutries);
        }
    }
}
