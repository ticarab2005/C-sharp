using Microsoft.EntityFrameworkCore;
namespace MtoMDemo.Models
{
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Cast { get; set; }
    }
}