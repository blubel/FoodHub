using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
<<<<<<< HEAD:FoodHub/Shared/Domain/Sushi.cs
    public class Sushi : BaseDomain
=======
    public class Ingredient : BaseDomain
>>>>>>> 09396e93f3af975d42ca3a510793940589ee4616:FoodHub/Shared/Domain/Ingredient.cs
    {

        public string Name { get; set; }

<<<<<<< HEAD:FoodHub/Shared/Domain/Sushi.cs
        public double Price { get; set; }
=======
        public decimal Price { get; set; }

        public string GetFormattedPrice() => Price.ToString("0.00");
>>>>>>> 09396e93f3af975d42ca3a510793940589ee4616:FoodHub/Shared/Domain/Ingredient.cs
    }
}
