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
                .HasForeignKey<Worker>(b => b.Id);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Order)
                .WithOne(d => d.Customer)
                .HasForeignKey<Order>(d => d.Id);

            modelBuilder.Entity<Storage>()
                .HasOne(e => e.Purchase)
                .WithOne(f => f.Storage)
                .HasForeignKey<Purchase>(e => e.Id); 
            
            modelBuilder.Entity<Product>()
                .HasOne(h => h.Purchase)
                .WithOne(j => j.Product)
                .HasForeignKey<Purchase>(h => h.Id);

            modelBuilder.Entity<Product>()
                .HasOne(h => h.Order)
                .WithOne(j => j.Product)
                .HasForeignKey<Order>(h => h.Id);

            modelBuilder.Entity<Worker>()
                .HasOne(l => l.Order)
                .WithOne(m => m.Worker)
                .HasForeignKey<Order>(l => l.Id);


        }

    }
}

     


