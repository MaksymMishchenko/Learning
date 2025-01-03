using BooksApp.Interfaces;
using BooksApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BooksApp.Repository
{
    internal class CapitalRepository : ICapitalRepository
    {
        private readonly DbContent _dbContent;

        public CapitalRepository(DbContent dbContent)
        {
            _dbContent = dbContent;
        }

        public IEnumerable<Capital> GetAllCapitals => _dbContent.Capitals.ToList();

        public IEnumerable<Capital> GetCapitalsById(int id)
        {
            return _dbContent.Capitals.Include(c => c.Id == id);
        }
    }
}
