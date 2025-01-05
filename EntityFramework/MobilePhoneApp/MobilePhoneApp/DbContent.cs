using Microsoft.EntityFrameworkCore;
using MobilePhoneApp.Models;

namespace MobilePhoneApp
{
    class DbContent : DbContext
    {
        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Headquarters> Headquarters { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbContent()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MobilePhone;Trusted_Connection=True;");
        }
    }
}
