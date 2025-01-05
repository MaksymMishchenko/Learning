﻿using DatabaseProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProject.DbContexts
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
