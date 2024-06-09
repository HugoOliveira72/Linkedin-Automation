using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class JobDetailsSection : JobPage
    {
        private IPage _page;
        public IElementHandle? _supDivElement;
        public IElementHandle? _subscribeButton;
        public IElementHandle? _continueButton;
        public IElementHandle? _saveButton;
        public IElementHandle? _feedbackMessage;
        public string? _appliedAlready;
        public IElementHandle? _jobAlreadySaved;
        public IElementHandle? _advanceButton;
        public IElementHandle? _sendJobApplicationButton;
        public IElementHandle? _closeButton;
        public IElementHandle? _reviewButton;

        public JobDetailsSection(IPage page) : base(page)
        {
            _page = page;
        }

        public static async Task<JobDetailsSection> BuildAsync(IPage page, double securityTime = 0.5)
        {
            JobDetailsSection obj = new JobDetailsSection(page);
            await obj.InicializateAsync(securityTime);
            return obj;
        }

        private async Task InicializateAsync(double securityTime)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _supDivElement = await _page.QuerySelectorAsync("div[class*='jobs-unified-top-card']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _subscribeButton = await _supDivElement!.QuerySelectorAsync("button:has-text('Candidatura simplificada')");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _continueButton = await _supDivElement.QuerySelectorAsync("button[aria-label*='Continuar candidatura']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _saveButton = await _supDivElement.QuerySelectorAsync("button[class*='jobs-save-button']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _feedbackMessage = await _supDivElement.QuerySelectorAsync("span[class='artdeco-inline-feedback__message']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _appliedAlready = await _feedbackMessage!.TextContentAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _jobAlreadySaved = await _saveButton!.QuerySelectorAsync("span:has-text('Salvos')");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _advanceButton = await _page.QuerySelectorAsync("button[aria-label='Avançar para próxima etapa']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _sendJobApplicationButton = await _page.QuerySelectorAsync("button:has-text('Enviar candidatura')");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _closeButton = await _page.QuerySelectorAsync("button[aria-label='Fechar']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _reviewButton = await _page.QuerySelectorAsync("span:has-text('Revisar')");
        }

        public async Task<bool> CheckSubscribedStatus()
        {
            return _appliedAlready!.Contains("Candidatou-se");
        }

        public async Task SendJobApplicationAndClosePage(double securityTime = 0.5)
        {
            await _sendJobApplicationButton.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _closeButton.ClickAsync();
        }
    }

}
