namespace PortfolioSite.Contacts.Experience
{
    public class ExperienceDto
    {
        public required string CompanyName { get; set; }
        public required string JobTitle { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public bool IsCurrentJob { get; set; }
        public required List<JobResponsibility> JobResponsibilities { get; set; }
    }
}
