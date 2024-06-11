using forms.Utilities;
using Microsoft.Playwright;

namespace forms.Models.PageObjects
{
    public class JobPage
    {
        public IPage _page;
        private ILocator? _inputSearchJob;
        private PlaywrightUtilities playwrightUtilities = new();

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
            await VerifyInicialElement();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _inputSearchJob = _page.GetByRole(AriaRole.Combobox, new() { Name = "Pesquisar cargo, competência" });
        }

        public async Task SearchJobAsync(string job, double securityTime = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _inputSearchJob.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _inputSearchJob.FillAsync(job);
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _inputSearchJob.PressAsync("Enter");
        }

        private async Task VerifyInicialElement()
        {
            await playwrightUtilities.WaitForElementAndHandleExceptionAsync(
                _page, "input[title*='Pesquisar cargo, competência ou empresa']",
                "Elemento encontrado",
                "Erro ao encontrar elemento"
            );
        }
    }
}
