using Microsoft.EntityFrameworkCore;

namespace MedPillCorporationApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pill> Pills { get; set; }
    }
}
