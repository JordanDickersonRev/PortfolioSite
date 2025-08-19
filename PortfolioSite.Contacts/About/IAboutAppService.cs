namespace PortfolioSite.Contacts.About
{
    public interface IAboutAppService
    {
        Task<AboutMeDto> GetAboutMeInformationAsync();
    }
}
