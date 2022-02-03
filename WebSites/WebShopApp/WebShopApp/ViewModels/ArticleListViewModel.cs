using System.Collections.Generic;
using WebShopApp.Data.Models;

namespace WebShopApp.ViewModels
{
    public class ArticleListViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<ArticleCategory> ArtCategories { get; set; }
    }
}
