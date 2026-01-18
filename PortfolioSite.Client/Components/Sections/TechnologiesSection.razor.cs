using PortfolioSite.Contacts.Technology;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class TechnologiesSection
    {
        private List<TechnologyDto> _techStack = new List<TechnologyDto>();
        private List<TechnologyDto> _otherTechnologies = new List<TechnologyDto>();
        private string _headerDescription = "";

        protected override async Task OnInitializedAsync()
        {
            _techStack = await TechAppService.GetTechStackAsync();
            _otherTechnologies = await TechAppService.GetTechnologiesAsync();
            _headerDescription = await TechAppService.GetHeaderDescriptionAsync();
            await base.OnInitializedAsync();
        }
    }
}
