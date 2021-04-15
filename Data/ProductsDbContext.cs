using Microsoft.EntityFrameworkCore;
using lab3.Models;

namespace lab3.Data
{
    public class ProductsDbContext: DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
          : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
