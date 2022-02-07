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
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Custom> Customs { get; set; }
        public DbSet<Sushi> Sushis { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new MealSeedConfiguration());
            
            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

            builder.ApplyConfiguration(new IngredientSeedConfiguration());
            
            builder.ApplyConfiguration(new DrinkSeedConfiguration());
           
            builder.ApplyConfiguration(new SushiSeedConfiguration());






        }

        public DbSet<FoodHub.Shared.Domain.Ingredient> Ingredient { get; set; }

        public DbSet<FoodHub.Shared.Domain.Drink> Drink { get; set; }
    }
    }

