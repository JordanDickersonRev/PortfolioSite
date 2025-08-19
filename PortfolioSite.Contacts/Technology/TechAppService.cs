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
            ]);
            return Task.FromResult(result);
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
            ]);
            return Task.FromResult(result);
        }

        public Task<string> GetHeaderDescriptionAsync()
        {
            return Task.FromResult("Here's a list of my prefered teck stack, and a list of other technologies I've used before.");
        }
    }
}
