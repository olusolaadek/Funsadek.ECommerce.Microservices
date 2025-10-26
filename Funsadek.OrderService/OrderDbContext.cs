using Microsoft.EntityFrameworkCore;
using Funsadek.Shared;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Order>().HasData(
            new Order { Id = 1, ProductId = 1, Quantity = 2, OrderDate = DateTime.UtcNow.AddDays(-1) },
            new Order { Id = 2, ProductId = 2, Quantity = 1, OrderDate = DateTime.UtcNow.AddHours(-5) },
            new Order { Id = 3, ProductId = 3, Quantity = 3, OrderDate = DateTime.UtcNow.AddMinutes(-30) }
        );
    }
}