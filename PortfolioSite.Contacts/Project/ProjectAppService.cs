
namespace PortfiloSite.Contacts.Project
{
    public class ProjectAppService : IProjectAppService
    {
        public Task<List<ProjectDto>> GetProjectsAsync()
        {
            List<ProjectDto> projects = new List<ProjectDto>([
                new ProjectDto() 
                {
                    Id = 1, 
                    Name = $"{DateTime.UtcNow.Year} Portfolio Site", 
                    ShortDescription = "This portfolio site", 
                    Description="Welcome to my portfolio. This is a showcase of my projects and skills as a web developer. This website is a demonstration of my ability to build modern web applications using ASP.NET Core, Blazor, JavaScript, HTML and CSS.", 
                    IsFinished = true,
                },
                new ProjectDto()
                {
                    Id = 2,
                    Name = "First Video Game",
                    ShortDescription = "Work in progress",
                    Description="",
                    IsFinished = false,
                },
            ]);
            return Task.FromResult(projects);
        }
    }
}
