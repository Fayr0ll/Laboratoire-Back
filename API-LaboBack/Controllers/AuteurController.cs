using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL_LaboBack.Entities;

using COMMON_LaboBack.Repositories;
using API_LaboBack.Mapper;
using API_LaboBack.Models;

namespace API_LaboBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuteurController : ControllerBase
    {
        private IAuteurRepository<Auteur> _auteurService;

        public AuteurController(IAuteurRepository<Auteur> auteurService)
        {
            _auteurService = auteurService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_auteurService.Get().Select(a => a.ToAPI()));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var auteur = _auteurService.Get(id);
            if (auteur is null)
            {
                return NotFound();
            }
            return Ok(auteur);
        }

        [HttpPost]
        public IActionResult Post(AuteurPost auteur)
        {
            if (auteur is null)
            {
                return BadRequest();
            }
            _auteurService.Insert(auteur.ToBLL());
            return CreatedAtAction(nameof(Get), auteur);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, AuteurPost auteur)
        {
            if (auteur is null)
            {
                return BadRequest();
            }
            _auteurService.Update(id, auteur.ToBLL());
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _auteurService.Delete(id);
            return NoContent();
        }
    }
}
