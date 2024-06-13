using forms.Repositories;
using forms.Utilities;
using forms.Utilities.Messages;
using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class FilterSection
    {
        private IPage _page;
        private ILocator showAllFiltersButton;
        private ILocator buttonFilterEasyApply;
        private ILocator applyFilterButton;
        private LogRepository _logRepository = new();
        private PlaywrightUtilities playwrightUtilities = new();

        public FilterSection(IPage page)
        {
            _page = page;
        }

        public static async Task<FilterSection> BuildAsync(IPage page, double securityTime = 0.5)
        {
            FilterSection obj = new FilterSection(page);
            await obj.InicializateAsync(securityTime);
            return obj;
        }

        private async Task InicializateAsync(double securityTime)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            showAllFiltersButton = _page.GetByLabel("Exibir todos os filtros. Ao");
        }

        private async Task LoadFilterElements(double securityTime = 0.5)
        {
            await playwrightUtilities.WaitForElementAndHandleExceptionAsync(_page, "#selected-vertical", "Div de filtros carregada", "Erro ao carregar div de filtros");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            buttonFilterEasyApply = _page.GetByText("Desativada Alternar filtro Candidatura simplificada");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            applyFilterButton = _page.GetByLabel("Aplicar filtros atuais para");
        }

        public async Task GoToFilterSection(double securityTime = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await showAllFiltersButton.ClickAsync();
            await LoadFilterElements();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await buttonFilterEasyApply.ClickAsync();
        }

        public async Task SelectFilter(string field, double securityTime = 0.5)
        {
            await _page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = $"{field} Filtrar por {field}" }).ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
        }

        public async Task SelectFilter(List<string> checkedListBoxItems, double securityTime = 0.5)
        {
            foreach (string selectedItem in checkedListBoxItems)
            {
                try
                {
                    await playwrightUtilities.WaitForElementAndHandleExceptionAsync(_page, $"span:has-text:('Filtrar por {selectedItem})'","Filtro encontrado","Não foi possível encontrar o filtro", 2000);
                    await _page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = $"{selectedItem} Filtrar por {selectedItem}" }).ClickAsync();
                }
                catch (Exception e)
                {
                    _logRepository.WriteALogError(ExceptionMessages.CouldNotFoundElement, e);
                }
                await Task.Delay(TimeSpan.FromSeconds(securityTime));
            }
        }

        public async Task ApplyFilter(double securityTime = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await applyFilterButton.ClickAsync();
        }
    }
}
