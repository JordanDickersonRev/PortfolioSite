namespace PortfiloSite.Contacts.Project
{
    public interface IProjectAppService
    {
        Task<List<ProjectDto>> GetProjectsAsync();
    }
}
