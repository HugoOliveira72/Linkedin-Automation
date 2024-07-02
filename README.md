Automação do LinkedIn
Esta é uma aplicação de desktop desenvolvida para automatizar o processo de inscrição em vagas no LinkedIn. 

Ferramentas e bibliotecas
A aplicação foi construída utilizando a C# 8.0, 

  Libs: 
  * Microsoft Playwright Versão 1.42.0
  * Analytics Versão 3.8.1
  * Encoding CodePages Versão 8.0.0

Funcionalidades

* Registro de Credenciais: As credenciais do usuário são armazenadas em um arquivo local chamado user.msgpack, localizado em forms/Files/. O arquivo é gerado assim que o programa iniciar.
* Geração de Arquivo de log: A aplicação gera um arquivo de log que registra erros de execução e a data de execução. Tal arquivo também é gerado assim que o programa é executado.
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
