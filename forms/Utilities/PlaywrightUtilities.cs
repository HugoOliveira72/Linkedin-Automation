using forms.Repositories;
using Microsoft.Playwright;

namespace forms.Utilities
{
    public class PlaywrightUtilities
    {
        LogRepository logRepository = new();
        public async Task<string> WaitForElementAndHandleExceptionAsync(IPage page, string selector, string successMessage, string errorMessage)
        {
            try
            {
                await page.WaitForSelectorAsync(selector, new() { Timeout = 60000 });
                return successMessage;
            }
            catch (Exception exception)
            {
                MessageBox.Show(errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                logRepository.WriteALogError(errorMessage, exception);
                throw new Exception();
            }
        }

        public async Task QuerySelectorAndClickAsync(IPage page, string querySelector, double msPauseTime = 0)
        {
            await Task.Delay(TimeSpan.FromSeconds(msPauseTime));
            var closeButton = await page.QuerySelectorAsync(querySelector);
            await Task.Delay(TimeSpan.FromSeconds(msPauseTime));
            await closeButton!.ClickAsync();
        }
    }
}
