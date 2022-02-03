using System.Collections.Generic;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Repository
{
    public class ArticleCategoryRepository : IArticleCategories
    {
        private readonly AppDbContent _appDbContent;

        public ArticleCategoryRepository(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<ArticleCategory> Categories { get; set; }
    }
}
