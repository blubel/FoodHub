using CarRentalManagement.Server.Repository;
using FoodHub.Server.Data;
using FoodHub.Server.IRepository;
using FoodHub.Server.Models;
using FoodHub.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FoodHub.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Meal> _meals;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<Custom> _customs;
        private IGenericRepository<Sushi> _sushis;
        private IGenericRepository<Ingredient> _ingredients;
        private IGenericRepository<Drink> _drinks;


        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Meal> Meals
            => _meals ??= new GenericRepository<Meal>(_context);
        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<Custom> Customs
            => _customs ??= new GenericRepository<Custom>(_context);
        public IGenericRepository<Sushi> Sushis
            => _sushis ??= new GenericRepository<Sushi>(_context);
        public IGenericRepository<Ingredient> Ingredients
            => _ingredients ??= new GenericRepository<Ingredient>(_context);
        public IGenericRepository<Drink> Drinks
            => _drinks ??= new GenericRepository<Drink>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            await _context.SaveChangesAsync();
        }
    }
}