using Microsoft.EntityFrameworkCore;

namespace FavouriteQuotesApp.Entities
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext(DbContextOptions<QuotesDbContext> options)
            : base(options)
        {
        }

        // Add your properties for accessing your entities here...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Do your initializing/seeding here...
        }
    }
}
