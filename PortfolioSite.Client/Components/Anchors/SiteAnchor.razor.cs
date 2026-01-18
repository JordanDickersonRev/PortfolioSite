using Microsoft.AspNetCore.Components;

namespace PortfolioSite.Client.Components.Anchors
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
        [Parameter]
        public string DownloadFileName { get; set; } = "";

        private string GetTargetValue()
        {
            string result = "_self";
            if (OpenNewTab)
                result = "_blank";

            return result;
        }
    }
}
