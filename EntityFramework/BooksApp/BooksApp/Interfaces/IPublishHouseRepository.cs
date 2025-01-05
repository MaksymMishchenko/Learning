using BooksApp.Models;
using System.Collections.Generic;

namespace BooksApp.Interfaces
{
    internal interface IPublishHouseRepository
    {
        IEnumerable<PublishHouse> GetAllPublishHouse { get; }
        IEnumerable<PublishHouse> GetPublishHouseById(int id);
    }
}
