using API_LaboBack.Models.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BLL = BLL_LaboBack.Entities;

namespace API_LaboBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase //A retoucher
    {
        //private readonly IConfiguration _configuration;

        //public AuthController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        //[HttpPost("login")]
        //public IActionResult Login([FromBody] UserLoginForm form)
        //{
        //    var user = ValidateUser(form.Email, form.MDP);
        //    if (user == null)
        //    {
        //        return Unauthorized();
        //    }

        //    var token = GenerateJwtToken(user);
        //    return Ok(new { Token = token });
        //}

        //private string GenerateJwtToken(BLL.User user)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //    var claims = new[]
        //    {
        //    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
        //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //};

        //    var token = new JwtSecurityToken(
        //        issuer: _configuration["Jwt:Issuer"],
        //        audience: _configuration["Jwt:Audience"],
        //        claims: claims,
        //        expires: DateTime.Now.AddMinutes(30),
        //        signingCredentials: credentials);

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}

        //private BLL.User ValidateUser(string email, string password)
        //{
        //    return new BLL.User(email, password);
        //}
    }
}
