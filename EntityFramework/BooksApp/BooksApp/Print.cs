using BooksApp.Interfaces;
using BooksApp.Models;
using System;
using System.Collections.Generic;

namespace BooksApp
{
    internal class Print : IPrint
    {
        public void PrintBooks(IEnumerable<Book> coll)
        {
            foreach (var item in coll)
            {
                Console.WriteLine($"Book: {item.Name}");
            }
        }

        public void PrintAuthors(IEnumerable<Author> coll)
        {
            foreach (var author in coll)
            {
                Console.WriteLine($"Author: {author.Name}");
            }
        }

        public void PrintBooksByAuthor(IEnumerable<Book> coll)
        {
            foreach (var books in coll)
            {
                Console.WriteLine($"Book: {books.Name} | Author: {books.Author.Name}");
            }
        }

        public void PrintBooksByAuthorByCountries(IEnumerable<Book> coll)
        {
            foreach (var item in coll)
            {
                Console.WriteLine($"{item.Name} - {item.Author?.Name} - {item.Author?.Country?.Name}");
            }
        }

        public void PrintBooksByPublishHouse(IEnumerable<Book> coll)
        {
            foreach (var item in coll)
            {
                Console.WriteLine($"{item.Name} - {item.PublishHouse?.Name}");
            }
        }

        public void PrintBooksByAuthorCountryCapital(IEnumerable<Book> coll)
        {
            foreach (var item in coll)
            {
                Console.WriteLine($"{item.Name} - {item.Author?.Name} - {item.Author?.Country?.Name} - {item.Author?.Country?.Capital?.Name}");
            }
        }
    }
}