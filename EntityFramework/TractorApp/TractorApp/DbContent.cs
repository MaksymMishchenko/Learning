using Microsoft.EntityFrameworkCore;
using TractorApp.Models;

namespace TractorApp
{
    public class DbContent : DbContext
    {
        public DbSet<Tractor> Tractor { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TractorDB;Trusted_Connection=True;");
        }
    }
}
