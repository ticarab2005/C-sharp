using Microsoft.EntityFrameworkCore;

namespace Artistry.Models
{ 
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}