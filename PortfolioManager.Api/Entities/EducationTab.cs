using Microsoft.AspNetCore.Identity;

namespace PortfolioManager.Api.Entities
{
    public class EducationTab
    {
        public int Recid { get; set; }
        public string EducationQuote { get; set; }
        public string EducationSummary { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
