namespace PortfolioSite.Contacts.Experience
{
    public interface IExperienceAppService
    {
        Task<List<ExperienceDto>> GetWorkExperienceAsync();
    }
}
