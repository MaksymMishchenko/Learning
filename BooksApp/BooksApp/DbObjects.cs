using BooksApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BooksApp
{
    class DbObjects
    {
        private static Dictionary<string, Author> _authorsList;
        private static Dictionary<string, Country> _countriesList;
        private static Dictionary<string, Capital> _capitalsList;
        private static Dictionary<string, PublishHouse> _publishHousesList;

        public static void Initial(DbContent dbContent)
        {
            if (!dbContent.Countries.Any())
            {
                dbContent.Countries.AddRange(Countries.Select(c => c.Value));
            }

            if (!dbContent.Capitals.Any())
            {
                dbContent.Capitals.AddRange(Capitals.Select(c => c.Value));
            }

            if (!dbContent.PublishHouse.Any())
            {
                dbContent.PublishHouse.AddRange(PublishHouses.Select(ph => ph.Value));
            }

            if (!dbContent.Authors.Any())
            {
                dbContent.Authors.AddRange(Authors.Select(a => a.Value));
            }

            if (!dbContent.Books.Any())
            {
                dbContent.Books.AddRange(
                    new Book()
                    {
                        Name = "CLR via C#",
                        Author = Authors["Herbert Schildt"],
                        PublishHouse = PublishHouses["University of Chicago Press"]
                    },
                    new Book()
                    {
                        Name = "CLR via C#",
                        Author = Authors["Jefrey Rihter"],
                        PublishHouse = PublishHouses["University of Chicago Press"]
                    },
                    new Book()
                    {
                        Name = "C# The complete reference",
                        Author = Authors["Herbert Schildt"],
                        PublishHouse = PublishHouses["University of Chicago Press"]
                    },
                    new Book()
                    {
                        Name = "C++ A beginner guide",
                        Author = Authors["Herbert Schildt"],
                        PublishHouse = PublishHouses["Washington Institute Press"]
                    },
                    new Book()
                    {
                        Name = "Design patterns",
                        Author = Authors["Eric Freeman"],
                        PublishHouse = PublishHouses["Washington Institute Press"]
                    },
                    new Book()
                    {
                        Name = "Programming Applications",
                        Author = Authors["Jefrey Rihter"],
                        PublishHouse = PublishHouses["Washington Institute Press"]
                    });
            }

            dbContent.SaveChanges();
        }

        public static Dictionary<string, Author> Authors
        {
            get
            {
                if (_authorsList == null)
                {
                    var list = new Author[]
                    {
                        new Author { Name = "Jefrey Rihter", Country = Countries["USA"] },
                        new Author { Name = "Herbert Schildt", Country = Countries["USA"] },
                        new Author { Name = "Eric Freeman", Country = Countries["Ukraine"] }
                    };

                    _authorsList = new Dictionary<string, Author>();

                    foreach (Author author in list)
                    {
                        _authorsList.Add(author.Name, author);
                    }
                }

                return _authorsList;
            }
        }

        public static Dictionary<string, Country> Countries
        {
            get
            {
                if (_countriesList == null)
                {
                    var list = new Country[]
                    {
                        new Country { Name = "USA", Capital = Capitals["Washington"] },
                        new Country { Name = "Ukraine", Capital = Capitals["Kyiv"] }
                    };

                    _countriesList = new Dictionary<string, Country>();

                    foreach (var country in list)
                    {
                        _countriesList.Add(country.Name, country);
                    }
                }

                return _countriesList;
            }
        }

        public static Dictionary<string, Capital> Capitals
        {
            get
            {
                if (_capitalsList == null)
                {
                    var list = new Capital[]
                    {
                        new Capital { Name = "Washington" },
                        new Capital { Name = "Kyiv" }
                    };

                    _capitalsList = new Dictionary<string, Capital>();

                    foreach (var capital in list)
                    {
                        _capitalsList.Add(capital.Name, capital);
                    }
                }

                return _capitalsList;
            }
        }
        public static Dictionary<string, PublishHouse> PublishHouses
        {
            get
            {
                if (_publishHousesList == null)
                {
                    var list = new PublishHouse[]
                    {
                        new PublishHouse { Name = "University of Chicago Press" },
                        new PublishHouse { Name = "Washington Institute Press" }
                    };

                    _publishHousesList = new Dictionary<string, PublishHouse>();

                    foreach (var publishHouse in list)
                    {
                        _publishHousesList.Add(publishHouse.Name, publishHouse);
                    }
                }

                return _publishHousesList;
            }
        }
    }
}
