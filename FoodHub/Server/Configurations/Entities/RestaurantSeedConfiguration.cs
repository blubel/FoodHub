using FoodHub.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FoodHub.Server.Configurations.Entities
{
    public class RestaurantSeedConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData
            (
                new Restaurant
                {
                    Id = 1,
                    Name = "Pho Paradise",
                    Address = "1 Empress Place Raffles Boulevard"

                },

                new Restaurant
                {
                    Id = 2,
                    Name = "Burger Stack",
                    Address = "23 Tampines Street"
                }
                ) ;
        }
    }
}
