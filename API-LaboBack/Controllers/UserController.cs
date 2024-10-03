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
    public class UserController : ControllerBase
    {
        private IUserRepository<User> _userService;

        public UserController(IUserRepository<User> userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.Get().Select(u => u.ToAPI()));
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var user = _userService.Get(id);
            if (user is null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post(UserPost user)
        {
            if (user is null)
            {
                return BadRequest();
            }
            _userService.Insert(user.ToBLL());
            return CreatedAtAction(nameof(Get), user);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, UserPost user)
        {
            if (user is null)
            {
                return BadRequest();
            }
            _userService.Update(id, user.ToBLL());
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return NoContent();
        }
    }
}
