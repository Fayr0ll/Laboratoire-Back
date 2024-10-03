using API_LaboBack.Models;
using COMMON_LaboBack.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL_LaboBack.Entities;
using API_LaboBack.Mapper;

namespace API_LaboBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VenteController : ControllerBase
    {
        private IVenteRepository<Vente> _venteService;

        public VenteController(IVenteRepository<Vente> venteService)
        {
            _venteService = venteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_venteService.Get().Select(v => v.ToAPI()));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var vente = _venteService.Get(id);
            if (vente is null)
            {
                return NotFound();
            }
            return Ok(vente);
        }

        [HttpPost]
        public IActionResult Post(VentePost vente)
        {
            if (vente is null)
            {
                return BadRequest();
            }
            _venteService.Insert(vente.ToBLL());
            return CreatedAtAction(nameof(Get), vente);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, VentePost vente)
        {
            if (vente is null)
            {
                return BadRequest();
            }
            _venteService.Update(id, vente.ToBLL());
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _venteService.Delete(id);
            return NoContent();
        }
    }
}
