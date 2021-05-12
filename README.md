# API_TURISMO

<p align="center"> API para o cadastro e listagem de pontos tur�sticos do pa�s</p>

### Tabela de conte�dos
=================
<!--ts-->
   * [Tabela de Conteudo](#tabela-de-conteudo)
   * [Tecnologias](#tecnologias)
   * [Como usar](#como-usar)
  <!--te-->
=================
   
### ?? Tecnologias

Para come�ar, a seguintes ferramentas foram usadas na constru��o do projeto:
- [Git](https://git-scm.com)
- [VisualStudio 2019](https://visualstudio.microsoft.com).
- [SQL Server Management Studio](https://www.microsoft.com/pt-br/sql-server/)

### ?? Como usar

```bash
# Clone este reposit�rio
$ git clone <https://github.com/BassaniDev/API_TURISMO.git>

# Configura��es para rodar a API

- Para o primeiro passo temos que criar um banco de dados em sua maquina

Abra o Visual Studio, com a solu��o do projeto que foi clonado.
Entre no arquivo "appsettings.json", e coloque o nome do seu banco de dados no lugar de "Bassani".
No VisualStudio, procure por: Ferramentas/Gerenciador de Pacotes do NuGet/Console de Gerenciador de Pacotes
No console digite: Update-Database

- Agora temos que dar INSERT de dados no SQL Server

Antes de continuar, abra o arquivo .TXT no diretorio do projeto, chamado de "InsertSqlServerComand.txt".
Agora abra o SQL Server e fa�a sua conex�o, depois encontre o banco de dados que foi criado com o nome: "API_TURISMO".
Clique com bot�o direito nele e escolha a op��o "Nova Consulta".
Cole todo o o texto do arquivo "InsertSqlServerComand.txt", na aba do SLQ Server "Nova Consulta" que voc� acabou de abrir.
Clique no bot�o "Executar" do SQL Server.

# Utilizando a API

- M�todo utilizando o Visual Studio

Abra seu VisualStudio, com a solu��o do projeto.
E execute a compila��o via "IIS Express" do projeto


- M�todo utilizando .exe no diretorio do projeto

Nos arquivos do projeto, entre na pasta: "ApplicationWeb".
Execute o API_TURISMO.exe que est� na pasta.
Abra seu Navegador e digite a URL que ir� aparecer no cmd que voc� abriu.
