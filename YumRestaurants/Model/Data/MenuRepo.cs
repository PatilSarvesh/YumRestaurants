using YumRestaurants.Model.Entities;

namespace YumRestaurants.Model.Data
{
    public class MenuRepo : IMenuRepo
    {
        YumRestaurantDbContext db = new YumRestaurantDbContext();
        public void Create(MenuItem menuItem)
        {
            db.menuItems.Add(menuItem);
            db.SaveChanges();
        }

        public MenuItem GetItemById(int id)
        {
            return db.menuItems.Find(id);
            
        }
    }
}
