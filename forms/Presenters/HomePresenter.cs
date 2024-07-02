using forms.Models.Filters;
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

namespace forms.Presenters
{
    public class HomePresenter
    {
        private IHomeView _homeView;
        private IDataService<dynamic> _dataService;
        private ILogService _logService;
        private ILoginRepository _loginRepository;
        private ILogRepository _logRepository;
        private OutputStringPatterns stringPatterns = new();
        private PlaywrightUtilities playwrightUtilities = new();
        public CancellationTokenSource cancellationToken = new();

        public HomePresenter(
            IHomeView homeView,
            IDataService<dynamic> dataService,
            ILogService logService,
            ILoginRepository loginRepository,
            ILogRepository logRepository)
        {
            _homeView = homeView;
            _dataService = dataService;
            _logService = logService;
            _homeView.StartAutomation += StartAutomation;
            _homeView.StopAutomation += StopAutomation;
            _loginRepository = loginRepository;
            _logRepository = logRepository;
        }

        private async void StartAutomation(object sender, EventArgs e)
        {
            ///Desativar botão play
            _homeView.ButtonPlayEnabled = false;
            await Script(cancellationToken.Token);
        }

        private void StopAutomation(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
        }

        //Automation Method
        private async Task Script(CancellationToken token)
        {
            // OBTEM DADOS DOS FILTROS
            FilterFieldsModel filterData = _dataService.GetData();

            // VERIFICAÇÃO EXISTENCIA LOG.TXT
            _logService.LogFileExistingVerification();

            // CONFIGURAÇÃO DO PLAYWRIGHT
            IConfigRepository configRepository = new ConfigRepository();
            PlaywrightConfiguration playwrightConfiguration = new PlaywrightConfiguration(configRepository);
            var settings = await playwrightConfiguration.launchSettingsAsync();

            //INICIO
            await AddMessageToRichTextbox(stringPatterns.linePattern());
            await AddMessageToRichTextbox("Iniciando automação\n");
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
            UserModel userInfo = _loginRepository.ReadAndConvertMsgpackFileToObject();

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
            await AddMessageToRichTextbox("Verifação de segurança\n");
            var message = await playwrightUtilities.WaitForElementAndHandleExceptionAsync(page, "#global-nav-typeahead", "Página carregada!", ExceptionMessages.SecurityError);
            await AddMessageToRichTextbox(message);
            await Task.Delay(TimeSpan.FromSeconds(2));
            #endregion

            #region JobPage Search Section
            // PESQUISA DE VAGAS
            await AddMessageToRichTextbox(stringPatterns.linePattern());
            await AddMessageToRichTextbox($"Pesquisando a vaga {_homeView.Job}\n");

            FeedPage feedPage = await FeedPage.BuildAsync(page);
            await feedPage._jobSpan!.ClickAsync();

            JobPage jobPage = await JobPage.BuildAsync(page);
            await jobPage.SearchJobAsync(_homeView.Job);

            await AddMessageToRichTextbox($"Pesquisado {_homeView.Job} com sucesso\n");
            await Task.Delay(TimeSpan.FromSeconds(2));
            #endregion

            #region FilterSection
            await AddMessageToRichTextbox(stringPatterns.linePattern());
            if (filterData != null)
            {
                FilterSection jobSearchPage = await FilterSection.BuildAsync(page);

                await AddMessageToRichTextbox("Aplicando filtros\n");
                await jobSearchPage.GoToFilterSection(0.8);

                ///Classificar por
                await AddMessageToRichTextbox(FilterLabelsModel.ClassifyByLabel);
                await jobSearchPage.SelectFilter(filterData.ClassifyBy);
                ///Data do anúncio
                await AddMessageToRichTextbox(FilterLabelsModel.AnnouncimentDateLabel);
                await jobSearchPage.SelectFilter(filterData.AnnoucementDate);
                ///Nível de experiência
                await AddMessageToRichTextbox(FilterLabelsModel.ExperienceLevelLabel);
                await jobSearchPage.SelectFilter(FilterLabelsModel.ExperienceLevelLabel, filterData.CheckedListBoxExperiences);
                ///Tipo de vaga
                await AddMessageToRichTextbox(FilterLabelsModel.JobTypeLabel);
                await jobSearchPage.SelectFilter(FilterLabelsModel.JobTypeLabel, filterData.CheckedListBoxType_job);
                ///Remoto
                await AddMessageToRichTextbox(FilterLabelsModel.RemoteTypeLabel);
                await jobSearchPage.SelectFilter(FilterLabelsModel.RemoteTypeLabel, filterData.CheckedListBoxRemote);

                ///Apply All filters
                await jobSearchPage.ApplyFilter();

            }
            else
            {
                await AddMessageToRichTextbox("Não há filtros para serem aplicados!\n");
            }
            await Task.Delay(TimeSpan.FromSeconds(3));
            #endregion

            //JOB LIST SECTION
            #region GetAllJobs Elements
            /*
                - avaiableJobs, Vagas disponiveis podem ser candidadatas
                - appliedJobs, Vagas candidatadas
                - savedJobs, Vagas que contem perguntas, são salvas para preenchimento manual posterior
            */
            int currentPage = 1, jobsCounter = 0, appliedJobs = 0, savedJobs = 0;

            // Instancia jobListSection
            await AddMessageToRichTextbox(stringPatterns.linePattern());
            JobListSection jobListSection = await JobListSection.BuildAsync(page, currentPage);
            int avaiableJobs = jobListSection.getAvailableJob();
            await AddMessageToRichTextbox($"Quantidade de vagas encontradas: {avaiableJobs}!");
            await Task.Delay(TimeSpan.FromSeconds(1));

            #endregion

            //HABILITAR O BOTÃO SAIR
            _homeView.ButtonStopEnabled = true;

            //APLICAÇÃO DE VAGAS
            while (appliedJobs != Int32.Parse(_homeView.AmountJobs))
            {
                try
                {
                    if (token.IsCancellationRequested)
                    {
                        ///Fechar o navegador
                        await settings.BrowserContext.CloseAsync();
                        ///Ativar o botão play
                        _homeView.ButtonPlayEnabled = true;
                        break;
                    }
                    jobsCounter++;

                    //JOB LIST SECTION
                    #region NextPageValidation
                    if (jobsCounter > avaiableJobs)
                    {
                        ///Possui próxima página
                        bool hasNextPage = await jobListSection.GoToNextPage();
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
                            await AddMessageToRichTextbox(stringPatterns.linePattern());
                            await AddMessageToRichTextbox($"Vagas encontradas: {avaiableJobs}");
                        }
                    }
                    #endregion

                    await AddMessageToRichTextbox(stringPatterns.linePattern());
                    await AddMessageToRichTextbox($"Percorrendo Página {currentPage}");
                    await AddMessageToRichTextbox($"Selecionando Vaga nº {jobsCounter}");

                    #region SelectJob
                    try
                    {
                        await jobListSection.ClickOnJob(jobsCounter);
                    }
                    catch (Exception e)
                    {
                        await AddMessageToRichTextbox($"\n\n{stringPatterns.linePattern}{e}");
                        _logRepository.WriteALogError(ExceptionMessages.ErrorToSelectJob, e);
                    }
                    #endregion

                    //DETAIL SECTION
                    #region Handle subscribe button
                    JobDetailsSection jobDetailsSection = await JobDetailsSection.BuildAsync(page);
                    // BOTÃO (Candidatar-se a vaga)
                    if (jobDetailsSection._subscribeButton == null)
                    {
                        // VERIFICAR SE VAGA ESTÁ INCOMPLETA (Continue)
                        if (jobDetailsSection._continueButton != null)
                        {
                            // SALVAR VAGA
                            if (jobDetailsSection._jobAlreadySaved != null)
                            {
                                await AddMessageToRichTextbox("VAGA JÁ FOI SALVA!");
                            }
                            else
                            {
                                await jobDetailsSection._saveButton!.ClickAsync();
                                savedJobs = SetAndCountSavedJobs(savedJobs);
                                await ShowSavedJobsMessage(jobsCounter, savedJobs);
                            }
                        }
                        else if (await jobDetailsSection.CheckSubscribedStatus())
                        {
                            // VERIFICAR SE VAGA JA FOI INSCRITA
                            await AddMessageToRichTextbox("!Vaga já candidatada!");
                        }
                        continue;
                    }
                    else
                    {
                        // SE INSCREVE NA VAGA
                        await jobDetailsSection._subscribeButton!.ClickAsync();
                    }
                    #endregion 

                    //POPUP WINDOW SECTION
                    #region Advance button
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    PopupWindowSection popupWindowSection = await PopupWindowSection.BuildAsync(page);
                    if (popupWindowSection._advanceButton == null)// QUANDO BOTÃO AVANÇAR Ñ EXISTE
                    {
                        /// CLICA BOTÃO ENVIAR CANDIDATURA
                        await popupWindowSection.SendJobApplicationAndClosePage();

                        /// EXIBE NA TELA INFORMAÇÕES DA CANDIDATURA
                        appliedJobs = await SetAndCountAppliedJobsAndShow(appliedJobs, jobsCounter);
                        continue;
                    }
                    else // QUANDO BOTÃO AVANÇAR EXISTE!
                    {
                        try
                        {
                            /// CLICA NO BOTÃO AVANÇAR
                            await popupWindowSection._advanceButton!.ClickAsync();
                        }
                        catch (Exception e)
                        {
                            /// ERRO AO CLICAR NO BOTÃO
                            _logRepository.WriteALogError(ExceptionMessages.CouldNotClickedTheAdvanceButton, e);
                            continue;
                        }
                    }
                    #endregion

                    #region Review button
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    popupWindowSection._reviewButton = await popupWindowSection.LoadElementAsync("span:has-text('Revisar')");
                    popupWindowSection._advanceButton = await popupWindowSection.LoadElementAsync("button[aria-label='Avançar para próxima etapa']");
                    if (popupWindowSection._reviewButton == null) // QUANDO BOTÃO REVISAR Ñ EXISTE
                        await popupWindowSection._advanceButton.ClickAsync(); /// Haverá o botão avançar
                    else// QUANDO BOTÃO REVISAR EXISTE
                    {
                        try
                        {
                            await popupWindowSection._reviewButton!.ClickAsync();
                        }
                        catch (Exception e)
                        {
                            await Task.Delay(TimeSpan.FromSeconds(1));
                            _logRepository.WriteALogError(ExceptionMessages.CouldNotClickedTheAdvanceButton, e);
                        }
                    }
                    #endregion

                    #region Addicional Questions
                    await Task.Delay(TimeSpan.FromSeconds(0.8));
                    popupWindowSection._additionalQuestions = await popupWindowSection.LoadElementAsync("h3");
                    popupWindowSection._advanceButton = await popupWindowSection.LoadElementAsync("button[aria-label='Avançar para próxima etapa']");
                    if (!await popupWindowSection.CheckAddicionalQuestions()) // QUANDO NÃO HÁ PERGUNTAS
                    {
                        // ENVIAR CANDIDATURA, SEM PERGUNTAS
                        await popupWindowSection.SendJobApplicationAndClosePage();

                        appliedJobs = await SetAndCountAppliedJobsAndShow(appliedJobs, jobsCounter);
                        await AddMessageToRichTextbox(stringPatterns.ShowFinalResult(appliedJobs, savedJobs));
                        continue;
                    }
                    else if (popupWindowSection._additionalQuestions != null) // QUANDO HÁ PERGUNTAS
                    {
                        await popupWindowSection.SaveJobClosePage();
                        savedJobs = SetAndCountSavedJobs(savedJobs);
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        await AddMessageToRichTextbox($"Salva a vaga nº{jobsCounter}");
                        await Task.Delay(TimeSpan.FromSeconds(0.8));
                        await AddMessageToRichTextbox(stringPatterns.ShowFinalResult(appliedJobs, savedJobs));
                        continue;
                    }
                    else if (popupWindowSection._advanceButton != null)
                    {
                        await popupWindowSection._advanceButton.ClickAsync();
                    }
                    #endregion
                }
                catch (Exception e)
                {
                    _logRepository.WriteALogError(ExceptionMessages.CommonError, e);
                    return;
                }
            }
        }

