using Microsoft.EntityFrameworkCore;
using BlazorAppDemo.Models;

namespace BlazorAppDemo
{
    public class BlazorDemoDbContext : DbContext
    {
        public BlazorDemoDbContext(DbContextOptions<BlazorDemoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

   

        // Define DbSet properties for your entity classes here
        // For example:
        // public DbSet<YourEntityClass> YourEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)"); // Example column type for decimal with precision 18 and scale 2
        }
    }
}
