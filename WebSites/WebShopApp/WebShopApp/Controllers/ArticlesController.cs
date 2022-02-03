using Microsoft.AspNetCore.Mvc;
using WebShopApp.Data.Interfaces;
using WebShopApp.ViewModels;

namespace WebShopApp.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticle _articles;
        private readonly IArticleCategories _artCategories;

        public ArticlesController(IArticle articles, IArticleCategories artCategories)
        {
            _articles = articles;
            _artCategories = artCategories;
        }

        public ViewResult ShowArticles()
        {
            var obj = new ArticleListViewModel()
            {
                Articles = _articles.Articles,
                ArtCategories = _artCategories.Categories
            };
            return View(obj);
        }
    }
}
