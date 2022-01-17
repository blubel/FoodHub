using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Order : BaseDomain
    {

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public LatLong DeliveryLocation { get; set; }

        public List<Sushi> Sushis { get; set; } = new List<Sushi>();

        public decimal GetTotalPrice() => Sushis.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
