using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Repository
{
    public class ArticlesRepository : IArticle
    {
        private readonly AppDbContent _appDbContent;

        public ArticlesRepository(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Article> Articles => _appDbContent.Articles.Include(a => a.Category);
    }
}
