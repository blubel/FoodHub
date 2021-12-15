namespace FoodHub.Shared.Domain
{
    public class RestaurantItem : BaseDomain
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}