using FoodHub.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHub.Server.Configurations.Entities
{
    public class MealSeedConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData(
                new Meal
                {
                    Id = 1,
                    Food = "Salmon Bowl",
                    Drink = "Coke Zero",
                    Price = 10.50
                },
                new Meal
                {
                    Id = 2,
                    Food = "Tuna Bowl",
                    Drink = "Coke",
                    Price = 11.20
                },
                new Meal
                {
                    Id = 3,
                    Food = "Swordfish Bowl",
                    Drink = "Ice Lemon Tea",
                    Price = 12.00
                },
                new Meal
                {
                    Id = 4,
                    Food = "Oriental Bowl (Salmon, Tuna, Swordfish)",
                    Drink = "Sprite",
                    Price = 15.00
                }

                );
        }
    }
}
