using BooksApp.Interfaces;
using BooksApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BooksApp.Repository
{
    class PublishHouseRepository : IPublishHouseRepository
    {
        private readonly DbContent _dbContent;
        public PublishHouseRepository(DbContent dbContent)
        {
            _dbContent = dbContent;
        }

        public IEnumerable<PublishHouse> GetAllPublishHouse => _dbContent.PublishHouse.ToList();

        public IEnumerable<PublishHouse> GetPublishHouseById(int id)
        {
            if (_dbContent.PublishHouse.Any())
            {
                return _dbContent.PublishHouse.Include(ph => ph.Id == id);
            }

            return Enumerable.Empty<PublishHouse>();
        }
    }
}
