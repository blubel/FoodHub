using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodHub.Server.Data;
using FoodHub.Shared.Domain;
using FoodHub.Server.IRepository;

namespace FoodHub.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/RestaurantItems
        [HttpGet]
        public async Task<IActionResult> GetRestaurantItems()
        {
            var restaurantitems = await _unitOfWork.RestaurantItems.GetAll();
            return Ok(restaurantitems);
        }


        // GET: api/RestaurantItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRestaurantItem(int id)
        {
            var restaurantitem = await _unitOfWork.RestaurantItems.Get(q => q.Id == id);

            if (restaurantitem == null)
            {
                return NotFound();
            }

            return Ok(restaurantitem);
        }

        // PUT: api/RestaurantItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurantItem(int id, RestaurantItem restaurantitem)
        {
            if (id != restaurantitem.Id)
            {
                return BadRequest();
            }

            _unitOfWork.RestaurantItems.Update(restaurantitem);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RestaurantItemExists(id))
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

        // POST: api/RestaurantItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RestaurantItem>> PostRestaurantItem(RestaurantItem restaurantitem)
        {
            await _unitOfWork.RestaurantItems.Insert(restaurantitem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRestaurantItem", new { id = restaurantitem.Id }, restaurantitem);
        }

        // DELETE: api/RestaurantItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurantItem(int id)
        {
            var restaurantitem = await _unitOfWork.RestaurantItems.Get(q => q.Id == id);
            if (restaurantitem == null)
            {
                return NotFound();
            }

            await _unitOfWork.RestaurantItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RestaurantItemExists(int id)
        {
            var restaurantitem = await _unitOfWork.RestaurantItems.Get(q => q.Id == id);
            return restaurantitem != null;
        }
    }
}
