using Akvelon.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Akvelon.WebApi
{
    public class AkvelonDbContext : DbContext
    {

        public AkvelonDbContext(DbContextOptions<AkvelonDbContext> opt) : base (opt)
        {
            
        }

        public AkvelonDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ProjectTask>()
                .HasKey(e => e.Id);
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
    }
}
