using BooksApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BooksApp
{
    class DbObjects
    {
        private static Dictionary<string, Author> _authorsList;
        private static Dictionary<string, Country> _countriesList;

        public static void Initial(DbContent dbContent)
        {
            if (!dbContent.Countries.Any())
            {
                dbContent.Countries.AddRange(Countries.Select(c => c.Value));
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
                    },
                    new Book()
                    {
                        Name = "CLR via C#",
                        Author = Authors["Jefrey Rihter"]
                    },
                    new Book()
                    {
                        Name = "C# The complete reference",
                        Author = Authors["Herbert Schildt"]
                    },
                    new Book()
                    {
                        Name = "C++ A beginner guide",
                        Author = Authors["Herbert Schildt"]
                    },
                    new Book()
                    {
                        Name = "Design patterns",
                        Author = Authors["Eric Freeman"]
                    },
                    new Book()
                    {
                        Name = "Programming Applications",
                        Author = Authors["Jefrey Rihter"]
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
                        new Author { Name = "Jefrey Rihter", Country = Countries["USA"]},
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
                        new Country { Name = "USA" },
                        new Country { Name = "Ukraine" }
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
    }
}
