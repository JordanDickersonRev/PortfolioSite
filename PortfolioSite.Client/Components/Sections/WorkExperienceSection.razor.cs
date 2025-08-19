using PortfolioSite.Contacts.Experience;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class WorkExperienceSection
    {
        private List<ExperienceDto> WorkExperience = new List<ExperienceDto>();
        private bool _IsDialogShown { get; set; } = false;
        private string _DialogTitle { get; set; } = "";
        private string _DialogDescription { get; set; } = "";

        protected override async Task OnInitializedAsync()
        {
            WorkExperience = await ExperienceAppService.GetWorkExperienceAsync();
            await base.OnInitializedAsync();
        }

        private string FormatDate(DateOnly date)
        {
            return date.ToString("MM/dd/yyyy");
        }

        private string FormatEndDate(ExperienceDto job)
        {
            return job.IsCurrentJob ? "Current" : FormatDate(job.EndDate);
        }

        private void ShowDialog(ExperienceDto job)
        {
            _DialogTitle = job.CompanyName;
            _DialogDescription = job.JobDescription;
            _IsDialogShown = true;
        }
    }
}