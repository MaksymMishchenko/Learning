using System;
using System.Collections.Generic;
using BooksApp.Interfaces;
using BooksApp.Models;

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
                Console.WriteLine($"Book: {books.Name} | Author{books.Author.Name}");
            }
        }
    }
}