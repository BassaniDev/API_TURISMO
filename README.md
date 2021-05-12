# API_TURISMO

API para o cadastro e listagem de pontos turísticos do país

### Tabela de conteúdos
=================
<!--ts-->
   * [Tabela de Conteudo](#tabela-de-conteudo)
   * [Tecnologias](#tecnologias)
   * [Como usar](#como-usar)
  <!--te-->
=================
   
###  Tecnologias

Para começar, a seguintes ferramentas foram usadas na construção do projeto:
- [Git](https://git-scm.com)
- [VisualStudio 2019](https://visualstudio.microsoft.com).
- [SQL Server Management Studio](https://www.microsoft.com/pt-br/sql-server/)

###  Como usar
```bash

#### Clone este repositório

Escolha e entra na pasta onde queria colocar o repositório.
Clique com o botão direito na pasta e escolha a opção: "Git Bash Here"
Digite o seguinte comando no cmd do Git:
$ git clone <https://github.com/BassaniDev/API_TURISMO.git>

#### Configurações para rodar a API

- Para o primeiro passo temos que criar um banco de dados em sua maquina

Abra o Visual Studio, com a solução do projeto que foi clonado.
Entre no arquivo "appsettings.json", e coloque o nome do seu servidor no lugar de "Bassani".
No VisualStudio, procure por: Ferramentas/Gerenciador de Pacotes do NuGet/Console de Gerenciador de Pacotes
No console digite: Update-Database

- Agora temos que dar INSERT de dados no SQL Server

Antes de continuar, abra o arquivo .TXT no diretorio do projeto, chamado de "InsertSqlServerComand.txt".
Agora abra o SQL Server e faça sua conexão, depois encontre o banco de dados que foi criado com o nome: "API_TURISMO".
Clique com botão direito nele e escolha a opção "Nova Consulta".
Cole todo o o texto do arquivo "InsertSqlServerComand.txt", na aba do SLQ Server "Nova Consulta" que você acabou de abrir.
Clique no botão "Executar" do SQL Server.

#### Utilizando a API

- Método utilizando o Visual Studio

Abra seu VisualStudio, com a solução do projeto.
E execute a compilação via "IIS Express" do projeto


- Método utilizando .exe no diretorio do projeto

Nos arquivos do projeto, entre na pasta: "ApplicationWeb".
Execute o API_TURISMO.exe que está na pasta.
Abra seu Navegador e digite a URL que irá aparecer no cmd que você abriu.
