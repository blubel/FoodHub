using System;
using System.Collections.Generic;

namespace FoodHub.Shared.Domain
{
    public class OrderItem : BaseDomain
    {
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int RestaurantItemId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public List<RestaurantItem> Items { get; set; }
    }
}