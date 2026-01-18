using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.JSInterop;
using PortfiloSite.Contacts.Project;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class ProjectsSection : IAsyncDisposable
    {
        private IJSObjectReference? _module;
        private PaginationState _pagination = new PaginationState { ItemsPerPage = 5 };
        private bool _dialogIsShown = false;
        private string _dialogTitle = "";
        private string _dialogDescription = "";
        private async ValueTask<GridItemsProviderResult<ProjectDto>> GetProjects(GridItemsProviderRequest<ProjectDto> request)
        {
            List<ProjectDto> projects = await ProjectAppService.GetProjectsAsync();
            return new GridItemsProviderResult<ProjectDto>
            {
                Items = projects,
                TotalItemCount = projects.Count,
            };
        }

        private void ShowDialog(ProjectDto project)
        {
            _dialogTitle = project.Name!;
            _dialogDescription = project.Description!;
            _dialogIsShown = true;
        }

        private void HideDialog()
        {
            _dialogIsShown = false;
        }

        private async Task<Task> OpenSourceCodeInTab(ProjectDto project)
        {
            if (!string.IsNullOrEmpty(project.Url))
            {
                _module = await JS.InvokeAsync<IJSObjectReference>("import",
                    "./Components/Sections/ProjectsSection.razor.js");
                await _module.InvokeVoidAsync("openSourceCodeInTab", project.Url);
            }

            return Task.CompletedTask;
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
