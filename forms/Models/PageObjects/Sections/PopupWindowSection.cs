using forms.Models.PageObjects.Base;
using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class PopupWindowSection : BasePage
    {
        private IPage _page;
        public IElementHandle? _advanceButton;
        public IElementHandle? _sendJobApplicationButton;
        public IElementHandle? _closeButton;
        public IElementHandle? _reviewButton;
        public IElementHandle? _saveButton;
        public IElementHandle? _additionalQuestions;

        public PopupWindowSection(IPage page) : base(page)
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
            _advanceButton = await LoadElementAsync("button[aria-label='Avançar para próxima etapa']");
        }

        public async Task<bool> CheckAddicionalQuestions()
        {
            return new[] { "Revise sua candidatura", "Addicional", "Perguntas adicionais", "Additional Questions", "Additional" }.Any(obj => _additionalQuestions!.ToString()!.Contains(obj));
        }

        public async Task SendJobApplicationAndClosePage(double securityTime = 0.5)
        {
            //Load elements
            _sendJobApplicationButton = await LoadElementAsync("button:has-text('Enviar candidatura')");
            //Click elements
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _sendJobApplicationButton.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(1));
            await _page.Keyboard.PressAsync("Escape");
        }

        public async Task SaveJobClosePage(double securityTime = 0.5)
        {
            //Load elements
            _closeButton = await LoadElementAsync("button[aria-label='Fechar']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            //Click Elements
            await _closeButton.ClickAsync();
            _saveButton = await LoadElementAsync("button[data-control-name='save_application_btn']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _saveButton.ClickAsync();
        }
    }
}
