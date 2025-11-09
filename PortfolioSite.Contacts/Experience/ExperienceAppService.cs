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
                    JobDescription = "I'm responsible for developing and implementing software with creative freedom while following business logic. To ensure this, I have to develop front-end and back-end software, using frameworks or component libraries such as Blazor, Blazorise, Telerik, ABP, ASP.NET Core, ASP.NET, MVC and Bootstrap. To use those technologies, I'm required to be proficient in C#, TSQL, HTML, JavaScript, JQuery, and CSS. I'm able to add value to the team by having strong problem-solving skills, collaborating with other team members, optimizing applications for performance and security, reviewing/testing pull request, and staying current with technologies.",
                    StartDate = new DateOnly(2023, 3, 1),
                    IsCurrentJob = true,
                },

                new ExperienceDto()
                {
                    CompanyName = "Revature",
                    ShortDescription = "Full Stack Developer(Trainee)",
                    JobDescription = "The responsibilities included actively engaging in a fast-paced environment by quickly learning new technologies, collaborate with trainers and peers to build real-world projects, and participate in interview preparation to prepare for interviews with Revature clients. To meet these requirements, I had a strong desire to learn, strong problem-solving skills, a collaborative attitude, and was able to adapt quickly to new technologies by taking initiative to continuously improve my skills.",
                    StartDate = new DateOnly(2022, 10, 1),
                    EndDate = new DateOnly(2022, 12, 31),
                    IsCurrentJob = false
                }
            ]);

            return Task.FromResult(workExperience);
        }
    }
}
