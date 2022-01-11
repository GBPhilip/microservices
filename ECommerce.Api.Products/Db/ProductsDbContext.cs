using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Products.Db
{
    public class ProductsDbContext : DbContext
    {
        public DbSet Products { get; set; }
        public ProductsDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
