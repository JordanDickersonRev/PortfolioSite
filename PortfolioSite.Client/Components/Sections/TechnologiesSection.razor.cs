using PortfolioSite.Contacts.Technology;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class TechnologiesSection
    {
        private List<TechnologyDto> TechStack { get; set; } = new List<TechnologyDto>();
        private List<TechnologyDto> OtherTechnologies { get; set; } = new List<TechnologyDto>();
        private string HeaderDescription { get; set; } = "";

        protected override async Task OnInitializedAsync()
        {
            TechStack = await TechAppService.GetTechStackAsync();
            OtherTechnologies = await TechAppService.GetTechnologiesAsync();
            HeaderDescription = await TechAppService.GetHeaderDescriptionAsync();
            await base.OnInitializedAsync();
        }
    }
}
