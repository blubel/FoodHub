using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class IngredientSelection : BaseDomain
    {
        public Ingredient Ingredient { get; set; }

        public int IngredientId { get; set; }

        public int SushiId { get; set; }
    }
}
