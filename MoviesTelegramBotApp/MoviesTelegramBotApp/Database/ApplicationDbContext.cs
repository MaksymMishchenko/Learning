using Microsoft.EntityFrameworkCore;
using MoviesTelegramBotApp.Models;

namespace MoviesTelegramBotApp.Database
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
