using FoodHub.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FoodHub.Server.Configurations.Entities
{
    public class RestaurantItemSeedConfiguration : IEntityTypeConfiguration<RestaurantItem>
    {
        public void Configure(EntityTypeBuilder<RestaurantItem> builder)
        {
            builder.HasData(
                new RestaurantItem
                {
                    Id = 1,
                    RestaurantId = 1,
                    Name = "Bowl of Heaven",
                    Description = "Our take on classic pho; succulent broth with fresh beef slices and glass noodles topped generously with spring onions.",
                    Cost = 9.50
                }
                );

        }
    }
}
