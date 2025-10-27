using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Data
{
    public class DealsFinderDbContext : DbContext
    {
        // Constructor - passes options to the base DbContext class
        public DealsFinderDbContext(DbContextOptions<DealsFinderDbContext> options)
            : base(options)
        {
        }

        // DbSets - plural names for collections of entities
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodDeliveryService> FoodDeliveryServices { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        // OnModelCreating - configure the model and relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set table names to singular (not plural)
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<FoodDeliveryService>().ToTable("FoodDeliveryService");
            modelBuilder.Entity<Subscription>().ToTable("Subscription");

            // Configure composite primary key for Subscription
            modelBuilder.Entity<Subscription>()
                .HasKey(s => new { s.CustomerId, s.ServiceId });
        }
    }
}