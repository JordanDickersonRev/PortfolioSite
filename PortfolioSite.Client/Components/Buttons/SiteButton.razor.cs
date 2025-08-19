using Microsoft.AspNetCore.Components;

namespace PortfolioSite.Client.Components.Buttons
{
    public partial class SiteButton
    {
        [Parameter]
        public string Text { get; set; } = "";

        [Parameter]
        public string IconClass { get; set; } = "";

        [Parameter]
        public string SiteButtonClass { get; set; } = "siteButton";

        [Parameter]
        public EventCallback OnSiteButtonClicked { get; set; }

        [Parameter]
        public bool ShowCaretIcon { get; set; } = false;

        [Parameter]
        public bool Disabled { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrEmpty(Text))
            {
                SiteButtonClass = "siteButton2";
            }
            await base.OnInitializedAsync();
        }
    }
}
