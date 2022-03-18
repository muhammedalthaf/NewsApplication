using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<News> News { get; set; }
        public DbSet<NewsAttachment> NewsAttachments { get; set; }
        public DbSet<School> Schools { get; set; }
        public object School { get; internal set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().HasData(
                new School() { SchoolId = 1, SchoolName = "Al manarath/Al Khobar" },
                new School() { SchoolId = 2, SchoolName = "Al Faisaliyah Islamic International" }
                );
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}
