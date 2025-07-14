using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldCitiesAPI.Data;
using WorldCitiesAPI.Models;


namespace WorldCitiesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly CityContext _context;
        
        public CitiesController(CityContext context)
        {
            _context = context;
        }

        //Get: api/cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            return await _context.Cities.OrderByDescending(c => c.Population).ToListAsync();
        }

        // Get: api/cities/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            return city;
        }

        // POST: api/cities
        [HttpPost]
        public async Task<ActionResult<City>> PostCity(City city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCity), new { id = city.CityId }, city);
        }

        // PUT: api/cities/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, City city)
        {
            if (id != city.CityId)
            {
                return BadRequest();
            }
            _context.Entry(city).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/cities/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
