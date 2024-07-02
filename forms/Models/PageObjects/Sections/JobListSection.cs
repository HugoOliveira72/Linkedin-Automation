using forms.Models.PageObjects.Base;
using forms.Utilities.Messages;
using forms.Views.Interfaces;
using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class JobListSection : BasePage
    {
        //Properties
        private IPage _page;
        private IHomeView _homeView;
        private IReadOnlyList<IElementHandle?> _ulElementsJobs;
        private IElementHandle? _nextPageButton;
        private OutputStringPatterns stringPatterns = new();

        public JobListSection(IPage page, IHomeView homeView) : base(page)
        {
            _page = page;
            _homeView = homeView;
        }

        public static async Task<JobListSection> BuildAsync(IPage page, IHomeView homeView, int currentPageNumber, double securityTime = 0.5)
        {
            JobListSection obj = new JobListSection(page, homeView);
            await obj.InicializateAsync(securityTime, currentPageNumber);
            return obj;
        }

        private async Task InicializateAsync(double securityTime, int currentPageNumber)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await ReloadUlElements();
            _nextPageButton = await LoadElementAsync($"button[aria-label='Página {currentPageNumber + 1}']");
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
                _homeView.RichtxtBox +=
                    $"{stringPatterns.linePattern()}\n" +
                    $"!{ExceptionMessages.PageLimitExceeded}!\n" +
                    $"{stringPatterns.linePattern()}\n";
                await Task.Delay(TimeSpan.FromSeconds(0.1));
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
