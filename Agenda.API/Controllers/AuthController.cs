using Agenda.Application.DTOs.Auth;
using Agenda.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        private readonly IAuthService _authService = authService;

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {            
            var result = await _authService.RegisterAsync(request);
            return Ok(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var result = await _authService.LoginAync(request);
            return Ok(result);
        }
    }
}