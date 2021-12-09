// We are using Entity Framework for this, so we need to bring it in
using Microsoft.EntityFrameworkCore;
// Make sure you are using YOUR namespace
namespace CRUDelicious.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Dishes" table name will come from the DbSet variable name
        public DbSet<Dish> Dishes { get; set; }

    }
}
