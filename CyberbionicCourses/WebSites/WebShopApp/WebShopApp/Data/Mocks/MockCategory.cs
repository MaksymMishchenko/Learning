using System.Collections.Generic;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>()
                {
                    new Category() {Name  = "Electric Cars", Description = "Best drivers choice "},
                    new Category(){Name = "Petrol Cars", Description = "Classic Petrol Cars"}
                };
            }
        }
    }
}
