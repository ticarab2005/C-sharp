using Microsoft.EntityFrameworkCore;

namespace BeltReview.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){ }
        public DbSet<User> Users {get;set;}
        public DbSet<Post> Posts {get;set;}
        public DbSet<Like> Likes {get;set;}
    }
}