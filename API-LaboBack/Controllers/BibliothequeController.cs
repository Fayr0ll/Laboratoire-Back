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
    public class BibliothequeController : ControllerBase
    {
        private IBibliothequeRepository<Bibliotheque> _bibliothequeService;

        public BibliothequeController(IBibliothequeRepository<Bibliotheque> bibliothequeService)
        {
            _bibliothequeService = bibliothequeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bibliothequeService.Get().Select(b => b.ToAPI()));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var bibli = _bibliothequeService.Get(id);
            if (bibli is null)
            {
                return NotFound();
            }
            return Ok(bibli);
        }

        [HttpPost]
        public IActionResult Post(BibliothequePost bibli)
        {
            if (bibli is null)
            {
                return BadRequest();
            }
            _bibliothequeService.Insert(bibli.ToBLL());
            return CreatedAtAction(nameof(Get), bibli);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, BibliothequePost bibli)
        {
            if (bibli is null)
            {
                return BadRequest();
            }
            _bibliothequeService.Update(id, bibli.ToBLL());
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _bibliothequeService.Delete(id);
            return NoContent();
        }
    }
}
