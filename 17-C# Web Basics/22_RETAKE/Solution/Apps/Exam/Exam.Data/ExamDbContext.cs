using Exam.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.Data
{
    public class ExamDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        //public DbSet<User> Users { get; set; }


        //public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbConfig.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
