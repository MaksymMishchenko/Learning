using Microsoft.EntityFrameworkCore;
using PupilApp.Models;

namespace PupilApp
{
    class DbPupils : DbContext
    {
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PupilsDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ClassRoom>()
                .HasMany(p => p.Pupils)
                .WithMany(cr => cr.ClassRooms)
                .UsingEntity<Success>(
                    j => j
                        .HasOne(p => p.Pupil)
                        .WithMany(s => s.Successes)
                        .HasForeignKey(p => p.PupilsId),
                    j => j.HasOne(c => c.ClassRoom).WithMany(p => p.Successes).HasForeignKey(c => c.ClassRoomsId),

                    j =>
                    {
                        j.Property(p => p.Date).HasDefaultValueSql("CURRENT_TIMESTAMP");
                        j.Property(p => p.Mark).HasDefaultValue(4);
                        j.HasKey(t => new { t.ClassRoomsId, t.PupilsId });
                        j.ToTable("Success");
                    });
        }
    }
}
