using forms.Models.Interfaces;
using forms.Repositories;
using forms.Services;
using forms.Utilities;
using forms.Utilities.Messages;
using forms.Views.Interfaces;
using Linkedin_Automation.Config;
using Linkedin_Automation.Model;
using Microsoft.Playwright;
using playwright.Model;

namespace forms.Presenters
{
    public class AutomationPresenter
    {
        private IAutomationView _automationView;
        private IDataService<dynamic> _dataService;
        private ILogService _logService;
        private ILoginRepository _loginRepository;
        private ILogRepository _logRepository;
        private OutputStringPatterns stringPatterns = new();
        private PlaywrightUtilities playwrightUtilities = new();
        //private static ExceptionMessages exceptionMessages;
        public AutomationPresenter(
            IAutomationView automationView,
            IDataService<dynamic> dataService,
            ILogService logService,
            ILoginRepository loginRepository,
            ILogRepository logRepository)
        {
            _automationView = automationView;
            _dataService = dataService;
            _logService = logService;
            _automationView.StartAutomation += StartAutomation;
            _loginRepository = loginRepository;
            _logRepository = logRepository;
            //_automationView
        }

        private async void StartAutomation(object sender, EventArgs e)
        {
            CancellationTokenSource cancellationToken = new();
            await Script(cancellationToken.Token);
        }

        //Automation Method
        private async Task Script(CancellationToken token)
        {
            // OBTEM DADOS DA TELA HOME
            HomeModel Homedata = _dataService.GetData();

            // VERIFICAÇÃO EXISTENCIA LOG.TXT
            _logService.LogFileExistingVerification();

            // LER DADOS DE USUARIO
            UserModel userInfo = _loginRepository.ConvertMsgpackFileToObject();

            // CONFIGURAÇÃO DO PLAYWRIGHT
            IConfigRepository configRepository = new ConfigRepository();
            PlaywrightConfiguration playwrightConfiguration = new PlaywrightConfiguration(configRepository);
            var settings = await playwrightConfiguration.launchSettingsAsync();

            //INICIO
            _automationView.RichtxtBox += (stringPatterns.linePattern());
            _automationView.RichtxtBox += ("Iniciando...\n");
            _automationView.RichtxtBox += ("Abrindo o navegador padrão...\n");
            IPage page = await settings.BrowserContext!.NewPageAsync();

            // DIRECIONANDO
            _automationView.RichtxtBox += ("Direcionando para https://www.linkedin.com/\n");
            await Task.Delay(TimeSpan.FromSeconds(0.5));

            await page.GotoAsync("https://www.linkedin.com/");
            await Task.Delay(TimeSpan.FromSeconds(5));

            await page.GetByLabel("Principal").GetByRole(AriaRole.Link, new() { Name = "Entrar" }).ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(1));

            // PREENCHIMENTO DAS CREEDENCIAIS
            _automationView.RichtxtBox += ("Fazendo login..\n");

            await page.GetByLabel("E-mail ou telefone").ClickAsync();
            await page.GetByLabel("E-mail ou telefone").FillAsync(userInfo.email);
            _automationView.RichtxtBox += ("Usuario/email preenchido\n");
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            await page.GetByLabel("Senha").ClickAsync();
            await page.GetByLabel("Senha").FillAsync(userInfo.password);
            _automationView.RichtxtBox += ("Senha preenchida\n");
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            await page.GetByLabel("Entrar", new() { Exact = true }).ClickAsync();

            var errorLogin = await page.QuerySelectorAsync("div[error-for=\"password\"]");
            if (errorLogin != null)
            {
                _automationView.RichtxtBox += (stringPatterns.errorPattern(ExceptionMessages.IncorretLogin, null, false));
                return;
            }
            await Task.Delay(TimeSpan.FromSeconds(2));

            // CÓDIGO LINKEDIN / VERIFICAÇÃO DE SEGURANÇA (MANUALMENTE)
            _automationView.RichtxtBox += ("Carregando...\n");
            var message = await playwrightUtilities.WaitForElementAndHandleException(page, "#global-nav-typeahead", "Página carregada!", ExceptionMessages.SecurityError);
            _automationView.RichtxtBox += (message);
            await Task.Delay(TimeSpan.FromSeconds(2));

