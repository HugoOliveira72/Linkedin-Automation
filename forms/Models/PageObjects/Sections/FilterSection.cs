using forms.Repositories;
using forms.Utilities.Messages;
using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class FilterSection : JobPage
    {
        private IPage _page;
        private IElementHandle? navFilterArea;
        private IElementHandle? buttonJobFilter;
        private ILocator showAllFiltersButton;
        private IElementHandle? filterTypeSpan;
        private IElementHandle? buttonFilterType;
        private ILocator buttonFilterEasyApply;
        private ILocator allFilterButton;
        private ILocator applyFilterButton;
        private LogRepository _logRepository = new();

        public FilterSection(IPage page) : base(page)
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
            navFilterArea = await _page.WaitForSelectorAsync("nav[aria-label='Filtros de pesquisa']");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            buttonJobFilter = await navFilterArea.QuerySelectorAsync("button:has-text('Vagas')");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            showAllFiltersButton = _page.GetByLabel("Exibir todos os filtros. Ao");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            filterTypeSpan = await _page.QuerySelectorAsync("#selected-vertical");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            buttonFilterType = await filterTypeSpan.QuerySelectorAsync("button");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            buttonFilterEasyApply = _page.GetByText("Desativada Alternar filtro Candidatura simplificada");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            allFilterButton = _page.GetByLabel("Todos os filtros", new() { Exact = true });
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            applyFilterButton = _page.GetByLabel("Aplicar filtros atuais para");
        }

        public async Task GoToFilterSection(double securityTime = 0.5)
        {
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await buttonJobFilter.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await showAllFiltersButton.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await buttonFilterType.ClickAsync();
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
            await allFilterButton.PressAsync("Enter");
            await Task.Delay(TimeSpan.FromSeconds(securityTime));
            await applyFilterButton.ClickAsync();
        }
    }
}
