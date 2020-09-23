using Microsoft.EntityFrameworkCore;

namespace OutbackProducts.Models
{
    public class StoreDbContext : DbContext
    {
        // Entity Framework Core provides access 
        // to the database through a context class.
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) {   }

        // Provides access to the Product objects in the database
        public DbSet<Product> Products { get; set; }
        
        

    }




}

