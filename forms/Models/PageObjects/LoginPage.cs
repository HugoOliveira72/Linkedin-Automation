using forms.Models.Interfaces;
using forms.Repositories;
using forms.Utilities.Messages;
using Microsoft.Playwright;

namespace forms.Models.PageObjects
{
    public class LoginPage
    {
        public IPage _page;
        private ILocator _userNameTextBox;
        private ILocator _passwordTextBox;
        private ILocator _loginButton;
        private IElementHandle _errorLoginDiv;
        private LogRepository _logRepository = new();
        private OutputStringPatterns _outputStringPatterns = new();

        public LoginPage(IPage page)
        {
            _page = page;
        }

        public static async Task<LoginPage> BuildAsync(IPage page, double securityTime = 0.5)
        {
            LoginPage obj = new LoginPage(page);
            await obj.InicializateAsync(securityTime);
            return obj;
        }

        private async Task InicializateAsync(double securityTime)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _userNameTextBox = _page.GetByLabel("E-mail ou telefone");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _passwordTextBox = _page.GetByLabel("Senha");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _loginButton = _page.GetByLabel("Entrar", new() { Exact = true });
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            _errorLoginDiv = await _page.QuerySelectorAsync("div[error-for=\"password\"]");
        }

        public async Task LoginAsync(string userName, string password, double securityTime = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _userNameTextBox.ClickAsync();
            await _userNameTextBox.FillAsync(userName);
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _passwordTextBox.ClickAsync();
            await _passwordTextBox.FillAsync(password);
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await _loginButton.ClickAsync();
        }

        public async Task<bool> HandleErrorLoginAsync()
        {
            if (_errorLoginDiv != null)
            {
                _logRepository.WriteALogError(_outputStringPatterns.errorPattern(ExceptionMessages.IncorretLogin, null), new Exception("Erro de login"));
                return true;
            }
            return false;
        }
    }
}
