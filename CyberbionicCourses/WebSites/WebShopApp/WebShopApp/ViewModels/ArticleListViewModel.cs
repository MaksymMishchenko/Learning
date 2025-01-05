using System.Collections.Generic;
using WebShopApp.Data.Models;

namespace WebShopApp.ViewModels
{
    public class ArticleListViewModel
    {
        public IEnumerable<Article> Article { get; set; }
        public string Category { get; set; }
    }
}
