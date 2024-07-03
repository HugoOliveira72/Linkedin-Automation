using forms.Models.Filters;
using forms.Models.PageObjects.Base;
using forms.Repositories;
using forms.Utilities.Messages;
using Microsoft.Playwright;

namespace forms.Models.PageObjects.Sections
{
    public class FilterSection : BasePage
    {
        private IPage _page;
        private ILocator showAllFiltersButton;
        private ILocator buttonFilterEasyApply;
        private ILocator applyFilterButton;
        private LogRepository _logRepository = new();


        public FilterSection(IPage page, CancellationToken token) : base(page, token)
        {
            _page = page;
        }

        public static async Task<FilterSection> BuildAsync(IPage page, CancellationToken token, double securityTime = 0.5)
        {
            FilterSection obj = new FilterSection(page, token);
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
            await WaitForElementAndHandleExceptionAsync(_page, "#selected-vertical", "Div de filtros carregada", "Erro ao carregar div de filtros");
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

        public async Task SelectFilter(string labelName, List<string> checkedListBoxItems, double securityTime = 0.5)
        {
            foreach (string selectedItem in checkedListBoxItems)
            {
                try
                {
                    await Task.Delay(TimeSpan.FromSeconds(securityTime));
                    var element = _page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = $"{selectedItem} Filtrar por {selectedItem}" });
                    await Task.Delay(TimeSpan.FromSeconds(securityTime));
                    await element.ClickAsync(new() { Timeout = 3000 });
                }
                catch (Exception e)
                {
                    if (selectedItem.Contains("Estágio"))
                    {
                        if (labelName == FilterLabelsModel.ExperienceLevelLabel)
                        {
                            await _page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = $"{selectedItem} Filtrar por {selectedItem}" }).First.ClickAsync();
                            continue;
                        }
                        else if (labelName == FilterLabelsModel.JobTypeLabel)
                        {
                            await _page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = $"{selectedItem} Filtrar por {selectedItem}" }).Last.ClickAsync();
                            continue;
                        }
                    }
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
