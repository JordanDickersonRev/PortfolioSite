namespace PortfolioSite.Contacts.Technology
{
    public class TechAppService : ITechAppService
    {
        public Task<List<TechnologyDto>> GetTechStackAsync()
        {
            List<TechnologyDto> result = new List<TechnologyDto>([
                new TechnologyDto(){Name = "Html", IconClass = ""},
                new TechnologyDto(){Name = "Css", IconClass = ""},
                new TechnologyDto(){Name = "Javascript", IconClass = ""},
                new TechnologyDto(){Name = "C#", IconClass = ""},
                new TechnologyDto(){Name = "Asp.Net Core", IconClass = ""},
                new TechnologyDto(){Name = "Blazor", IconClass = ""},
                new TechnologyDto(){Name = "TSQL", IconClass = ""},
                new TechnologyDto(){Name = "GIT", IconClass = ""},
                new TechnologyDto(){Name = "Jira", IconClass = ""}
            ]);
            return Task.FromResult(result.OrderBy(x => x.Name).ToList());
        }

        public Task<List<TechnologyDto>> GetTechnologiesAsync()
        {
            List<TechnologyDto> result = new List<TechnologyDto>([
                new TechnologyDto(){Name = "ABP Framework", IconClass = ""},
                new TechnologyDto(){Name = "Blazorise", IconClass = ""},
                new TechnologyDto(){Name = "Asp.Net", IconClass = ""},
                new TechnologyDto(){Name = "MVC", IconClass = ""},
                new TechnologyDto(){Name = "Telerik UI", IconClass = ""},
                new TechnologyDto(){Name = "Node.js", IconClass = ""},
                new TechnologyDto(){Name = "Bootstrap", IconClass = ""},
                new TechnologyDto(){Name = "React", IconClass = ""},
                new TechnologyDto(){Name = "JQuery", IconClass = ""},
                new TechnologyDto(){Name = "XAML", IconClass = ""},
                new TechnologyDto(){Name = "MAUI", IconClass = ""},
                new TechnologyDto(){Name = "Typescript", IconClass = ""},
                new TechnologyDto(){Name = "xUnit", IconClass = ""},
                new TechnologyDto(){Name = "NSubstitute", IconClass = ""},
            ]);
            return Task.FromResult(result.OrderBy(x => x.Name).ToList());
        }

        public Task<string> GetHeaderDescriptionAsync()
        {
            return Task.FromResult("Here's a list of my prefered teck stack, and a list of other technologies I've used before.");
        }
    }
}
