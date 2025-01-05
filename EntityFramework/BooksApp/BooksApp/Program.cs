﻿using BooksApp.Interfaces;
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

            ICountryRepository country = new CountryRepository(db);
            ICapitalRepository capital = new CapitalRepository(db);
            IPublishHouseRepository houseRepository = new PublishHouseRepository(db);
            IAuthorsRepository author = new AuthorsRepository(db);
            IBooksRepository book = new BooksRepository(db);
            IPrint print = new Print();

            var printBookByPublishHouse = book.GetBookByPublishHouse;
            Console.WriteLine("Contains the following book list of publish houses: ");
            Console.WriteLine(new string('-', 50));
            print.PrintBooksByPublishHouse(printBookByPublishHouse);
            Console.WriteLine(new string('-', 50));

            var printBookByAuthorCountryCapital = book.GetBookByAuthorsByCountriesCapitals;
            Console.WriteLine("Contains the following authors list by Countries and Capitals: ");
            Console.WriteLine(new string('-', 50));
            print.PrintBooksByAuthorCountryCapital(printBookByAuthorCountryCapital);
            Console.WriteLine(new string('-', 50));

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
