using Microsoft.EntityFrameworkCore;

namespace magazz.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Purchase> Purchases { get; set; } = null!;
        public DbSet<Storage> Storages { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add the shadow property to the model
            modelBuilder.Entity<Post>()
                .HasOne(b => b.Worker)
                .WithOne(i => i.Post)
                .HasForeignKey<Worker>(b => b.IdPost);
        }
    }
}

     


