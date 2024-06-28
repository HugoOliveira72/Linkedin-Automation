using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class PopupWindowSection
    {
        private IPage _page;
        public IElementHandle? _advanceButton;
        public IElementHandle? _sendJobApplicationButton;
        public IElementHandle? _closeButton;
        public IElementHandle? _reviewButton;
        public IElementHandle? _saveButton;
        public IElementHandle? _additionalQuestions;

        public PopupWindowSection(IPage page)
        {
            _page = page;
        }

        public static async Task<PopupWindowSection> BuildAsync(IPage page, double securityTime = 0.5)
        {
            PopupWindowSection obj = new PopupWindowSection(page);
            await obj.InicializateAsync(securityTime);
            return obj;
        }

        private async Task InicializateAsync(double securityTime)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _advanceButton = await _page.QuerySelectorAsync("button[aria-label='Avançar para próxima etapa']");
        }

        public async Task<bool> CheckAddicionalQuestions()
        {
            return new[] { "Revise sua candidatura", "Addicional", "Perguntas adicionais", "Additional Questions", "Additional" }.Any(obj => _additionalQuestions!.ToString()!.Contains(obj));
        }

        public async Task SendJobApplicationAndClosePage(double securityTime = 0.5)
        {
            //Load elements
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _sendJobApplicationButton = await _page.QuerySelectorAsync("button:has-text('Enviar candidatura')");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _closeButton = await _page.QuerySelectorAsync("button[aria-label='Fechar']");
            //Click elements
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _sendJobApplicationButton.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _closeButton.ClickAsync();
        }

        public async Task SaveJobClosePage(double securityTime = 0.5)
        {
            //Load elements
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _closeButton = await _page.QuerySelectorAsync("button[aria-label='Fechar']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            //Click Elements
            await _closeButton.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _saveButton = await _page.QuerySelectorAsync("button[data-control-name='save_application_btn']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _saveButton.ClickAsync();
        }

        public async Task<IElementHandle?> LoadElementAsync(string selector)
        {
            return await _page.QuerySelectorAsync(selector);
        }
    }
}
