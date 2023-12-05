using BlazorForms.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorForms.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Apple Keyboard iPad",
                Description = "Apple Smart Keyboard for iPad"
            },
            new Product
            {
                Id = 2,
                Name = "Apple IPhone 15",
                Description = "Apple IPhone 15 64GB GSM"
            }
        );
    }
}
