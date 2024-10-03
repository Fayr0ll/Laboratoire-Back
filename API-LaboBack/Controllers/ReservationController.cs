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
    public class ReservationController : ControllerBase
    {
        private IReservationRepository<Reservation> _reservationService;

        public ReservationController(IReservationRepository<Reservation> reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_reservationService.Get().Select(r => r.ToAPI()));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var reservation = _reservationService.Get(id);
            if (reservation is null)
            {
                return NotFound();
            }
            return Ok(reservation);
        }

        [HttpPost]
        public IActionResult Post(ReservationPost reservation)
        {
            if (reservation is null)
            {
                return BadRequest();
            }
            _reservationService.Insert(reservation.ToBLL());
            return CreatedAtAction(nameof(Get), reservation);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, ReservationPost reservation)
        {
            if (reservation is null)
            {
                return BadRequest();
            }
            _reservationService.Update(id, reservation.ToBLL());
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _reservationService.Delete(id);
            return NoContent();
        }
    }
}
