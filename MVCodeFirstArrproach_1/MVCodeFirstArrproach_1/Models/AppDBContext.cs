using Microsoft.EntityFrameworkCore;
using MVCodeFirstArrproach_1.Models;
namespace MVCodeFirstArrproach_1.Models
{
    public class AppDBContext:DbContext
    {

            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }

            public AppDBContext(DbContextOptions<AppDBContext> options)
                : base(options)
            {
            }
        }

    }

