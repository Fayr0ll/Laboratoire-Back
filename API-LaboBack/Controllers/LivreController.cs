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
    public class LivreController : ControllerBase
    {
        private ILivreRepository<Livre> _livreService;

        public LivreController(ILivreRepository<Livre> livreService)
        {
            _livreService = livreService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_livreService.Get().Select(l => l.ToAPI()));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var livre = _livreService.Get(id);
            if (livre is null)
            {
                return NotFound();
            }
            return Ok(livre);
        }

        [HttpPost]
        public IActionResult Post(LivrePost livre)
        {
            if (livre is null)
            {
                return BadRequest();
            }
            _livreService.Insert(livre.ToBLL());
            return CreatedAtAction(nameof(Get), livre);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, LivrePost livre)
        {
            if (livre is null)
            {
                return BadRequest();
            }
            _livreService.Update(id, livre.ToBLL());
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _livreService.Delete(id);
            return NoContent();
        }
    }
}
