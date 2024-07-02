using forms.Utilities.Messages;
using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class JobListSection
    {
        //Properties
        private IPage _page;
        private IReadOnlyList<IElementHandle?> _ulElementsJobs;
        private IElementHandle? _nextPageButton;

        public JobListSection(IPage page)
        {
            _page = page;
        }

        public static async Task<JobListSection> BuildAsync(IPage page, int currentPageNumber, double securityTime = 0.5)
        {
            JobListSection obj = new JobListSection(page);
            await obj.InicializateAsync(securityTime, currentPageNumber);
            return obj;
        }

        private async Task InicializateAsync(double securityTime, int currentPageNumber)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await ReloadUlElements();
            _nextPageButton = await _page.QuerySelectorAsync($"button[aria-label='Página {currentPageNumber + 1}']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
        }

        public async Task ClickOnJob(int jobsCounter)
        {
            int indexJob = jobsCounter - 1;
            await _ulElementsJobs[indexJob].ClickAsync();
        }

        public async Task<bool> GoToNextPage()
        {
            if (_nextPageButton != null)
            {
                await _nextPageButton.ClickAsync();
                return true;
            }
            else
            {
                MessageBox.Show(ExceptionMessages.PageLimitExceeded, "Limite excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                return false;
            }
        }

        public async Task ReloadUlElements()
        {
            _ulElementsJobs = await _page.QuerySelectorAllAsync("li[class*='jobs-search-results__list-item']");
            setAvailableJob(_ulElementsJobs.Count());
        }

        //Attributes
        private int _availableJobs { get; set; }

        public void setAvailableJob(int availableJobs)
        {
            _availableJobs = availableJobs;
        }

        public int getAvailableJob()
        {
            return _availableJobs;
        }
    }

}
