using Microsoft.Playwright;

namespace forms.Utilities
{
    public class PlaywrightUtilities
    {
        public async Task QuerySelectorAndClickAsync(IPage page, string querySelector, double securityTimePause = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTimePause));
            var closeButton = await page.QuerySelectorAsync(querySelector);
            await Task.Delay(TimeSpan.FromSeconds(securityTimePause));
            await closeButton!.ClickAsync();
        }
    }
}
