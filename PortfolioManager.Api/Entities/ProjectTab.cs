using Microsoft.AspNetCore.Identity;

namespace PortfolioManager.Api.Entities
{
    public class ProjectTab
    {
        public int Recid { get; set; }
        public string? ProjectPageQuote { get; set; }
        public string? ProjectIntro { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
