using Microsoft.EntityFrameworkCore;
using StudentApp.Models;

namespace StudentApp
{
    class DbContent : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Student;Trusted_Connection=True;");
        }
    }
}