            // PESQUISA DE VAGAS
            _automationView.RichtxtBox += (stringPatterns.linePattern());
            _automationView.RichtxtBox += ($"Pesquisando {Homedata.TxtboxJob}");
            var searchJobDiv = await page.QuerySelectorAsync("#global-nav-typeahead");
            await searchJobDiv.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            var inputSearchJob = await searchJobDiv.QuerySelectorAsync(".search-global-typeahead__input");
            await inputSearchJob.FillAsync(Homedata.TxtboxJob);
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            await inputSearchJob.PressAsync("Enter");
            _automationView.RichtxtBox += ("Pesquisado com sucesso\n");
            await Task.Delay(TimeSpan.FromSeconds(2));

            // APLICAÇÃO DE FILTROS
            _automationView.RichtxtBox += ("Aplicando filtros\n");
            var navFilterArea = await page.QuerySelectorAsync("nav[aria-label='Filtros de pesquisa']");
            var buttonJobFilter = await navFilterArea.QuerySelectorAsync("button:has-text('Vagas')");
            await buttonJobFilter.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            _automationView.RichtxtBox += ("Exibindo todos os filtros\n");
            await page.GetByLabel("Exibir todos os filtros. Ao").ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            var filterTypeSpan = await page.QuerySelectorAsync("#selected-vertical");
            var buttonFilterType = await filterTypeSpan.QuerySelectorAsync("button");
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            await buttonFilterType.ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            _automationView.RichtxtBox += ("Selecionando candidatura simplificada..\n");
            await page.GetByText("Desativada Alternar filtro Candidatura simplificada").ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            ///Classificar por
            _automationView.RichtxtBox += ($"*FiltroClassificar por: {Homedata.ClassifyBy};");
            await page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = $"{Homedata.ClassifyBy} Filtrar por {Homedata.ClassifyBy}" }).ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            ///Data do anúncio
            _automationView.RichtxtBox += ($"*FiltroData do anúncio: {Homedata.AnnoucementDate};");
            await page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = $"{Homedata.AnnoucementDate} Filtrar por {Homedata.AnnoucementDate}" }).ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            ///Nível de experiência
            _ = ApplyFilter("Nível de experiencia", Homedata.CheckedListBoxExperiences, page);

            ///Tipo de vaga
            _ = ApplyFilter("Tipo de vaga", Homedata.CheckedListBoxType_job, page);

            ///Remoto
            _ = ApplyFilter("Remoto", Homedata.CheckedListBoxRemote, page);

            await page.GetByLabel("Todos os filtros", new() { Exact = true }).PressAsync("Enter");
            await Task.Delay(TimeSpan.FromSeconds(0.8));

            await page.GetByLabel("Aplicar filtros atuais para").ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(3));

            /*
             MANUAL DE VAGAS
                - avaiableJobs, Vagas disponiveis podem ser candidadatas
                - appliedJobs, Vagas candidatadas
                - savedJobs, Vagas que contem perguntas, são salvas para preenchimento manual posterior

             */
            int currentPage = 1, jobsCounter = 0, appliedJobs = 0, savedJobs = 0;

            // LISTAR TODAS AS VAGAS
            var ulElementsJobs = await page.QuerySelectorAllAsync("li[class*='jobs-search-results__list-item']");
            int avaiableJobs = ulElementsJobs.Count();
            _automationView.RichtxtBox += ($"Vagas encontradas: {avaiableJobs}");
            await Task.Delay(TimeSpan.FromSeconds(1));

            //HABILITAR O BOTÃO SAIR
            //button_exit.Enabled = true;
            while (appliedJobs != Homedata.AmoutOfJobs)
            {
                try
                {
                    if (token.IsCancellationRequested) break;

                    jobsCounter++;

                    if (jobsCounter > ulElementsJobs.Count())
                    {
                        // CLICA PAGINAS EM ORDEM CRESCENTE
                        var nextPageButton = await page.QuerySelectorAsync($"button[aria-label='Página {currentPage + 1}']");
                        await Task.Delay(TimeSpan.FromSeconds(1));

                        // VERIFICA EXISTENCIA DA PROXIMA PÁGINA
                        if (nextPageButton != null) /// TRUE, Clica proxima pagina
                            await nextPageButton.ClickAsync();
                        else ///FALSE,  Erro, pagina não existente    
                        {
                            MessageBox.Show("Limite de páginas excedido, não há mais vagas para se candidatar", "Limite excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            stringPatterns.finishPattern(appliedJobs, savedJobs);
                            return;
                        }
                        currentPage++;

                        // RECARREGA LISTA DE VAGAS (pagina nova)
                        await Task.Delay(TimeSpan.FromSeconds(1));
                        ulElementsJobs = await page.QuerySelectorAllAsync("li[class*='jobs-search-results__list-item']");
                        jobsCounter = 1;
                    }

                    _automationView.RichtxtBox += ("==================================\n");
                    _automationView.RichtxtBox += ($"Página {currentPage}");
                    _automationView.RichtxtBox += ($"Vaga nº {jobsCounter}");

                    try
                    {
                        int indexJob = jobsCounter - 1;
                        await ulElementsJobs[indexJob].ClickAsync();
                    }
                    catch (Exception e)
                    {
                        _automationView.RichtxtBox += ($"\n\n\n\n\n======================================\n{e}");
                    }

                    // SELECIONAR DIV SUPERIOR (Div que contem descrição da vaga, botoes)
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    var supDivElement = await page.QuerySelectorAsync("div[class*='jobs-unified-top-card']");
                    await Task.Delay(TimeSpan.FromSeconds(0.3));

                    // ============= ETAPA DE CANDIDATURA =============
                    // BOTÃO CANDIDATURA SIMPLIFICADA
                    var buttonHandle = await supDivElement!.QuerySelectorAsync("button:has-text('Candidatura simplificada')");
                    await Task.Delay(TimeSpan.FromSeconds(1));

                    // CLICAR NO BOTÃO (Candidatar-se a vaga)
                    if (buttonHandle != null)
                    {
                        await buttonHandle!.ClickAsync();
                    }
                    else
                    {
                        // VERIFICAR SE VAGA ESTÁ INCOMPLETA (Continue)
                        var continueButton = await supDivElement.QuerySelectorAsync("button[aria-label*='Continuar candidatura']");
                        if (continueButton != null)
                        {
                            // SALVAR VAGA
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            var saveButton = await supDivElement.QuerySelectorAsync("button[class*='jobs-save-button']");

                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            var jobAlreadySaved = await saveButton.QuerySelectorAsync("span:has-text('Salvos')");
                            if (jobAlreadySaved != null)
                            {
                                _automationView.RichtxtBox += ("VAGA JÁ FOI SALVA ANTERIORMENTE\n");
                                continue;
                            }

                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            await saveButton.ClickAsync();

                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            _automationView.RichtxtBox += ($"Salva a vaga nº{jobsCounter}");
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            Console.ForegroundColor = ConsoleColor.Blue;
                            _automationView.RichtxtBox += ($"Total de {savedJobs} vagas salvas");
                            Console.ResetColor(); // Resetar a cor para o padrão

                            continue;
                        }

                        // VERIFICAR SE VAGA JA FOI INSCRITA
                        var feedbackMessage = await supDivElement.QuerySelectorAsync("span[class='artdeco-inline-feedback__message']");

                        string appliedAlready = await feedbackMessage.TextContentAsync();

                        if (appliedAlready!.Contains("Candidatou-se"))
                        {
                            _automationView.RichtxtBox += ("!Vaga já candidatada!\n");
                            continue;
                        }
                    }

                    // BOTÃO AVANÇAR
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    var advanceButton = await page.QuerySelectorAsync("button[aria-label='Avançar para próxima etapa']");

                    if (advanceButton == null)// QUANDO BOTÃO AVANÇAR Ñ EXISTE
                    {
                        /// CLICA BOTÃO ENVIAR CANDIDATURA
                        await Task.Delay(TimeSpan.FromSeconds(1));
                        var buttonSendSubscribe = await page.QuerySelectorAsync("button:has-text('Enviar candidatura')");
                        await buttonSendSubscribe!.ClickAsync();

                        /// CLICA BOTÃO FECHAR
                        await Task.Delay(TimeSpan.FromSeconds(2));
                        var closeButton = await page.QuerySelectorAsync("button[aria-label='Fechar']");
                        await closeButton!.ClickAsync();

                        appliedJobs++;

                        /// EXIBE NA TELA INFORMAÇÕES DA CANDIDATURA
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        _automationView.RichtxtBox += ($"Inscrito na vaga nº{jobsCounter}");
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        _automationView.RichtxtBox += ($"Total de {appliedJobs} vagas aplicadas");
                        continue;
                    }
                    else // QUANDO BOTÃO AVANÇAR EXISTE!
                    {
                        await Task.Delay(TimeSpan.FromSeconds(1));
                        try
                        {
                            /// CLICA NO BOTÃO AVANÇAR
                            await advanceButton!.ClickAsync();
                        }
                        catch (Exception e)
                        {
                            /// ERRO AO CLICAR NO BOTÃO
                            _logRepository.WriteALogError("Não foi possivel clicar no botão avançar!", e);
                            continue;
                        }
                    }

                    //BOTÃO REVISAR
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    var reviewButton = await page.QuerySelectorAsync("span:has-text('Revisar')");
                    if (reviewButton == null) // QUANDO BOTÃO REVISAR Ñ EXISTE
                        await advanceButton.ClickAsync(); /// Haverá o botão avançar
                    else// QUANDO BOTÃO REVISAR EXISTE
                    {
                        try
                        {
                            await reviewButton!.ClickAsync();
                        }
                        catch (Exception e)
                        {
                            await Task.Delay(TimeSpan.FromSeconds(1));
                            await advanceButton.ClickAsync();
                        }
                    }

                    //PERGUNTAS ADICIONAIS
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    var additionalQuestions = await page.QuerySelectorAsync("h3");
                    if (additionalQuestions!.ToString()!.Contains("Revise sua candidatura")) // QUANDO Ñ HÁ PERGUNTAS
                    {
                        // ENVIAR CANDIDATURA, SEM PERGUNTAS
                        await Task.Delay(TimeSpan.FromSeconds(1));
                        var buttonSendCand = await page.QuerySelectorAsync("button:has-text('Enviar candidatura')");
                        await buttonSendCand!.ClickAsync();

                        // FECHAR
                        await Task.Delay(TimeSpan.FromSeconds(1));
                        var closebutton = await page.QuerySelectorAsync("button[aria-label='Fechar']");
                        await closebutton!.ClickAsync();

                        appliedJobs++;

                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        _automationView.RichtxtBox += ($"Inscrito na vaga nº{jobsCounter}");
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        _automationView.RichtxtBox += ($"Total de {appliedJobs} vagas aplicadas");
                        stringPatterns.finishPattern(appliedJobs, savedJobs);
                        continue;
                    }
                    else if (additionalQuestions != null) // QUANDO HÁ PERGUNTAS
                    {
                        // FECHAR
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        var closebutton = await page.QuerySelectorAsync("button[aria-label='Fechar']");
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        await closebutton!.ClickAsync();

                        // SALVAR
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        var saveButton = await page.QuerySelectorAsync("span:has-text('Salvar')");
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        await saveButton!.ClickAsync();

                        savedJobs++;

                        await Task.Delay(TimeSpan.FromSeconds(0.8));

                        _automationView.RichtxtBox += ($"Salva a vaga nº{jobsCounter}");
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        _automationView.RichtxtBox += ($"Total de {appliedJobs} vagas aplicadas");

                        _automationView.RichtxtBox += ($"Total de {savedJobs} vagas salvas");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    _logRepository.WriteALogError("Erro genérico", e);
                    return;
                }
            }
        }

        private async Task ApplyFilter(string filterName, List<string> CheckedListBoxItems, IPage page)
        {
            _automationView.RichtxtBox += ($"*Filtro: {filterName}\n");
            foreach (string selectedItem in CheckedListBoxItems)
            {
                _automationView.RichtxtBox += ($"\t{selectedItem}");
                try
                {
                    await page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = $"{selectedExperience} Filtrar por {selectedExperience}" }).ClickAsync();
                }
                catch (Exception e)
                {
                    _logRepository.WriteALogError(ExceptionMessages.CouldNotFoundElement, e);
                }
                await Task.Delay(TimeSpan.FromSeconds(0.5));
            }
        }
    }
}
