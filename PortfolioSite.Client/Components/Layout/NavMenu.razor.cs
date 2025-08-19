using Microsoft.JSInterop;

namespace PortfolioSite.Client.Components.Layout
{
    public partial class NavMenu : IAsyncDisposable
    {
        private IJSObjectReference? _module;
        private string _dark = "dark";
        private string _light = "light";
        private string _system = "system";
        private string _currentThemeIcon { get; set; } = "";
        private string _introductionUrl = "#introductionSection";
        private string _aboutMeUrl = "#aboutMeSection";
        private string _technologiesUrl = "#technologiesSection";
        private string _workExperienceUrl = "#workExperienceSection";
        private string _projectsUrl = "#projectsSection";
        protected override async Task OnInitializedAsync()
        {
            _module = await _jS.InvokeAsync<IJSObjectReference>("import",
                    "./Components/Layout/NavMenu.razor.js");
            _currentThemeIcon = await _module.InvokeAsync<string>("getTheme");
            await SetThemeAsync(_currentThemeIcon);
            await base.OnInitializedAsync();
        }

        private async Task SetThemeAsync(string preferredTheme)
        {
            _module = await _jS.InvokeAsync<IJSObjectReference>("import",
                    "./Components/Layout/NavMenu.razor.js");
            preferredTheme = await _module.InvokeAsync<string>("setTheme", preferredTheme);
            _currentThemeIcon = await SetCurrentThemeIcon(preferredTheme);
        }

        private Task<string> SetCurrentThemeIcon(string preferredTheme)
        {
            string result = "";
            switch (preferredTheme)
            {
                case "dark":
                   result = "fas fa-moon";
                    break;
                case "light":
                    result = "fas fa-sun";
                    break;
                default:
                    result = "fas fa-desktop";
                    break;
            }
            return Task.FromResult(result);
        }

        private void NavigateToUrl(string url)
        {
            NavigationManager.NavigateTo(url);
        }

        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            if (_module is not null)
            {
                try
                {
                    await _module.DisposeAsync();
                }
                catch (JSDisconnectedException)
                {
                }
            }
        }
    }
}
