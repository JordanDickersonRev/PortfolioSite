namespace PortfolioSite.Contacts.About
{
    public class AboutAppService : IAboutAppService
    {
        public Task<AboutMeDto> GetAboutMeInformationAsync()
        {
            AboutMeDto aboutMe = new AboutMeDto();
            aboutMe.Paragraph = "Software Developer with 3+ years of industry experience in developing front-end and back-end technologies. Skilled in web and mobile application development, quick to adjust to new environments or tools, and takes initiative to learn. Seeking to contribute to a fast paced, and high trust environment.";
            return Task.FromResult(aboutMe);
        }
    }
}
