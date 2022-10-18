using YumRestaurants.Model.Entities;

namespace YumRestaurants.Model.Data
{
    public interface IMenuRepo
    {
        public void Create(MenuItem menuItem);
        public MenuItem GetItemById(int id);

    }
}
