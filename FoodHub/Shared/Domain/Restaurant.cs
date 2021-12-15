using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Restaurant : BaseDomain
    {
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
