using BooksApp.Interfaces;
using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Repository
{
    internal class AuthorsRepository : IAuthorsRepository
    {
        private readonly DbContent _dbContent;

        public AuthorsRepository(DbContent dbContent)
        {
            _dbContent = dbContent;
        }

        public IEnumerable<Author> GetAllAuthors => _dbContent.Authors;
    }
}
