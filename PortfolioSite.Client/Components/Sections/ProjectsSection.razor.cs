using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.JSInterop;
using PortfiloSite.Contacts.Project;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class ProjectsSection : IAsyncDisposable
    {
        private IJSObjectReference? _Module;
        private PaginationState Pagination = new PaginationState { ItemsPerPage = 5 };
        private bool _DialogIsShown { get; set; } = false;
        private string _DialogTitle { get; set; } = "";
        private string _DialogDescription { get; set; } = "";
        private async ValueTask<GridItemsProviderResult<ProjectDto>> GetProjects(GridItemsProviderRequest<ProjectDto> request)
        {
            List<ProjectDto> projects = await ProjectAppService.GetProjectsAsync();
            return new GridItemsProviderResult<ProjectDto>
            {
                Items = projects,
                TotalItemCount = projects.Count,
            };
        }

        private Task ShowDialog(ProjectDto project)
        {
            _DialogTitle = project.Name!;
            _DialogDescription = project.Description!;
            _DialogIsShown = true;
            return Task.CompletedTask;
        }
        
        private async Task<Task> OpenSourceCodeInTab(ProjectDto project)
        {
            _DialogIsShown = false;
            if (!string.IsNullOrEmpty(project.Url))
            {
                _Module = await JS.InvokeAsync<IJSObjectReference>("import",
                    "./Components/Sections/ProjectsSection.razor.js");
                await _Module.InvokeVoidAsync("openSourceCodeInTab", project.Url);
            }

            return Task.CompletedTask;
        }

        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            if (_Module is not null)
            {
                try
                {
                    await _Module.DisposeAsync();
                }
                catch (JSDisconnectedException)
                {
                }
            }
        }
    }
}
