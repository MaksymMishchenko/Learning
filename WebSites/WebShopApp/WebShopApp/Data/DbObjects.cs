using System.Collections.Generic;
using System.Linq;
using WebShopApp.Data.Interfaces;
using WebShopApp.Data.Models;

namespace WebShopApp.Data
{
    public class DbObjects
    {
        private static Dictionary<string, Category> _category;
        private static Dictionary<string, ArticleCategory> _artCategory;

        public static void Initial(AppDbContent content)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.ArticleCategory.Any())
            {
                content.ArticleCategory.AddRange(ArtCategories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.Car.AddRange(

                    new Car()
                    {
                        Name = "Changan",
                        ShortDescription = "Chinese car",
                        LongDescription = "Chinese car has a range of 300 kilometers",
                        Image = "/image/changan.jpg",
                        Price = 12000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Electric Cars"]
                    },

                    new Car()
                    {
                        Name = "Nissan",
                        ShortDescription = "Liaf",
                        LongDescription = "Electric Car has a range of 100 kilometers",
                        Image = "/image/nissan.jpg",
                        Price = 10000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Electric Cars"]
                    },
                    new Car()
                    {
                        Name = "Toyota",
                        ShortDescription = "Petrol Car",
                        LongDescription = "Powerful petrol car with engine capacity 3.0",
                        Image = "/image/toyota.jpg",
                        Price = 22000,
                        IsFavourite = true,
                        Available = false,
                        Category = Categories["Petrol Cars"]
                    },

                    new Car()
                    {
                        Name = "Mercedes",
                        ShortDescription = "EQC class",
                        LongDescription = "Electric Car has a range of 471 kilometers",
                        Image = "/image/mercedes.jpg",
                        Price = 20000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Electric Cars"]
                    },

                    new Car()
                    {
                        Name = "KIA",
                        ShortDescription = "Ceed",
                        LongDescription = "Powerful petrol car with engine capacity 1.5",
                        Image = "/image/kia_ceed.jpg",
                        Price = 25000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Petrol Cars"]
                    },

                    new Car()
                    {
                        Name = "Volkswagen",
                        ShortDescription = "Taigun",
                        LongDescription = "Powerful petrol car with engine capacity 2.5",
                        Image = "/image/volkswagen.jpg",
                        Price = 40000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Petrol Cars"]
                    },
                    new Car()
                    {
                        Name = "Mitsubishi",
                        ShortDescription = "Pajero",
                        LongDescription = "Powerful petrol car with engine capacity 2.5",
                        Image = "/image/volkswagen.jpg",
                        Price = 41000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Petrol Cars"]
                    });
            }

            if (!content.Articles.Any())
            {
                content.Articles.AddRange(
                   new Article
                   {
                       Name = "What is Lorem Ipsum?",
                       Content =
                            "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                       Image = "/image/changan.jpg",
                       Category = _artCategory["Sport Car"]
                   },
                    new Article
                    {
                        Name = "Why do we use it?",
                        Content =
                            "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                        Image = "/image/changan.jpg",
                        Category = _artCategory["Classic Car"]
                    },
                    new Article
                    {
                        Name = "Where does it come from?",
                        Content =
                            "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.",
                        Image = "/image/changan.jpg",
                        Category = _artCategory["Sport Car"]
                    }
                    );
            }

            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Name = "Electric Cars", Description = "Best drivers choice " },
                        new Category { Name = "Petrol Cars", Description = "Classic Petrol Cars" }
                    };

                    _category = new Dictionary<string, Category>();
                    foreach (Category category in list)
                    {
                        _category.Add(category.Name, category);
                    }
                }

                return _category;
            }
        }

        public static Dictionary<string, ArticleCategory> ArtCategories
        {
            get
            {
                if (_artCategory == null)
                {
                    var list = new ArticleCategory[]
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

                    _artCategory = new Dictionary<string, ArticleCategory>();

                    foreach (ArticleCategory category in list)
                    {
                        _artCategory.Add(category.Name, category);
                    }
                }

                return _artCategory;
            }
        }
    }
}
