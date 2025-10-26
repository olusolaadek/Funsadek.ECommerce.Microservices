using Microsoft.EntityFrameworkCore;
using Funsadek.Shared;

public class CatalogDbContext : DbContext
{
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Laptop", Description = "A high-performance laptop", Price = 999.99m },
            new Product { Id = 2, Name = "Mouse", Description = "Wireless mouse", Price = 29.99m },
            new Product { Id = 3, Name = "Keyboard", Description = "Mechanical keyboard", Price = 79.99m }
        );
    }
}