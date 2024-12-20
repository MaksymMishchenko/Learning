using Application.Services.Identity;
using Application.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Application.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly JwtConfiguration _config;

        public AuthController(IAuthService authService, IOptions<JwtConfiguration> config)
        {
            _authService = authService;
            _config = config.Value;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUser credentials)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("Login credential");
            }
            if (await _authService.Login(credentials))
            {
                return Ok(new
                {
                    token = await _authService.GenerateTokenString(credentials.UserName, _config)
                });
            }
            return BadRequest();
        }
    }
}
