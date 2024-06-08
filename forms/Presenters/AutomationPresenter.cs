using forms.Models.Interfaces;
using forms.Models.PageObjects;
using forms.Models.PageObjects.Sections;
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

            // CONFIGURAÇÃO DO PLAYWRIGHT
            IConfigRepository configRepository = new ConfigRepository();
            PlaywrightConfiguration playwrightConfiguration = new PlaywrightConfiguration(configRepository);
            var settings = await playwrightConfiguration.launchSettingsAsync();

            //INICIO
            await AddMessageToRichTextbox(stringPatterns.linePattern());
            await AddMessageToRichTextbox("Iniciando...\n");
            await AddMessageToRichTextbox("Abrindo o navegador padrão...\n");
            IPage page = await settings.BrowserContext!.NewPageAsync();

            // DIRECIONANDO
            await AddMessageToRichTextbox("Direcionando para https://www.linkedin.com/\n");
            await Task.Delay(TimeSpan.FromSeconds(0.5));

            await page.GotoAsync("https://www.linkedin.com/");
            await Task.Delay(TimeSpan.FromSeconds(5));

            await page.GetByLabel("Principal").GetByRole(AriaRole.Link, new() { Name = "Entrar" }).ClickAsync();
            await Task.Delay(TimeSpan.FromSeconds(1));

            #region LoginPage
            /// LER DADOS DE USUARIO
            UserModel userInfo = _loginRepository.ConvertMsgpackFileToObject();

            /// PREENCHIMENTO DAS CREEDENCIAIS
            await AddMessageToRichTextbox("Fazendo login..\n");

            ///Login page
            LoginPage loginPage = await LoginPage.BuildAsync(page);
            await loginPage.LoginAsync(userInfo.email, userInfo.password);

            //if (await loginPage.HandleErrorLoginAsync())
            //    return;

            await AddMessageToRichTextbox("Login bem sucedido\n");
            await Task.Delay(TimeSpan.FromSeconds(2));
            #endregion

            #region Securityhandle
            // CÓDIGO LINKEDIN / VERIFICAÇÃO DE SEGURANÇA (MANUALMENTE)
            await AddMessageToRichTextbox("Carregando...\n");
            var message = await playwrightUtilities.WaitForElementAndHandleExceptionAsync(page, "#global-nav-typeahead", "Página carregada!", ExceptionMessages.SecurityError);
            await AddMessageToRichTextbox(message);
            await Task.Delay(TimeSpan.FromSeconds(2));
            #endregion

            #region JobPage Search Section
            // PESQUISA DE VAGAS
            await AddMessageToRichTextbox(stringPatterns.linePattern());
            await AddMessageToRichTextbox($"Pesquisando {Homedata.TxtboxJob}\n");

            JobPage jobPage = await JobPage.BuildAsync(page);
            await jobPage.SearchJobAsync(Homedata.TxtboxJob);

            await AddMessageToRichTextbox("Pesquisado com sucesso\n");
            await Task.Delay(TimeSpan.FromSeconds(2));
            #endregion

            #region FilterSection
            FilterSection jobSearchPage = await FilterSection.BuildAsync(page);

            await AddMessageToRichTextbox("Aplicando filtros\n");
            await jobSearchPage.GoToFilterSection(0.8);

            ///Classificar por
            await AddMessageToRichTextbox("Classificar por");
            await jobSearchPage.SelectFilter(Homedata.ClassifyBy);
            ///Data do anúncio
            await AddMessageToRichTextbox("Data do anúncio");
            await jobSearchPage.SelectFilter(Homedata.AnnoucementDate);
            ///Nível de experiência
            await AddMessageToRichTextbox("Nível de experiencia");
            await jobSearchPage.SelectFilter(Homedata.CheckedListBoxExperiences);
            ///Tipo de vaga
            await AddMessageToRichTextbox("Tipo de vaga");
            await jobSearchPage.SelectFilter(Homedata.CheckedListBoxType_job);
            ///Remoto
            await AddMessageToRichTextbox("Remoto");
            await jobSearchPage.SelectFilter(Homedata.CheckedListBoxRemote);

            ///Apply All filters
            await jobSearchPage.ApplyFilter();
            await Task.Delay(TimeSpan.FromSeconds(3));
            #endregion

            #region GetAllJobs Elements
            /*
                - avaiableJobs, Vagas disponiveis podem ser candidadatas
                - appliedJobs, Vagas candidatadas
                - savedJobs, Vagas que contem perguntas, são salvas para preenchimento manual posterior
            */
            int currentPage = 1, jobsCounter = 0, appliedJobs = 0, savedJobs = 0;

            // Instancia jobListSection
            JobListSection jobListSection = await JobListSection.BuildAsync(page, currentPage);
            int avaiableJobs = jobListSection.getAvailableJob();
            await AddMessageToRichTextbox($"Vagas encontradas: {avaiableJobs}");
            await Task.Delay(TimeSpan.FromSeconds(1));

            #endregion

            //HABILITAR O BOTÃO SAIR 
            //button_exit.Enabled = true;
            while (appliedJobs != Homedata.AmountOfJobs)
            {
                try
                {
                    if (token.IsCancellationRequested) break;

                    jobsCounter++;

                    #region NextPageValidation
                    if (jobsCounter > avaiableJobs)
                    {
                        bool hasNextPage = await jobListSection.GoToNextPage(currentPage, appliedJobs, savedJobs);
                        // Fechar aplicação
                        if (!hasNextPage)
                        {
                            return;
                        }
                        //Recarregar elementos
                        else
                        {
                            await jobListSection.ReloadUlElements();
                            avaiableJobs = jobListSection.getAvailableJob();
                            currentPage++;
                            jobsCounter = 1;
                            await AddMessageToRichTextbox(stringPatterns.ShowFinalResult(appliedJobs, savedJobs));
                            await AddMessageToRichTextbox($"Vagas encontradas: {avaiableJobs}");
                        }
                    }
                    #endregion

                    await AddMessageToRichTextbox(stringPatterns.linePattern());
                    await AddMessageToRichTextbox($"Página {currentPage}");
                    await AddMessageToRichTextbox($"Vaga nº {jobsCounter}");

                    #region SelectJob
                    //Selecionar vaga
                    try
                    {
                        await jobListSection.ClickOnJob(jobsCounter);
                    }
                    catch (Exception e)
                    {
                        await AddMessageToRichTextbox($"\n\n{stringPatterns.linePattern}{e}");
                        _logRepository.WriteALogError("Erro ao selecionar vaga", e);
                    }
                    #endregion

                    //OK
                    #region Handle subscribe button
                    // SELECIONAR DIV SUPERIOR (Div que contem descrição da vaga, botoes)
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    var supDivElement = await page.QuerySelectorAsync("div[class*='jobs-unified-top-card']");
                    await Task.Delay(TimeSpan.FromSeconds(0.3));

                    // BOTÃO CANDIDATURA SIMPLIFICADA
                    var buttonHandle = await supDivElement!.QuerySelectorAsync("button:has-text('Candidatura simplificada')");
                    await Task.Delay(TimeSpan.FromSeconds(1));

                    // CLICAR NO BOTÃO (Candidatar-se a vaga)
                    if (buttonHandle == null)
                    {
                        // VERIFICAR SE VAGA ESTÁ INCOMPLETA (Continue)
                        IElementHandle continueButton = await supDivElement.QuerySelectorAsync("button[aria-label*='Continuar candidatura']");
                        if (continueButton != null)
                        {
                            // SALVAR VAGA
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            var saveButton = await supDivElement.QuerySelectorAsync("button[class*='jobs-save-button']");

                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            var jobAlreadySaved = await saveButton.QuerySelectorAsync("span:has-text('Salvos')");
                            if (jobAlreadySaved != null)
                            {
                                await AddMessageToRichTextbox("VAGA JÁ FOI SALVA!");
                                continue;
                            }
                            await Task.Delay(TimeSpan.FromSeconds(0.8));
                            await saveButton.ClickAsync();
                            await ShowAppliedJobsMessage(jobsCounter, savedJobs);
                            continue;
                        }

                        // VERIFICAR SE VAGA JA FOI INSCRITA
                        var feedbackMessage = await supDivElement.QuerySelectorAsync("span[class='artdeco-inline-feedback__message']");
                        string appliedAlready = await feedbackMessage.TextContentAsync();

                        if (appliedAlready!.Contains("Candidatou-se"))
                        {
                            await AddMessageToRichTextbox("!Vaga já candidatada!");
                            continue;
                        }
                    }
                    else
                    {
                        await buttonHandle!.ClickAsync();
                    }
                    #endregion 

                    //CRIAR MÉTODOS
                    #region Advance button
                    // BOTÃO AVANÇAR
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    var advanceButton = await page.QuerySelectorAsync("button[aria-label='Avançar para próxima etapa']");
                    if (advanceButton == null)// QUANDO BOTÃO AVANÇAR Ñ EXISTE
                    {
                        /// CLICA BOTÃO ENVIAR CANDIDATURA
                        await Task.Delay(TimeSpan.FromSeconds(1));
                        await playwrightUtilities.QuerySelectorAndClickAsync(page, "button:has-text('Enviar candidatura')");

                        /// CLICA BOTÃO FECHAR
                        await Task.Delay(TimeSpan.FromSeconds(2));
                        await playwrightUtilities.QuerySelectorAndClickAsync(page, "button[aria-label='Fechar']");
                        appliedJobs++;

                        /// EXIBE NA TELA INFORMAÇÕES DA CANDIDATURA
                        await ShowAppliedJobsMessage(jobsCounter, appliedJobs);
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
                    #endregion

                    //CRIAR MÉTODOS
                    #region Review button
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
                    #endregion

                    //CRIAR MÉTODOS
                    #region Addicional Questions
                    //PERGUNTAS ADICIONAIS
                    await Task.Delay(TimeSpan.FromSeconds(0.8));
                    var additionalQuestions = await page.QuerySelectorAsync("h3");
                    if (additionalQuestions!.ToString()!.Contains("Revise sua candidatura")) // QUANDO Ñ HÁ PERGUNTAS
                    {
                        // ENVIAR CANDIDATURA, SEM PERGUNTAS
                        await playwrightUtilities.QuerySelectorAndClickAsync(page, "button:has-text('Enviar candidatura')");

                        // FECHAR
                        await playwrightUtilities.QuerySelectorAndClickAsync(page, "button[aria-label='Fechar']");
                        appliedJobs++;

                        await ShowAppliedJobsMessage(jobsCounter, appliedJobs);
                        await AddMessageToRichTextbox(stringPatterns.ShowFinalResult(appliedJobs, savedJobs));
                        continue;
                    }
                    else if (additionalQuestions != null) // QUANDO HÁ PERGUNTAS
                    {
                        // FECHAR
                        await playwrightUtilities.QuerySelectorAndClickAsync(page, "button[aria-label='Fechar']", 0.8);

                        // SALVAR
                        await playwrightUtilities.QuerySelectorAndClickAsync(page, "span:has-text('Salvar')", 0.8);
                        savedJobs++;

                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        await AddMessageToRichTextbox(stringPatterns.ShowFinalResult(appliedJobs, savedJobs));
                        await AddMessageToRichTextbox($"Salva a vaga nº{jobsCounter}");
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        await AddMessageToRichTextbox($"Total de {appliedJobs} vagas aplicadas");

                        await AddMessageToRichTextbox($"Total de {savedJobs} vagas salvas");
                        continue;
                    }
                    #endregion
                }
                catch (Exception e)
                {
                    _logRepository.WriteALogError("Erro genérico", e);
                    return;
                }
            }
        }
        //Handle Subscribe
        private async Task HandleButtonOrContinue(IPage page, IElementHandle? buttonHandle, IElementHandle supDivElement, int jobsCounter, int savedJobs)
        {
            if (buttonHandle != null)
            {
                await buttonHandle.ClickAsync();
            }
            else
            {
                await HandleContinueOrSave(page, supDivElement, jobsCounter, savedJobs);
            }
        }

        private async Task HandleContinueOrSave(IPage page, IElementHandle supDivElement, int jobsCounter, int savedJobs)
        {
            var continueButton = await supDivElement.QuerySelectorAsync("button[aria-label*='Continuar candidatura']");
            if (continueButton != null)
            {
                await SaveJob(page, jobsCounter, savedJobs);
            }
            else
            {
                await CheckAppliedStatus(page, supDivElement);
            }
        }

        private async Task SaveJob(IPage page, int jobsCounter, int savedJobs)
        {
            // Logic for saving the job
            // ...
            await AddMessageToRichTextbox($"Salva a vaga nº{jobsCounter}\n");
            await Task.Delay(TimeSpan.FromSeconds(0.8));
            await AddMessageToRichTextbox($"Total de {savedJobs} vagas salvas\n");
        }

        private async Task CheckAppliedStatus(IPage page, IElementHandle supDivElement)
        {
            var feedbackMessage = await supDivElement.QuerySelectorAsync("span[class='artdeco-inline-feedback__message']");
            string appliedAlready = await feedbackMessage.TextContentAsync();

            if (appliedAlready!.Contains("Candidatou-se"))
            {
                await AddMessageToRichTextbox("!Vaga já candidatada!\n");
            }
        }

        //Nextpage
        private async Task<bool> GoToNextPage(IPage page, int currentPage, int appliedJobs, int savedJobs)
        {
            var nextPageButton = await page.QuerySelectorAsync($"button[aria-label='Página {currentPage + 1}']");
            if (nextPageButton != null)
            {
                await nextPageButton.ClickAsync();
                return true;
            }
            else
            {
                MessageBox.Show("Limite de páginas excedido, não há mais vagas para se candidatar", "Limite excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                await AddMessageToRichTextbox(stringPatterns.ShowFinalResult(appliedJobs, savedJobs));
                return false;
            }
        }
        //UI
        private async Task ShowAppliedJobsMessage(int jobsCounter, int appliedJobs)
        {
            await AddMessageToRichTextbox($"Inscrito na vaga nº{jobsCounter}");
            await AddMessageToRichTextbox($"Total de {appliedJobs} vagas aplicadas");
        }

        private async Task AddMessageToRichTextbox(string message)
        {
            _automationView.RichtxtBox += $"{message}\n";
            await Task.Delay(TimeSpan.FromSeconds(0.1));
        }
    }
}
