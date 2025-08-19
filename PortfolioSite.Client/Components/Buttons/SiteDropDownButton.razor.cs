using Microsoft.AspNetCore.Components;

namespace PortfolioSite.Client.Components.Buttons
{
    public partial class SiteDropDownButton
    {
        [Parameter]
        public string ToggleButtonText { get; set; } = "";

        [Parameter]
        public string ToggleButtonIconClass { get; set; } = "";

        [Parameter]
        public required RenderFragment DropDownElements { get; set; }

        [Parameter]
        public bool FloatRight { get; set; } = false;

        [Parameter]
        public bool ShowCaretDownIcon { get; set; } = true;

        [Parameter]
        public bool Disabled { get; set; } = false;

        string DropdownClassName { get; set; } = "dropdown";
        string SiteButtonClassName { get; set; } = "siteButton";
        string DropDownItemsDisplayValue { get; set; } = "none";

        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrEmpty(ToggleButtonText))
            {
                SiteButtonClassName = "siteButton2";
            }
            if(FloatRight)
            {
                DropdownClassName = "dropdownFloatRight";
            }
            await base.OnInitializedAsync();
        }

        void DropDownToggleClicked()
        {
            if (DropDownItemsDisplayValue == "none")
                DropDownItemsDisplayValue = "display";
            else
                DropDownItemsDisplayValue = "none";
        }

        public void HideDropDownItems()
        {
            DropDownItemsDisplayValue = "none";
        }
    }
}
