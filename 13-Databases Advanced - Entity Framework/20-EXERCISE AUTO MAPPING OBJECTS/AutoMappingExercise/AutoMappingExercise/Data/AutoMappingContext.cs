using AutoMappingExercise.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMappingExercise.Data
{
    public class AutoMappingContext : DbContext
    {
        public AutoMappingContext(DbContextOptions options) : base(options)
        {
        }

        public AutoMappingContext()
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOne(x => x.Manager)
                                           .WithMany(x => x.ManagerEmployees)
                                           .HasForeignKey(x => x.ManagerId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
