using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;
using WebShopApp.ViewModels;

namespace WebShopApp.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticle _article;
        private readonly IArticleCategories _artCategory;

        public ArticlesController(IArticle article, IArticleCategories artCategory)
        {
            _article = article;
            _artCategory = artCategory;
        }

        public ArticleListViewModel GetModel(IEnumerable<Article> articles)
        {
            ArticleListViewModel article = new ArticleListViewModel
            {
                Article = articles,
                Category = "All Articles"
            };

            return article;
        }

        [Route("Articles/GetArticles")]
        public ViewResult GetArticles()
        {
            IEnumerable<Article> Articles = null;

            Articles = _article.Articles.OrderBy(a => a.Id);

            return View(GetModel(Articles));
        }
    }
}
