using Microsoft.AspNetCore.Components;

namespace PortfolioSite.Client.Components.Buttons
{
    public partial class SiteAnchor
    {
        [Parameter]
        public bool OpenNewTab { get; set; }
        [Parameter]
        public string Text { get; set; } = "";
        [Parameter]
        public string Url { get; set; } = "";
        [Parameter]
        public string IconClass { get; set; } = "";

        private Task<string> GetTargetValue()
        {
            string result = "_self";
            if (OpenNewTab)
                result = "_blank";

            return Task.FromResult(result);
        }
    }
}
