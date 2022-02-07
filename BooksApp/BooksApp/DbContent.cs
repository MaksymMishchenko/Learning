using BooksApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksApp
{
    class DbContent : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbContent()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Books;Trusted_Connection=True;");
        }
    }
}
