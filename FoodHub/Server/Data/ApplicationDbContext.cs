using FoodHub.Server.Configurations.Entities;
using FoodHub.Server.Models;
using FoodHub.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHub.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Order> Orders { get; set; }

        public DbSet<SushiMenu> SushiMenu { get; set; }
        
        public DbSet<Sushi> Sushis { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
           // configure a many to many rs for sushi to have many ingredients
           builder.Entity<IngredientSelection>().HasKey(pst => new { pst.SushiId, pst.IngredientId });
           builder.Entity<IngredientSelection>().HasOne<Sushi>().WithMany(ps => ps.Ingredients);
           builder.Entity<IngredientSelection>().HasOne(pst => pst.Ingredient).WithMany();

             // Inline the Lat-Long pairs in Order rather than having a FK to another table
            builder.Entity<Order>().OwnsOne(o => o.DeliveryLocation);

            builder.ApplyConfiguration(new CustomerSeedConfiguration());

            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());




        }
    }
    }

