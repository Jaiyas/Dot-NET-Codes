using Microsoft.EntityFrameworkCore;
using ProductMicroSevice.Models;
namespace ProductMicroSevice.DBContext
{
    public class ProductContext:DbContext
    {
   public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Catgories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Electronics",
                    Description = "Electronic Items,"
                },
                new Category
                {
                    Id = 2,
                    Name = "Clothes",
                    Description = "Dresses",

                },
                new Category
                {
                    Id = 3,
                    Name = "Grocery",
                    Description = "Grocery Items",

                });

        }

    }
}
