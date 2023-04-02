using Microsoft.EntityFrameworkCore;

namespace Store.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        
        public DbSet<Products> products { get; set; }

        public DbSet<ProductsDetails> productsDetails { get; set; }
    }
}
