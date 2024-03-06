using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Mission6_McLaughlin.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Movie> Movies {  get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
