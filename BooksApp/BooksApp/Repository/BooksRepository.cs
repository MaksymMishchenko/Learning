﻿using BooksApp.Interfaces;
using BooksApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BooksApp.Repository
{
    internal class BooksRepository : IBook
    {
        private readonly DbContent _dbContent;

        public BooksRepository(DbContent dbContent)
        {
            _dbContent = dbContent;
        }

        public IEnumerable<Book> GetAllBooks => _dbContent.Books.Include(b => b.Author);

        public IEnumerable<Book> GetBookByAuthors(int id)
        {
            return _dbContent.Books.Where(a => a.Author.Id == id);
        }

        public IEnumerable<Book> GetBookByAuthorsByCountries => _dbContent.Books
            .Include(b => b.Author)
            .ThenInclude(c => c.Country).ToList();
    }
}
