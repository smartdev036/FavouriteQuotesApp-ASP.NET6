using FavouriteQuotesApp.Models;
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
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Do your initializing/seeding here...
            modelBuilder.Entity<Quote>().HasData(
                new Quote { Id = 1, Text = "Quote 1", Author = " Author 1", Rating = 3, Description = "Inspiring" },
                new Quote { Id = 2, Text = "Quote 2", Author = " Author 2", Rating = 4, Description = "Motivational" },
                new Quote { Id = 3, Text = "Quote 3", Author = " Author 3", Rating = 5, Description = "Thought-provoking" },
                new Quote { Id = 4, Text = "Quote 4", Author = " Author 1", Rating = 3, Description = "Inspiring" },
                new Quote { Id = 5, Text = "Quote 5", Author = " Author 2", Rating = 4, Description = "Motivational" },
                new Quote { Id = 6, Text = "Quote 6", Author = " Author 3", Rating = 5, Description = "Thought-provoking" }
            );
        }
    }
}
