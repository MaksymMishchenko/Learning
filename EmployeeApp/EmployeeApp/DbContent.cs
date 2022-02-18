using EmployeeApp.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp
{
    class DbContent : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbContent()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Employees;Trusted_Connection=True;");
        }
    }
}
