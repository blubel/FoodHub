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
    [Route("api/[controller]")]
    [ApiController]
    public class CustomsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Customs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Custom>>> GetCustoms()
        {
            return await _context.Customs.ToListAsync();
        }

        // GET: api/Customs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Custom>> GetCustom(int id)
        {
            var custom = await _context.Customs.FindAsync(id);

            if (custom == null)
            {
                return NotFound();
            }

            return custom;
        }

        // PUT: api/Customs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustom(int id, Custom custom)
        {
            if (id != custom.Id)
            {
                return BadRequest();
            }

            _context.Entry(custom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Custom>> PostCustom(Custom custom)
        {
            _context.Customs.Add(custom);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustom", new { id = custom.Id }, custom);
        }

        // DELETE: api/Customs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustom(int id)
        {
            var custom = await _context.Customs.FindAsync(id);
            if (custom == null)
            {
                return NotFound();
            }

            _context.Customs.Remove(custom);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomExists(int id)
        {
            return _context.Customs.Any(e => e.Id == id);
        }
    }
}
