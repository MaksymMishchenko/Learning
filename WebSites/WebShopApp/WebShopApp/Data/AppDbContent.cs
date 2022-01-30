using Microsoft.EntityFrameworkCore;
using WebShopApp.Data.Models;

namespace WebShopApp.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options):base()
        {
                
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=Shop;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
