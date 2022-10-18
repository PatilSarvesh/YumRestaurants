using System.ComponentModel.DataAnnotations;

namespace YumRestaurants.Model.Entities
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool freeDelivery { get; set; }
        [Required]
        public int Price { get; set; }
        public DateTime dateOfLaunch { get; set; }
        public bool Active { get; set; }


    }
}
