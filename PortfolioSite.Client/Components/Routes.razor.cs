using Microsoft.JSInterop;

namespace PortfolioSite.Client.Components
{
    public partial class Routes : IAsyncDisposable
    {
        private IJSObjectReference? module;

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                module = await JS.InvokeAsync<IJSObjectReference>("import",
                    "./Components/Routes.razor.js");

                await module.InvokeVoidAsync("afterWebAssemblyStarted");
            }
        }

        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            if (module is not null)
            {
                try
                {
                    await module.DisposeAsync();
                }
                catch (JSDisconnectedException)
                {
                }
            }
        }
    }
}
