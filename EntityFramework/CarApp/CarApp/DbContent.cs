using Microsoft.EntityFrameworkCore;

namespace CarApp
{
    class DbContent : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarClassification> CarClassifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Car;Trusted_Connection=True;");
        }
    }
}
