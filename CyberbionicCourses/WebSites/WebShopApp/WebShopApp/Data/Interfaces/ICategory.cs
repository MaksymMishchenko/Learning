using System.Collections.Generic;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
