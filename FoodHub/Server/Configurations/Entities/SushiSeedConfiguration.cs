using FoodHub.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHub.Server.Configurations.Entities
{
    public class SushiSeedConfiguration : IEntityTypeConfiguration<Sushi>
    {
        public void Configure(EntityTypeBuilder<Sushi> builder)
        {
            builder.HasData(
                new Sushi
                {
                    Id = 1,
                    Name = "Salmon Bowl",
                    Price = 7.00
                },
                new Sushi
                {
                    Id = 2,
                    Name = "Tuna Bowl",
                    Price = 7.30
                },
                new Sushi
                {
                    Id = 3,
                    Name = "Swordfish Bowl",
                    Price = 7.50
                },
                new Sushi
                {
                    Id = 4,
                    Name = "Octopus Bowl",
                    Price = 8.00
                },
                new Sushi
                {
                    Id = 5,
                    Name = "Oriental Bowl",
                    Price = 10.00
                }
                );
        }
    }
}