namespace YumRestaurants.Model.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        public int userId { get; set; }
        public List<MenuItem> menuItemId { get; set; } = new List<MenuItem>();
        
        

    }
}
