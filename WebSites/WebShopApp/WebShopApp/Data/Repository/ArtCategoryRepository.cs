using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Repository
{
    public class ArtCategoryRepository : IArticleCategories
    {
        private readonly AppDbContent _appDbContent;

        public ArtCategoryRepository(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<ArticleCategory> AllCategories => _appDbContent.ArticleCategory;
    }
}
