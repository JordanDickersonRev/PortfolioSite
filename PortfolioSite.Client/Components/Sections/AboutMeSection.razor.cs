using PortfolioSite.Contacts.About;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class AboutMeSection
    {
        private AboutMeDto _aboutMe  = new AboutMeDto();

        protected override async Task OnInitializedAsync()
        {
            _aboutMe = await AboutAppService.GetAboutMeInformationAsync();
            await base.OnInitializedAsync();
        }
    }
}
