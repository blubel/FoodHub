using FoodHub.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHub.Server.Configurations.Entities
{
    public class IngredientSeedConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(
                new Ingredient
                {
                    Id = 1,
                    Name = "Salmon",
                    Price = 2.00
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "Tuna",
                    Price = 2.20
                },
                new Ingredient
                {
                    Id = 3,
                    Name = "Swordfish",
                    Price = 2.50
                },
                new Ingredient
                {
                    Id = 4,
                    Name = "Octopus",
                    Price = 2.70
                },
                new Ingredient
                {
                    Id = 5,
                    Name = "Tamago",
                    Price = 1.50
                },
                new Ingredient
                {
                    Id = 6,
                    Name = "Cucumber",
                    Price = 1.00
                },
                new Ingredient
                {
                    Id = 7,
                    Name = "Ikura",
                    Price = 5.00
                },
                new Ingredient
                {
                    Id = 8,
                    Name = "Seaweed flakes",
                    Price = 1.30
                },
                new Ingredient
                {
                    Id = 9,
                    Name = "Cherry tomatoes",
                    Price = 0.80
                },
                new Ingredient
                {
                    Id = 10,
                    Name = "Pickled radish",
                    Price = 1.60
                }
                );
        }
    }
}