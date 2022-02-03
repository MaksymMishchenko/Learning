using System.Collections.Generic;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Repository
{
    public class ArticleRepository : IArticle
    {
        private readonly AppDbContent _appDbContent;

        public ArticleRepository(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Article> Articles { get; set; }
    }
}
