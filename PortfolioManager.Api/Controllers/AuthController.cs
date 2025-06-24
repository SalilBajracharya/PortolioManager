using FluentResults.Extensions.AspNetCore;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using PortfolioManager.Api.DTOs.Auth;
using PortfolioManager.Api.Services.Auth;

namespace PortfolioManager.Api.Controllers
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

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginRequestDto request)
        {
            var result = await _authService.Login(request);
            return result.ToActionResult();
        }
    }
}
