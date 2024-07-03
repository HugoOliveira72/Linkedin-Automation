using forms.Models.PageObjects.Base;
using Microsoft.Playwright;

namespace forms.Models.PageObjects
{
    public class JobPage : BasePage
    {
        public IPage _page;
        private ILocator? _inputSearchJob;
        private CancellationToken _token;

        public JobPage(IPage page, CancellationToken token) : base(page,token)
        {
            _page = page;
            _token = token;
        }

        public static async Task<JobPage> BuildAsync(IPage page, CancellationToken token, double securityTime = 0.5)
        {
            JobPage obj = new JobPage(page, token);
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
            await WaitForElementAndHandleExceptionAsync(
                _page, "input[title*='Pesquisar cargo, competência ou empresa']",
                "Elemento encontrado",
                "Erro ao encontrar elemento"
            );
        }
    }
}
