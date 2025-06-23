using PortfolioManager.Api.DTOs.User;

namespace PortfolioManager.Api.Services.User
{
    public interface IUserService
    {
        Task CreateUserAsync(RegisterUserDto user);
    }
}
