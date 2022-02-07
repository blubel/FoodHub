using FoodHub.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHub.Server.Configurations.Entities
{
    public class DrinkSeedConfiguration : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            builder.HasData(
                new Drink
                {
                    Id = 1,
                    Name = "Coke",
                    Price = 1.20
                },
                new Drink
                {
                    Id = 2,
                    Name = "Coke Zero",
                    Price = 1.30
                },
                new Drink
                {
                    Id = 3,
                    Name = "Sprite",
                    Price = 1.50
                },
                new Drink
                {
                    Id = 4,
                    Name = "Japanese Green Tea",
                    Price = 2.20
                },
                new Drink
                {
                    Id = 5,
                    Name = "Ice Lemon Tea",
                    Price = 2.00
                }
                );
        }
    }
}
