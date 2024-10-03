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
    public class GenreController : ControllerBase
    {
        private IGenreRepository<Genre> _genreService;

        public GenreController(IGenreRepository<Genre> genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_genreService.Get().Select(g => g.ToAPI()));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var genre = _genreService.Get(id);
            if (genre is null)
            {
                return NotFound();
            }
            return Ok(genre);
        }

        [HttpPost]
        public IActionResult Post(GenrePost genre)
        {
            if (genre is null)
            {
                return BadRequest();
            }
            _genreService.Insert(genre.ToBLL());
            return CreatedAtAction(nameof(Get), genre);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, GenrePost genre)
        {
            if (genre is null)
            {
                return BadRequest();
            }
            _genreService.Update(id, genre.ToBLL());
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _genreService.Delete(id);
            return NoContent();
        }
    }
}
