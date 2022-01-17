using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodHub.Server.Data;
using FoodHub.Shared.Domain;

namespace FoodHub.Server.Controllers
{
    [Route("sushi")]
    [ApiController]
    public class SpecialsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SpecialsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<SushiMenu>>> GetMenu()
        {
            return (await _db.SushiMenu.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
        }
    }
}
