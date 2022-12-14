using eShop.Database.Configs;
using eShop.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.Database
{
    public class AddDbContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public AddDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());

        }
    }
}
