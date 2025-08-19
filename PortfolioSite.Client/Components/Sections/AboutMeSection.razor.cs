using PortfolioSite.Contacts.About;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class AboutMeSection
    {
        private AboutMeDto AboutMe { get; set; } = new AboutMeDto();

        protected override async Task OnInitializedAsync()
        {
            AboutMe = await AboutAppService.GetAboutMeInformationAsync();
            await base.OnInitializedAsync();
        }
    }
}
