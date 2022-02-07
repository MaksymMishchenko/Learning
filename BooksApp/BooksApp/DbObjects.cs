using System.Collections.Generic;
using System.Linq;
using BooksApp.Models;

namespace BooksApp
{
    class DbObjects
    {
        private static Dictionary<string, Author> _authorsList;

        public static void Initial(DbContent dbContent)
        {
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
                        Author = Authors["Herbert Schildt"]
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
                    }
                );
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
                        new Author { Name = "Jefrey Rihter" },
                        new Author { Name = "Herbert Schildt" },
                        new Author { Name = "Eric Freeman" }
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
    }
}
