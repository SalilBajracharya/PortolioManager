namespace PortfolioManager.Api.Entities
{
    public class UserExperience
    {
        public int Recid { get; set; }
        public string JobTitle { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CompanyName { get; set; }
        public string? JobDescription { get; set; }
        public int ExperienceTabId { get; set; }
        public ExperienceTab ExperienceTab { get; set; }
        public bool CurrentJobTF { get; set; }
    }
}
