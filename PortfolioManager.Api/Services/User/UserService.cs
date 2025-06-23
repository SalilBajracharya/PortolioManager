using Microsoft.AspNetCore.Identity;
using PortfolioManager.Api.DTOs.User;
using PortfolioManager.Api.Entities;
using PortfolioManager.Api.Persistence;

namespace PortfolioManager.Api.Services.User
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _ctx;
        private readonly UserManager<IdentityUser> _userManager;
        public UserService(ApplicationDbContext ctx, UserManager<IdentityUser> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }
        public async Task CreateUserAsync(RegisterUserDto request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.UserName);

            if (existingUser != null)
            { 
                throw new BadHttpRequestException("User with this username already exists.");
            }

            var user = new IdentityUser
            {
                UserName = request.UserName,
                Email = request.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            var userDetails = new UserDetails
            {
                FullName = request.FullName,
                UserName = user.UserName,
                Address = request.Address,
                DOB = request.DOB.ToString("yyyy-MM-dd"),
                MobileNo = request.MobileNo,
                UserId = user.Id,
                Email = user.Email
            };

            await _ctx.UserDetails.AddAsync(userDetails);
            await _ctx.SaveChangesAsync();
        }
    }
}
