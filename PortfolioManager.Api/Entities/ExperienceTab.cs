using Microsoft.AspNetCore.Identity;

namespace PortfolioManager.Api.Entities
{
    public class ExperienceTab
    {
        public int Recid { get; set; }
        public string? ExperienceQuote { get; set; }
        public string? ExperienceSummary { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

    }
}
