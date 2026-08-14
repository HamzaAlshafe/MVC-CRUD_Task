using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Database=MVCCRUDTASK;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Wireless Mouse", Description = "Ergonomic wireless mouse with USB receiver", Price = 15.99m, rate = 4 },
                new Product { Id = 2, Name = "Mechanical Keyboard", Description = "RGB backlit mechanical keyboard", Price = 49.99m, rate = 5 },
                new Product { Id = 3, Name = "USB-C Hub", Description = "7-in-1 USB-C hub with HDMI and card reader", Price = 29.50m, rate = 3 },
                new Product { Id = 4, Name = "Laptop Stand", Description = "Adjustable aluminum laptop stand", Price = 22.00m, rate = 4 },
                new Product { Id = 5, Name = "Webcam 1080p", Description = "Full HD webcam with built-in microphone", Price = 34.99m, rate = 4 }
            );
        }
    }
}
