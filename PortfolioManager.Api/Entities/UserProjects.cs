using Microsoft.AspNetCore.Identity;

namespace PortfolioManager.Api.Entities
{
    public class UserProjects
    {
        public int Recid { get; set; }
        public string? ProjectPageQuote { get; set; }
        public string? ProjectTitle { get; set; }
        public string? ProjectDetails { get; set; }
        public string? TechStacks { get; set; }
        public string? Features { get; set; }
        public string? Challenges { get; set; }
        public string? Learnings { get; set; }
        public string? ProjectUrl { get; set; }
        public int ProjectTabId { get; set; }
        public ProjectTab ProjectTab { get; set; }
    }
}
