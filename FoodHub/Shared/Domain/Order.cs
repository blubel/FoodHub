using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Order : BaseDomain
    {
        public DateTime DateTime { get; set; }
        public float Payment { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