        //UI
        private async Task ShowAppliedJobsMessage(int jobsCounter, int appliedJobs)
        {
            await AddMessageToRichTextbox($"Inscrito na vaga nº{jobsCounter}");
            await AddMessageToRichTextbox($"Total de {appliedJobs} vagas aplicadas");
        }

        private async Task ShowSavedJobsMessage(int jobsCounter, int savedJobs)
        {
            await AddMessageToRichTextbox($"Vaga nº{jobsCounter} Salva");
            await AddMessageToRichTextbox($"Total de {savedJobs} vagas salvas");
        }

        private async Task AddMessageToRichTextbox(string message)
        {
            _homeView.RichtxtBox += $"{message}\n";
            await Task.Delay(TimeSpan.FromSeconds(0.1));
        }

        //LOGIC/UI
        private async Task<int> SetAndCountAppliedJobsAndShow(int amountOfAppliedJobs, int counterOfJobs)
        {
            amountOfAppliedJobs++;
            _homeView.AmountOfAppliedJobs = amountOfAppliedJobs;
            await ShowAppliedJobsMessage(counterOfJobs, amountOfAppliedJobs);
            return amountOfAppliedJobs;
        }

        private int SetAndCountSavedJobs(int amountOfsavedJobs)
        {
            amountOfsavedJobs++;
            _homeView.AmountOfSavedJobs = amountOfsavedJobs;
            return amountOfsavedJobs;
        }
    }
}
