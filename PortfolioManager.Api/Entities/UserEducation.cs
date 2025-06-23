namespace PortfolioManager.Api.Entities
{
    public class UserEducation
    {
        public int Recid { get; set; }
        public string DegreeName { get; set; }
        public string CollegeName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string? EducationDetails { get; set; }
        public bool? IsCurrent { get; set; }
        public int EducationTabId { get; set; }
        public EducationTab EducationTab { get; set; }
    }
}
