using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BooksApp.Interfaces;
using BooksApp.Models;

namespace BooksApp.Repository
{
    internal class AuthorsRepository : IAuthor
    {
        private readonly DbContent _dbContent;

        public AuthorsRepository(DbContent dbContent)
        {
            _dbContent = dbContent;
        }

        public IEnumerable<Author> GetAllAuthors => _dbContent.Authors;
        public IEnumerable<Author> GetBooksByAuthor()
        {
            return Enumerable.Empty<Author>();
        }
    }
}
