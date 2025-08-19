namespace PortfolioSite.Contacts.Experience
{
    public class ExperienceDto
    {
        public string CompanyName { get; set; } = "";
        public string ShortDescription { get; set; } = "";
        public string JobDescription { get; set; } = "";
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public bool IsCurrentJob { get; set; }
    }
}
