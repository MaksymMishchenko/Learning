using Microsoft.EntityFrameworkCore;
using WorkersApp.Models;

namespace WorkersApp
{
    internal class DbContent : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerProfile> WorkersProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Workers;Trusted_Connection=True;");
        }
    }
}
