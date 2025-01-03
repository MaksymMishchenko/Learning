using System.Collections.Generic;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Interfaces
{
    public interface IArticle
    {
        IEnumerable<Article> Articles { get; }
    }
}
