using forms.Models.PageObjects.Base;
using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class JobDetailsSection : BasePage
    {
        private IPage _page;
        public IElementHandle? _supDivElement;
        public IElementHandle? _subscribeButton;
        public IElementHandle? _continueButton;
        public IElementHandle? _saveButton;
        public IElementHandle? _feedbackMessage;
        public IElementHandle? _jobAlreadySaved;

        public JobDetailsSection(IPage page, CancellationToken token) : base(page, token)
        {
            _page = page;
        }

        public static async Task<JobDetailsSection> BuildAsync(IPage page, CancellationToken token, double securityTime = 0.5)
        {
            JobDetailsSection obj = new JobDetailsSection(page, token);
            await obj.InicializateAsync(securityTime);
            return obj;
        }

        private async Task InicializateAsync(double securityTime)
        {
            _supDivElement = await LoadElementAsync("div[class*='jobs-unified-top-card']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _subscribeButton = await _supDivElement!.QuerySelectorAsync("button:has-text('Candidatura simplificada')");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _continueButton = await _supDivElement.QuerySelectorAsync("button[aria-label*='Continuar candidatura']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _feedbackMessage = await _supDivElement.QuerySelectorAsync("span[class='artdeco-inline-feedback__message']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _saveButton = await _supDivElement.QuerySelectorAsync("button[class*='jobs-save-button']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            if (_saveButton != null)
                _jobAlreadySaved = await _saveButton!.QuerySelectorAsync("span:has-text('Salvos')");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
        }

        public async Task<bool> CheckSubscribedStatus()
        {
            return _feedbackMessage != null;
        }

    }

}
