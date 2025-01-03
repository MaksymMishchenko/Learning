using System.Collections.Generic;
using System.Linq;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private AppDbContent _appDbContent;

        public CategoryRepository(AppDbContent appDbContext)
        {
            _appDbContent = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContent.Category;
    }
}
