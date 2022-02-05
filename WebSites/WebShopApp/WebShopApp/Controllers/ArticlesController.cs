using Microsoft.AspNetCore.Mvc;
using WebShopApp.Data.Interfaces;
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

        public ViewResult GetArticles()
        {
            ArticleListViewModel article = new ArticleListViewModel
            {
                Article = _article.Articles,
                Category = "All Articles"
            };
            return View(article);
        }
    }
}
