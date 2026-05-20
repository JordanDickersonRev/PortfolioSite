using PortfolioSite.Contacts.Experience;

namespace PortfolioSite.Client.Components.Sections
{
    public partial class WorkExperienceSection
    {
        private List<ExperienceDto> _workExperience = new List<ExperienceDto>();
        private bool _isDialogShown = false;
        private string _dialogTitle = "";
        private List<JobResponsibility> _dialogJobResponsibilities = new List<JobResponsibility>();

        protected override async Task OnInitializedAsync()
        {
            _workExperience = await ExperienceAppService.GetWorkExperienceAsync();
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
            _dialogTitle = job.CompanyName;
            _dialogJobResponsibilities = job.JobResponsibilities;
            _isDialogShown = true;
        }

        private void HideDialog()
        {
            _isDialogShown = false;
            _dialogTitle = "";
        }
    }
}