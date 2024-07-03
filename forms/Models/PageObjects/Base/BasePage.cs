using forms.Repositories;
using forms.Utilities.Messages;
using Microsoft.Playwright;
using Newtonsoft.Json.Linq;

namespace forms.Models.PageObjects.Base
{
    public class BasePage
    {
        public IPage _page; 
        private CancellationToken _token;

        private LogRepository logRepository = new();
        private OutputStringPatterns outputString = new();


        public BasePage(IPage page, CancellationToken token)
        {
            _page = page;
            _token = token;
            VerifyToken();
        }

        public async Task<IElementHandle?> LoadElementAsync(string selector, double time = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(time));
            return await _page.QuerySelectorAsync(selector);
        }

        public async Task<string> WaitForElementAndHandleExceptionAsync(IPage page, string selector, string successMessage = "", string errorMessage = "", int timeout = 60000, bool showMessageBox = true)
        {
            try
            {
                await page.WaitForSelectorAsync(selector, new() { Timeout = timeout });
                return successMessage;
            }
            catch (Exception exception)
            {
                if (showMessageBox) MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                logRepository.WriteALogError(errorMessage, exception);
                return outputString.errorPattern(errorMessage, exception);
            }
        }

        public void VerifyToken()
        {
            if (_token.IsCancellationRequested)
            {
                throw new OperationCanceledException("Ação cancelada pelo usuário");
            }
        }
    }
}
