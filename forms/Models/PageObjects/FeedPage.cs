using forms.Models.PageObjects.Base;
using Microsoft.Playwright;

namespace forms.Models.PageObjects
{
    public class FeedPage : BasePage
    {
        private IPage _page;
        private IElementHandle? _navBar;
        public IElementHandle? _jobSpan;

        public FeedPage(IPage page, CancellationToken token) : base(page, token)
        {
            _page = page;
        }

        public static async Task<FeedPage> BuildAsync(IPage page, CancellationToken token, double securityTime = 0.5)
        {
            FeedPage obj = new FeedPage(page, token);
            await obj.InicializateAsync(securityTime);
            return obj;
        }

        private async Task InicializateAsync(double securityTime)
        {
            _navBar = await LoadElementAsync("nav[aria-label=\"Navegação principal\"]");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _jobSpan = await _navBar!.QuerySelectorAsync("span:has-text('Vagas')");
        }

    }
}
