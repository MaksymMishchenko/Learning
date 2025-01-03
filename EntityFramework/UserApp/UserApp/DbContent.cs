using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace UserApp
{
    class DbContent : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbContent()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=Users;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
