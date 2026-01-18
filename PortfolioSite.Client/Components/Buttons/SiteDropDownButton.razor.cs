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

        private string _dropdownClassName = "dropdown";
        private string _siteButtonClassName = "siteButton";
        private bool _showDropDownItems = false;

        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrEmpty(ToggleButtonText))
            {
                _siteButtonClassName = "siteButton2";
            }
            if(FloatRight)
            {
                _dropdownClassName = "dropdownFloatRight";
            }
            await base.OnInitializedAsync();
        }

        private void DropDownToggleClicked()
        {
            if (_showDropDownItems)
                _showDropDownItems = false;
            else
                _showDropDownItems = true;
        }

        private void HideDropDownItems()
        {
            _showDropDownItems = false;
        }
    }
}
