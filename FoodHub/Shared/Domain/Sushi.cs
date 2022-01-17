using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Sushi : BaseDomain
    {
        public const int DefaultSize = 12;
        public const int MinimumSize = 9;
        public const int MaximumSize = 17;

        public int OrderId { get; set; }

        public SushiMenu Menu { get; set; }

        public int MenuId { get; set; }

        public int Size { get; set; }

        public List<IngredientSelection> Ingredients { get; set; }

        public decimal GetBasePrice()
        {
            return ((decimal)Size / (decimal)DefaultSize) * Menu.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            return GetBasePrice() + Ingredients.Sum(t => t.Ingredient.Price);
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}
