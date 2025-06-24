using FluentResults;
using PortfolioManager.Api.DTOs.Auth;

namespace PortfolioManager.Api.Services.Auth
{
    public interface IAuthService
    {
        Task<Result<LoginResponseDto>> Login(LoginRequestDto request);
    }
}
