using ClientsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientsApp
{
    public class DbClients : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbClients()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Clients;Trusted_Connection=True;");
        }
    }
}
