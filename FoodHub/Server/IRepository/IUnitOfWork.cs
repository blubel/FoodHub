using FoodHub.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHub.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Meal> Meals { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Custom> Customs { get; }
        IGenericRepository<Sushi> Sushis { get; }
        IGenericRepository<Ingredient> Ingredients { get; }
        IGenericRepository<Drink> Drinks { get; }

    }
}