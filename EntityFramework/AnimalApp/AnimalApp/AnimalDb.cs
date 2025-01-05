using AnimalApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalApp
{
    class AnimalDb : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AnimalDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().OwnsOne(a => a.FoodInformation,
                f =>
                {
                    f.OwnsOne(p => p.Kind);
                    f.OwnsOne(p => p.Feed);
                });
        }
    }
}
