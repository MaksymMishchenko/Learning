using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data.Mocks
{
    public class MockArticleCategories : IArticleCategories
    {
        public IEnumerable<ArticleCategory> AllCategories
        {
            get
            {
                return new List<ArticleCategory>
                {
                    new ArticleCategory
                    {
                        Name = "Sport Car",
                        Description = "This is sport car"
                    },

                    new ArticleCategory
                    {
                        Name = "Classic Car",
                        Description = "This is sport car"
                    }
                };
            }
        }
    }
}
