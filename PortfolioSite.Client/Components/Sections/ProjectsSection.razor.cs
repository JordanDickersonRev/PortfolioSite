using Microsoft.AspNetCore.Components.QuickGrid;
using PortfiloSite.Contacts.Project;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class ProjectsSection
    {
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
        
        private Task NavigateToUrl(ProjectDto project)
        {
            if(!string.IsNullOrEmpty(project.Url))
                NavManager.NavigateTo(project.Url);
            return Task.CompletedTask;
        }
    }
}
