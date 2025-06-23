using Microsoft.AspNetCore.Identity;

namespace PortfolioManager.Api.Entities
{
    public class UserTechStacks
    {
        public int Recid { get; set; }
        public string TechPageQuote { get; set; }
        public string TechDescription { get; set; }
        public string TechStackNames { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
