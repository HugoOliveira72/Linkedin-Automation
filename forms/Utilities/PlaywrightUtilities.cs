using forms.Repositories;
using forms.Utilities.Messages;
using Microsoft.Playwright;

namespace forms.Utilities
{
    public class PlaywrightUtilities
    {
        LogRepository logRepository = new();
        OutputStringPatterns outputString = new();

        public async Task<string> WaitForElementAndHandleExceptionAsync(IPage page, string selector, string successMessage = "", string errorMessage = "", int timeout = 60000)
        {
            try
            {
                await page.WaitForSelectorAsync(selector, new() { Timeout = timeout });
                return successMessage;
            }
            catch (Exception exception)
            {
                MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                logRepository.WriteALogError(errorMessage, exception);
                return outputString.errorPattern(errorMessage, exception);
            }
        }

        public async Task QuerySelectorAndClickAsync(IPage page, string querySelector, double securityTimePause = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTimePause));
            var closeButton = await page.QuerySelectorAsync(querySelector);
            await Task.Delay(TimeSpan.FromSeconds(securityTimePause));
            await closeButton!.ClickAsync();
        }
    }
}
