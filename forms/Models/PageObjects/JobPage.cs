using Microsoft.Playwright;

namespace forms.Models.PageObjects
{
    public class JobPage
    {
        IPage _page;
        IElementHandle? _searchJobDiv;
        IElementHandle? _inputSearchJob;

        public JobPage(IPage page)
        {
            _page = page;
        }

        public static async Task<JobPage> BuildAsync(IPage page, double securityTime = 0.5)
        {
            JobPage obj = new JobPage(page);
            await obj.InicializateAsync(securityTime);
            return obj;
        }

        private async Task InicializateAsync(double securityTime)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _searchJobDiv = await _page.QuerySelectorAsync("#global-nav-typeahead");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _inputSearchJob = await _searchJobDiv.QuerySelectorAsync(".search-global-typeahead__input");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
        }

        public async Task SearchJobAsync(string job, double securityTime = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _searchJobDiv.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _inputSearchJob.FillAsync(job);
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _inputSearchJob.PressAsync("Enter");
        }
    }
}
