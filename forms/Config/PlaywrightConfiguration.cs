using forms.Model;
using forms.Models.Interfaces;
using Microsoft.Playwright;
using Org.BouncyCastle.Tsp;

namespace Linkedin_Automation.Config
{
    public class PlaywrightConfiguration
    {
        public IBrowserContext? BrowserContext { get; set; }

        private IConfigRepository _configRepository;

        public PlaywrightConfiguration()
        {
        }

        public PlaywrightConfiguration(IConfigRepository configRepository)
        {
            _configRepository = configRepository;
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

            int[] resolution = await GetResolution();

            var context = await browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = new ViewportSize { Width = resolution.First(), Height = resolution.Last() }
            });

            return new PlaywrightConfiguration(context);
        }

        private async Task<int[]> GetResolution()
        {
            var a = _configRepository.GetResolutionFilePath();
            ConfigurationModel configModel = _configRepository.ReadAndConvertMessagepackFileToObject<ConfigurationModel>(a);

            string? resolution;
            //Tela cheia
            if (configModel.ScreenType == "Tela cheia")
            {
                ///Pegar resolução de tela
                string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
                string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

                resolution = screenWidth + "x" + screenHeight;
            }
            else ///Janela
                resolution = configModel.Resolution;

            string[] pieces = resolution!.Split('x');
            int[] numbers = Array.ConvertAll(pieces, int.Parse);
            return numbers;
        }
    }
}
