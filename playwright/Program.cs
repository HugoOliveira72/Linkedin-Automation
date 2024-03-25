
using Linkedin_Automation.Config;
using Linkedin_Automation.Credencials;
using Linkedin_Automation.Model;
using Linkedin_Automation.Utilities;
using Microsoft.Playwright;
using System.Text;


public class Program
{
    private static int JOBS = 10;   //VARIAVEL GLOBAL = N° DE VAGAS QUE SERÃO CANDIDATADAS
    internal static string LOGPATH = "../../../Files/log.txt";  //Mudar o diretório (opcional)
    private static string? LOGTEXT;

    static async Task Main(string[] args)
    {
        // CRIAÇÃO LOG.TXT, CASO Ñ HOUVER
        StringUtilities stringUtilities = new StringUtilities();
        LogUtilities logUtilities = new LogUtilities();

        // VERIFICAÇÃO EXISTENCIA LOG.TXT
        if (!File.Exists(LOGPATH))
            logUtilities.createLogFile();

        // CONFIGURAÇÃO DO PLAYWRIGHT
        PlaywrightConfiguration playwrightConfiguration = new PlaywrightConfiguration();
        var settings = await playwrightConfiguration.launchSettingsAsync();

        Thread.Sleep(TimeSpan.FromSeconds(1));

        var page = await settings.BrowserContext!.NewPageAsync();

        // AJUSTAR RESOLUÇÃO DE TELA
        await page.SetViewportSizeAsync(1920, 1080);

        Thread.Sleep(TimeSpan.FromSeconds(1));

        await page.GotoAsync("https://www.linkedin.com/jobs/search/?position=1&pageNum=0");

        Console.WriteLine("Fazendo login..");

        Thread.Sleep(TimeSpan.FromSeconds(5));

        await page.GetByLabel("Principal").GetByRole(AriaRole.Link, new() { Name = "Entrar" }).ClickAsync();

        Thread.Sleep(TimeSpan.FromSeconds(1));

        // LER DADOS DOS USUARIOS
        Credencials credencials = new Credencials();
        User userInfo = credencials.User;

        // PREENCHIMENTO DAS CREEDENCIAIS
        await page.GetByLabel("E-mail ou telefone").ClickAsync();

        await page.GetByLabel("E-mail ou telefone").FillAsync(userInfo.email);

        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByLabel("Senha").ClickAsync();

        await page.GetByLabel("Senha").FillAsync(userInfo.password);

        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByLabel("Entrar", new() { Exact = true }).ClickAsync();

        var errorLogin = await page.QuerySelectorAsync("div[error-for=\"password\"]");
        if (errorLogin != null)
        {
            stringUtilities.errorPattern("LOGIN INCORRETO", null, true);
            Console.ReadKey();
            return;
        }

        // CÓDIGO LINKEDIN (OPCIONAL)
        /// FAZER MANUALMENTE a verificação do código
        Thread.Sleep(TimeSpan.FromSeconds(2));

        try
        {
            Console.WriteLine("==============\n\aAtive o código exibido na tela no seu email nos proximos 60 segundos");
            await page.WaitForSelectorAsync(".jobs-search-box__inner", new() { State = WaitForSelectorState.Visible, Timeout = 60000 });
            Console.WriteLine("Código ativado com sucesso!");
        }
        catch (Exception e)
        {
            LOGTEXT = stringUtilities.errorPattern($"Erro ao ativar o código:", e, true);
            logUtilities.writeError(LOGTEXT);
            Console.ReadKey();
            return;
        }

        Thread.Sleep(TimeSpan.FromSeconds(2));

        // PESQUISA DE VAGAS
        await page.GetByRole(AriaRole.Combobox, new() { Name = "Pesquisar cargo, competência" }).ClickAsync();
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByRole(AriaRole.Combobox, new() { Name = "Pesquisar cargo, competência" }).FillAsync(".net junior");
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByRole(AriaRole.Combobox, new() { Name = "Pesquisar cargo, competência" }).PressAsync("Enter");
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        // APLICAÇÃO DE FILTROS
        /*
            - Nível de experiencia - JR
            - Local: Remoto, Hibrido
            - Canditadura simplificada: TRUE
        */
        await page.GetByLabel("Exibir todos os filtros. Ao").ClickAsync();
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = "Júnior Filtrar por Júnior" }).ClickAsync();
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = "Remoto Filtrar por Remoto" }).ClickAsync();
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByLabel("Todos os filtros", new() { Exact = true }).Locator("label").Filter(new() { HasText = "Híbrido Filtrar por Híbrido" }).ClickAsync();
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByText("Desativada Alternar filtro Candidatura simplificada").ClickAsync();
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByLabel("Todos os filtros", new() { Exact = true }).PressAsync("Enter");
        Thread.Sleep(TimeSpan.FromSeconds(0.8));

        await page.GetByLabel("Aplicar filtros atuais para").ClickAsync();
        Thread.Sleep(TimeSpan.FromSeconds(3));

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
        Console.WriteLine($"Empregos disponiveis: {avaiableJobs}");
        Thread.Sleep(TimeSpan.FromSeconds(1));

        while (appliedJobs != JOBS)
        {
            try
            {
                jobsCounter++;

                if (jobsCounter > ulElementsJobs.Count())
                {
                    // CLICA PAGINAS EM ORDEM CRESCENTE
                    var nextPageButton = await page.QuerySelectorAsync($"button[aria-label='Página {currentPage + 1}']");
                    Thread.Sleep(TimeSpan.FromSeconds(1));

                    // VERIFICA EXISTENCIA DA PROXIMA PÁGINA
                    if (nextPageButton != null) /// TRUE, Clica proxima pagina
                        await nextPageButton.ClickAsync();
                    else ///FALSE,  Erro, pagina não existente    
                    {
                        stringUtilities.errorPattern("Limite de páginas excedido, não há mais vagas para se candidatar");
                        stringUtilities.finishPattern(appliedJobs, savedJobs);
                        Console.ReadKey();
                        return;
                    }
                    currentPage++;

                    // RECARREGA LISTA DE VAGAS (pagina nova)
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    ulElementsJobs = await page.QuerySelectorAllAsync("li[class*='jobs-search-results__list-item']");
                    jobsCounter = 1;
                }

                Console.WriteLine("==================================");
                Console.WriteLine($"Página {currentPage}");
                Console.WriteLine($"Vaga nº {jobsCounter}");

                try
                {
                    int indexJob = jobsCounter - 1;
                    await ulElementsJobs[indexJob].ClickAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\n\n\n\n======================================", e);
                }

                // SELECIONAR DIV SUPERIOR (Div que contem descrição da vaga, botoes)
                Thread.Sleep(TimeSpan.FromSeconds(1));
                var supDivElement = await page.QuerySelectorAsync("div[class*='jobs-unified-top-card']");

                // ============= ETAPA DE CANDIDATURA =============
                // BOTÃO CANDIDATURA SIMPLIFICADA
                var buttonHandle = await supDivElement!.QuerySelectorAsync("button:has-text('Candidatura simplificada')");
                Thread.Sleep(TimeSpan.FromSeconds(1));

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
                        Thread.Sleep(TimeSpan.FromSeconds(0.8));
                        var saveButton = await supDivElement.QuerySelectorAsync("button[class*='jobs-save-button']");

                        Thread.Sleep(TimeSpan.FromSeconds(0.8));
                        var jobAlreadySaved = await saveButton.QuerySelectorAsync("span:has-text('Salvos')");
                        if (jobAlreadySaved != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("VAGA JÁ FOI SALVA ANTERIORMENTE");
                            Console.ResetColor(); // Resetar a cor para o padrão
                            continue;
                        }

                        Thread.Sleep(TimeSpan.FromSeconds(0.8));
                        await saveButton.ClickAsync();

                        Thread.Sleep(TimeSpan.FromSeconds(0.8));
                        Console.WriteLine($"Salva a vaga nº{jobsCounter}");
                        Thread.Sleep(TimeSpan.FromSeconds(0.8));
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Total de {savedJobs} vagas salvas");
                        Console.ResetColor(); // Resetar a cor para o padrão

                        continue;
                    }

                    // VERIFICAR SE VAGA JA FOI INSCRITA
                    var feedbackMessage = await supDivElement.QuerySelectorAsync("span[class='artdeco-inline-feedback__message']");

                    string appliedAlready = await feedbackMessage.TextContentAsync();

                    if (appliedAlready!.Contains("Candidatou-se"))
                    {
                        Console.WriteLine("!Vaga já candidatada!");
                        continue;
                    }
                }

                // BOTÃO AVANÇAR
                Thread.Sleep(TimeSpan.FromSeconds(1));
                var advanceButton = await page.QuerySelectorAsync("button[aria-label='Avançar para próxima etapa']");

                if (advanceButton == null)// QUANDO BOTÃO AVANÇAR Ñ EXISTE
                {
                    /// CLICA BOTÃO ENVIAR CANDIDATURA
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    var buttonSendSubscribe = await page.QuerySelectorAsync("button:has-text('Enviar candidatura')");
                    await buttonSendSubscribe!.ClickAsync();

                    /// CLICA BOTÃO FECHAR
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    var closeButton = await page.QuerySelectorAsync("button[aria-label='Fechar']");
                    await closeButton!.ClickAsync();

                    appliedJobs++;

                    /// EXIBE NA TELA INFORMAÇÕES DA CANDIDATURA
                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    Console.WriteLine($"Inscrito na vaga nº{jobsCounter}");
                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Total de {appliedJobs} vagas aplicadas");
                    Console.ResetColor(); // Resetar a cor para o padrão
                    continue;
                }
                else // QUANDO BOTÃO AVANÇAR EXISTE!
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    try
                    {
                        /// CLICA NO BOTÃO AVANÇAR
                        await advanceButton!.ClickAsync();
                    }
                    catch (Exception e)
                    {
                        /// ERRO AO CLICAR NO BOTÃO
                        LOGTEXT = stringUtilities.errorPattern($"Não foi possivel clicar no botão avançar!", e);
                        logUtilities.writeError(LOGTEXT);
                        continue;
                    }
                }

                //BOTÃO REVISAR
                Thread.Sleep(TimeSpan.FromSeconds(1));
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
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        await advanceButton.ClickAsync();
                    }
                }

                //PERGUNTAS ADICIONAIS
                Thread.Sleep(TimeSpan.FromSeconds(1));
                var additionalQuestions = await page.QuerySelectorAsync("h3");
                if (additionalQuestions!.ToString()!.Contains("Revise sua candidatura")) // QUANDO Ñ HÁ PERGUNTAS
                {
                    // ENVIAR CANDIDATURA, SEM PERGUNTAS
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    var buttonSendCand = await page.QuerySelectorAsync("button:has-text('Enviar candidatura')");
                    await buttonSendCand!.ClickAsync();

                    // FECHAR
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    var closebutton = await page.QuerySelectorAsync("button[aria-label='Fechar']");
                    await closebutton!.ClickAsync();

                    appliedJobs++;

                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    Console.WriteLine($"Inscrito na vaga nº{jobsCounter}");
                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    Console.WriteLine($"Total de {appliedJobs} vagas aplicadas");
                    stringUtilities.finishPattern(appliedJobs, savedJobs);
                    continue;
                }
                else if (additionalQuestions != null) // QUANDO HÁ PERGUNTAS
                {
                    // FECHAR
                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    var closebutton = await page.QuerySelectorAsync("button[aria-label='Fechar']");
                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    await closebutton!.ClickAsync();

                    // SALVAR
                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    var saveButton = await page.QuerySelectorAsync("span:has-text('Salvar')");
                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    await saveButton!.ClickAsync();

                    savedJobs++;

                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    Console.WriteLine($"Salva a vaga nº{jobsCounter}");
                    Thread.Sleep(TimeSpan.FromSeconds(0.8));
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Total de {savedJobs} vagas salvas");
                    Console.ResetColor(); // Resetar a cor para o padrão
                    continue;
                }
            }
            catch (Exception e)
            {
                LOGTEXT = stringUtilities.errorPattern("Erro genérico: ", e, true);
                logUtilities.writeError(LOGTEXT);
                Console.ReadKey();
                return;
            }
        }
    }
}