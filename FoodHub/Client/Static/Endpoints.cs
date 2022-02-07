using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHub.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string DrinksEndpoint = $"{Prefix}/drinks";
        public static readonly string SushisEndpoint = $"{Prefix}/sushis";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
        public static readonly string MealsEndpoint = $"{Prefix}/meals";
        public static readonly string IngredientsEndpoint = $"{Prefix}/ingredients";
        public static readonly string CustomsEndpoint = $"{Prefix}/customs";
        public static readonly string AccountsEndpoint = $"{Prefix}/accounts";


    }
}
