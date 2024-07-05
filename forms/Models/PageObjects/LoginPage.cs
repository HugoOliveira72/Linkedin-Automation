using forms.Models.Interfaces;
using forms.Models.PageObjects.Base;
using forms.Repositories;
using forms.Utilities.Messages;
using Microsoft.Playwright;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace forms.Models.PageObjects
{
    public class LoginPage : BasePage
    {
        public IPage _page;
        private ILocator _userNameTextBox;
        private ILocator _passwordTextBox;
        private ILocator _loginButton;
        private IElementHandle _errorLoginDiv;
        private ILogRepository _logRepository;
        private OutputStringPatterns _outputStringPatterns = new();

        public LoginPage(IPage page, ILogRepository logRepository, CancellationToken token) : base(page, token)
        {
            _page = page;
            _logRepository = logRepository;
        }

        public static async Task<LoginPage> BuildAsync(IPage page, ILogRepository logRepository, CancellationToken token, double securityTime = 0.5)
        {
            LoginPage obj = new LoginPage(page, logRepository, token);
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
            _errorLoginDiv = await LoadElementAsync("div[error-for=\"password\"]");
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

        public async Task HandleSecurity(IPage page, string selector, string errorMessage = "", int timeout = 60000, bool showMessageBox = true)
        {
            Exception exception = new Exception();
            try
            {
                await page.WaitForSelectorAsync(selector, new() { Timeout = timeout });
            }
            catch (Exception e)
            {
                if (showMessageBox) MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                _logRepository.WriteALogError(errorMessage, e);
                exception = e;
            }
            if(exception.Source != null && exception.TargetSite != null)
            {
                throw new TimeoutException(exception.Message);
            }
        }
    }
}
