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
                    JobTitle = ".NET Full Stack Developer",
                    StartDate = new DateOnly(2023, 3, 1),
                    IsCurrentJob = true,
                    JobResponsibilities = new List<JobResponsibility>() {
                        new JobResponsibility() {Description = "Proactively addressed defects across web, and mobile applications to strengthen software stability which resulted in 30% less support tickets."},
                        new JobResponsibility() {Description = "Developed and maintained multiple endpoints in rest APIs to supply data for user interfaces."},
                        new JobResponsibility() {Description = "Delivered client-requested features to enhance the functionality of software by designing and developing responsive user interfaces for web, and mobile applications."},
                        new JobResponsibility() {Description = "Enhanced the speed of search results for web and mobile applications by refactoring server side logic, and implementing best practices when mapping SQL to LINQ."},
                        new JobResponsibility() {Description = "Conducted comprehensive code reviews which resulted in marked gains in code quality by identifying possible memory leaks, giving advice on framework best practices, and actively testing team members work to improve shipping quality."},
                        new JobResponsibility() {Description = "Helped the team quickly develop a proof-of-concept software in one month by developing backend services, and API endpoints to supply data for user interfaces."},
                        new JobResponsibility() {Description = "Optimized stored procedures by pulling query plans from customer sites, and refactoring SQL scripts based on the query plans to speed up data intensive operations."},
                        new JobResponsibility() {Description = "Proactively engaged in team meetings to understand upcoming projects, get feedback from other developers on current tasks, and provide suggestions to developers on their tasks."},
                        new JobResponsibility() {Description = "Consistently takes time to improve skills by staying up to date with software technologies, and staying receptive to other developers suggestions."},
                        new JobResponsibility() {Description = "Consistently finishes all tasks for sprints in Jira to help the team meet deadlines for software releases."},
                    }
                },

                new ExperienceDto()
                {
                    CompanyName = "Revature",
                    JobTitle = ".NET Full Stack Developer(Trainee)",
                    StartDate = new DateOnly(2022, 10, 1),
                    EndDate = new DateOnly(2022, 12, 31),
                    IsCurrentJob = false,
                    JobResponsibilities = new List<JobResponsibility>() {
                        new JobResponsibility() {Description = "Actively studied and participated in training to grow skills in the .NET framework." },
                        new JobResponsibility() {Description = "Helped build a concept enterprise application with other developers in training by creating multiple API endpoints in ASP.NET Core, and developed responsive web pages using React." },
                        new JobResponsibility() {Description = "Passed weekly technical interviews to test technical proficiency which prepaired me for client interviews by the end of training." },
                        new JobResponsibility() {Description = "Consistently took time to improve skills by proactively reading software documentation to learn concepts quickly." },
                        new JobResponsibility() {Description = "Finished daily assignments and weekly projects in order to complete all my assigned task each week." },
                    }
                }
            ]);

            return Task.FromResult(workExperience);
        }
    }
}
