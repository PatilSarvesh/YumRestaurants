using Microsoft.EntityFrameworkCore;
using YumRestaurants.Model.Entities;

namespace YumRestaurants.Model.Data
{
    public class YumRestaurantDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=YumRestaurantDb;Integrated Security=True");
        }
            
        public DbSet<MenuItem> menuItems { get; set; }
        public DbSet<Cart> carts { get; set; }
    }
}
