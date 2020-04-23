using Microsoft.EntityFrameworkCore;

namespace CsharpBelt.Models
{
    public class BeltContext : DbContext
    {
        public BeltContext(DbContextOptions options) : base(options) {}
        // tables in db
        public DbSet<User> Users { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}