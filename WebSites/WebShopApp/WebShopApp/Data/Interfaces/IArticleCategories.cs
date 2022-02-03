using System.Collections.Generic;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Interfaces
{
    public interface IArticleCategories
    {
        IEnumerable<ArticleCategory> Categories { get; }
    }
}
