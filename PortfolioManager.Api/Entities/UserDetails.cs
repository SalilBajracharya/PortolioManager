using Microsoft.AspNetCore.Identity;

namespace PortfolioManager.Api.Entities
{
    public class UserDetails
    {
        public int Recid { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string DOB { get; set; }
        public string? JobTitle { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string? MobileNo { get; set; }
        public string? ShortIntro { get; set; }
        public string? LongIntro { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

    }
}
