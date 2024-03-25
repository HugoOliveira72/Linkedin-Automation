using Microsoft.Playwright;

namespace Linkedin_Automation.Config
{
    public class PlaywrightConfiguration
    {
        public IBrowserContext? BrowserContext { get; set; }

        public PlaywrightConfiguration()
        {
        }

        public PlaywrightConfiguration(IBrowserContext browserContext)
        {
            this.BrowserContext = browserContext;
        }


        public async Task<PlaywrightConfiguration> launchSettingsAsync()
        {
            // CONFIGURAÇÃO DE BROWSER
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                Channel = "chrome",
            });

            var context = await browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = null
            });

            return new PlaywrightConfiguration(context);
        }
    }
}
