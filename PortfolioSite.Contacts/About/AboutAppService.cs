namespace PortfolioSite.Contacts.About
{
    public class AboutAppService : IAboutAppService
    {
        public Task<AboutMeDto> GetAboutMeInformationAsync()
        {
            AboutMeDto aboutMe = new AboutMeDto();
            aboutMe.Paragraph = "I've been a software developer since 2023, specializing in web development. I have a strong foundation in .Net using ASP.NET Core, Blazor, C# and a multitude of different technologies. I'm eager to contribute to a challenging and innovative environment, where I can leverage my strong technical skills, and ability to learn quickly with new technologies. I have a passion for delivering high-quality software. I love this career because I enjoy learning and collaborating in team environments where I can learn from others.";
            return Task.FromResult(aboutMe);
        }
    }
}
