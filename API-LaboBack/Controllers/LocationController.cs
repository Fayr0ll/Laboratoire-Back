using API_LaboBack.Mapper;
using API_LaboBack.Models;
using BLL_LaboBack.Entities;
using COMMON_LaboBack.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_LaboBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationRepository<Location> _locationService;

        public LocationController(ILocationRepository<Location> locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_locationService.Get().Select(l => l.ToAPI()));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var location = _locationService.Get(id);
            if (location is null)
            {
                return NotFound();
            }
            return Ok(location);
        }

        [HttpPost]
        public IActionResult Post(LocationPost location)
        {
            if (location is null)
            {
                return BadRequest();
            }
            _locationService.Insert(location.ToBLL());
            return CreatedAtAction(nameof(Get), location);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, LocationPut location)
        {
            if (location is null)
            {
                return BadRequest();
            }
            _locationService.Update(id, location.ToBLL());
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _locationService.Delete(id);
            return NoContent();
        }
    }
}
