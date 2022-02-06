using EmployeeApp.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp
{
    class DbContent : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }

        public DbContent()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Employees;Trusted_Connection=True;");
        }
    }
}
