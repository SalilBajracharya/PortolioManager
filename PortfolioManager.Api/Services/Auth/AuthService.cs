using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PortfolioManager.Api.Common.Errors;
using PortfolioManager.Api.Common.Models;
using PortfolioManager.Api.DTOs.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PortfolioManager.Api.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtSettings _jwtSettings;
        public AuthService(UserManager<IdentityUser> userManager, IOptions<JwtSettings> jwtSettings)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
        }
        public async Task<Result<LoginResponseDto>> Login(LoginRequestDto request)
        {
            var user = await _userManager.FindByNameAsync(request.Username);
            if (user is null)
                return Result.Fail<LoginResponseDto>("Username not found");

            if(!await _userManager.CheckPasswordAsync(user, request.Password))
                return Result.Fail<LoginResponseDto>("Invalid password");

            var loginResponseDto = new LoginResponseDto
            {
                accessToken = GenerateToken(user),
            };

            return loginResponseDto;
        }

        public string GenerateToken(IdentityUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationMinutes),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
