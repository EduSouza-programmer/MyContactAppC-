# Meu Aplicativo de Contatos

Este é um aplicativo de console desenvolvido em C# que permite aos usuários salvar e recuperar informações de contato usando ADO.NET para interagir com um banco de dados MySQL/MariaDB.

## Estrutura do Projeto

```
meu-aplicativo-de-contatos
├── Program.cs
├── App.config
├── Models
│   └── Contact.cs
├── Data
│   ├── ContactContext.cs
│   └── Migrations
│       └── InitialCreate.sql
├── Services
│   └── ContactService.cs
└── README.md
```

## Arquivos

### `Program.cs`

Este arquivo é o ponto de entrada do aplicativo de console. Ele contém o método `Main` que é o ponto de partida do programa. Ele inicializa os componentes necessários e interage com o usuário para adicionar ou recuperar contatos.

### `App.config`

Este arquivo é o arquivo de configuração para o aplicativo. Ele contém a string de conexão para o banco de dados MySQL/MariaDB.

### `Models/Contact.cs`

Este arquivo define a classe `Contact` que representa um contato. Ele tem propriedades para o nome do contato, número de telefone, número de celular, email e tipo.

### `Data/ContactContext.cs`

Este arquivo define a classe `ContactContext` que é responsável por interagir com o banco de dados usando ADO.NET. Ele herda da classe `DbContext` e contém uma propriedade `DbSet` para a entidade `Contact`.

### `Data/Migrations/InitialCreate.sql`

Este arquivo contém o script de migração inicial do banco de dados. Ele cria a tabela `Contacts` com colunas para o nome do contato, número de telefone, número de celular, email e tipo.

### `Services/ContactService.cs`

Este arquivo define a classe `ContactService` que fornece métodos para adicionar e recuperar contatos. Ele usa a classe `ContactContext` para interagir com o banco de dados.

## Instalação

Antes de executar o projeto, você precisará instalar as dependências. Siga os passos abaixo:

1. Instale o [.NET Core SDK](https://dotnet.microsoft.com/download) na sua máquina. Verifique a versão instalada com o comando `dotnet --version` no terminal. Deve ser compatível com a versão definida no arquivo `.csproj` do projeto.

2. Clone o repositório do projeto para a sua máquina local usando `git clone`.

3. Navegue até o diretório do projeto usando o comando `cd nome-do-projeto`.

4. Execute o comando `dotnet restore` para instalar as dependências do projeto.

Agora você pode seguir as instruções na seção [Uso](#uso) para executar o aplicativo.

## Uso

1. Configure um banco de dados MySQL/MariaDB.
2. Atualize a string de conexão no arquivo `App.config` com suas credenciais de banco de dados.
3. Execute o comando `dotnet run` no terminal para construir e executar o aplicativo.
4. Use o menu do console para adicionar novos contatos ou recuperar contatos existentes.

## Dependências

- .NET Framework 4.7.2 ou superior
- Banco de dados MySQL/MariaDB

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).