namespace PortfolioSite.Contacts.Experience
{
    public class ExperienceAppService : IExperienceAppService
    {
        public Task<List<ExperienceDto>> GetWorkExperienceAsync()
        {
            List<ExperienceDto> workExperience = new List<ExperienceDto>([
                new ExperienceDto()
                {
                    CompanyName = "ARC Healthcare Technologies",
                    ShortDescription = "Full Stack Developer",
                    JobDescription = "My responsibilities included developing and implementing software with creative freedom while following business logic. To ensure this, I had to develop front-end and back-end software, using frameworks or component libraries such as Blazor, Blazorise, Telerik, ABP, ASP.NET Core, ASP.NET, MVC and Bootstrap. To use those technologies, I was required to be proficient in C#, TSQL, HTML, JavaScript, jQuery, and CSS. I was able to add value to the team by having strong problem-solving skills, collaborating with other team members, optimizing applications for performance and security, reviewing/testing pull request, and staying current with technologies.",
                    StartDate = new DateOnly(2023, 3, 1),
                    IsCurrentJob = true,
                }
            ]);

            return Task.FromResult(workExperience);
        }
    }
}
