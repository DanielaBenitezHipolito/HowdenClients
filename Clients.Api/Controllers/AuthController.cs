using Microsoft.AspNetCore.Mvc;
using Clients.Application.Interfaces;
using Clients.Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clients.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequestDTO request)
        {
            if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest(new { message = "Usuario y contraseña son obligatorios" });
            }
            var result = _authService.Login(request);
            if (result == null)
            {
                return Unauthorized(new { message = "Credenciales inválidas" });
            }
            return Ok(result);
        }
    }
}
