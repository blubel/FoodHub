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
    public class SushisController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SushisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Sushis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetSushis()
        {
            return await _context.Sushis.ToListAsync();
        }

        // GET: api/Sushis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sushi>> GetSushi(int id)
        {
            var sushi = await _context.Sushis.FindAsync(id);

            if (sushi == null)
            {
                return NotFound();
            }

            return sushi;
        }

        // PUT: api/Sushis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSushi(int id, Sushi sushi)
        {
            if (id != sushi.Id)
            {
                return BadRequest();
            }

            _context.Entry(sushi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SushiExists(id))
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

        // POST: api/Sushis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sushi>> PostSushi(Sushi sushi)
        {
            _context.Sushis.Add(sushi);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSushi", new { id = sushi.Id }, sushi);
        }

        // DELETE: api/Sushis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSushi(int id)
        {
            var sushi = await _context.Sushis.FindAsync(id);
            if (sushi == null)
            {
                return NotFound();
            }

            _context.Sushis.Remove(sushi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SushiExists(int id)
        {
            return _context.Sushis.Any(e => e.Id == id);
        }
    }
}
