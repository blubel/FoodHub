using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Ingredient : BaseDomain
    {

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string GetFormattedPrice() => Price.ToString("0.00");
    }
}
