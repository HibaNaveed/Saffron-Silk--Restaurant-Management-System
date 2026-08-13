using Microsoft.EntityFrameworkCore;

namespace Restaurant_Management_System.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Bookatable> Table { get; set; }
    }
}
