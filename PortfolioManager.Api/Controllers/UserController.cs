using Microsoft.AspNetCore.Mvc;
using PortfolioManager.Api.DTOs.User;
using PortfolioManager.Api.Services.User;

namespace PortfolioManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create-user")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterUserDto request)
        {
            await _userService.CreateUserAsync(request);
            return Ok();
        }
    }
}
