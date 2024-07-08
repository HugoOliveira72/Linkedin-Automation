LINKEDIN AUTOMATION

Esta é uma aplicação de desktop desenvolvida para automatizar o processo de inscrição em vagas no LinkedIn. 

Ferramentas e bibliotecas:

*A aplicação foi construída utilizando a C# .NET Versão = 8.0, 

Libs:

* Analytics Versão = 3.8.1
* Krypton Toolkit Versão = 85.24.6.176
* MessagePack Versão = 2.5.168
* Microsoft.Playwright Versão = 1.44.0

Como usar

* Clonar o repositório
* Instalar dependencias do projeto (Instalar as libs com o gerenciador de pacote NuGet, bibliotecas citadas logo acima)
* Dentro do projeto principal forms (ViewPresenter caso a branch for feacture-biblioteca-de-classes) criar a pasta FILES para armazenar os arquivos
  usuário e também o arquivo de log. Atenção! O diretório deve ser criado para não haver erros.

Criação arquivo Files nas branchs Master,dev-mvp,MVP-architecture

![image](https://github.com/HugoOliveira72/Linkedin-automation/assets/84344414/59a9d3c6-9aa9-46f3-a6e2-3c4c5a39f982)

Criação do arquivo Files na branch feature-biblioteca-de-classes

![image](https://github.com/HugoOliveira72/Linkedin-automation/assets/84344414/055b4c9d-e610-448a-a08f-441a266484fc)



* Recompilar e Rodar o projeto
* Inserir usuário e senha da conta do linkedin na tela de LOGIN
* No campo "Cargo ou competência" inserir o cargo
* No campo "N° de vagas" inserir o número de vagas que serão automatizadas
* Ir na aba "configurações" e alterar resolução do navegador (OPCIONAL)
* Ir na aba "filtros" e adicionar filtros para pesquisa de vaga (OPCIONAL)
* Pressionar botão "play" para iniciar o processo
* Pressionar botão "stop" caso queira parar a aplicação

Funcionalidades

* Registro de Credenciais: As credenciais do usuário são armazenadas em um arquivo local chamado user.msgpack, localizado em [viewPresenter]/Files/. O arquivo é gerado assim que o programa iniciar.
* Geração de Arquivo de log: A aplicação gera um arquivo de log que registra erros de execução e a data de execução. Tal arquivo também é gerado em [viewPresenter]/Files assim que o programa é executado.
* Inscrição em Vagas Simplificadas: A aplicação é capaz de se inscrever automaticamente em vagas que possuem um processo de candidatura simplificada.
* Salvamento de Vagas: As vagas que requerem o preenchimento de formulários são salvas, para que o usuário possa continuar o processo de inscrição manualmente em um momento posterior.
* Filtragem de vagas: É possível filtrar o tipo de vaga com a aba filtro. Os filtros são originalmente os mesmos do linkedin.
* Ajuste de resolução do navegador: É possível ajustar a resolução do navegador na aba configuração, havendo as opções:
    * Tela cheia, adequa o navegador ao tamanho padrão de tela do usuário. 
    *Janela, que possui as resoluções:
    1920x1080
    1366x768
    1280x720
* Exibição de Dados Correntes/Console: A aplicação possui um console, que exibe dados correntes e a ação que está ocorrendo no momento.
