using System;

namespace lab3.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Item { get; set; }
        public string Quantity { get; set; }
        public Boolean isAvailable { get; set; }
    }
    public class ProductsDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Product> Products { get; set; }
    }
}
