using Microsoft.AspNetCore.Components;

namespace PortfolioSite.Client.Components.Dialogs
{
    public partial class SiteDialog
    {
        [Parameter]
        public bool DialogIsShown { get; set; } = false;
        [Parameter]
        public EventCallback<bool> DialogIsShownChanged { get; set; }
        [Parameter]
        public RenderFragment? DialogHeader { get; set; }
        [Parameter]
        public RenderFragment? DialogContent { get; set; }
        [Parameter]
        public RenderFragment? DialogFooter { get; set; }
    }
}
