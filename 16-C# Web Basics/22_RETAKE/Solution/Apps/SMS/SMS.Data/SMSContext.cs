namespace SMS.Data
{
    using Microsoft.EntityFrameworkCore;
    using SMS.Models;

    // ReSharper disable once InconsistentNaming
    public class SMSContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=SMSDb;Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cart>()
                 .HasOne(x => x.User)
                 .WithOne(x => x.Cart)
                .HasForeignKey<User>(x => x.CartId);

            builder.Entity<User>()
                 .HasOne(x => x.Cart)
                 .WithOne(x => x.User)
                .HasForeignKey<Cart>(x => x.UserId);

            builder.Entity<Cart>().HasMany(x => x.Products)
               .WithOne(x => x.Cart).HasForeignKey(x => x.CartId);

            base.OnModelCreating(builder);
        }
    }
}