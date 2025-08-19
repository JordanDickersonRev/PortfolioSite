namespace PortfolioSite.Contacts.Technology
{
    public interface ITechAppService
    {
        Task<List<TechnologyDto>> GetTechStackAsync();
        Task<List<TechnologyDto>> GetTechnologiesAsync();
        Task<string> GetHeaderDescriptionAsync();
    }
}
