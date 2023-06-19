CREATE TABLE [dbo].[Pessoa] (
    [id]     INT           NOT NULL,
    [Morada] NVARCHAR (45) NULL,
    [Nome]   NVARCHAR (45) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Funcionario] (
    [id]        INT          NOT NULL,
    [Salario]   VARCHAR (45) NULL,
    [Funcao]    VARCHAR (45) NULL,
    [Pessoa_id] INT          NOT NULL,
    [Morada]    VARCHAR (45) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([Pessoa_id]) REFERENCES [dbo].[Pessoa] ([id])
);

CREATE TABLE [dbo].[Cliente] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [NumFiscal] VARCHAR (50)  NULL,
    [Nome]      VARCHAR (100) NULL,
    [Morada]    VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Cinema] (
    [id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (45)  NULL,
    [Email]  NVARCHAR (45) NULL,
    [Morada] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Sala] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (45) NULL,
    [Colunas]   INT          NULL,
    [Filas]     INT          NULL,
    [Cinema_id] INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([Cinema_id]) REFERENCES [dbo].[Cinema] ([id])
);

CREATE TABLE dbo.Categoria (
  id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  Nome VARCHAR(45) NULL,
  Activa VARCHAR(45) NULL
);

CREATE TABLE [dbo].[Filme] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      NVARCHAR (45) NOT NULL,
    [Duracao]   VARCHAR (45)  NOT NULL,
    [Activo]    NVARCHAR (45) NOT NULL,
    [Categoria] NVARCHAR (45) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Sessao] (
    [id]       INT          IDENTITY (1, 1) NOT NULL,
    [DataHora] DATETIME     NOT NULL,
    [Preco]    VARCHAR (15) NOT NULL,
    [Filme]    VARCHAR (30) NOT NULL,
    [Sala]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Bilhete] (
    [id]             INT          NOT NULL,
    [Lugar]          INT          NULL,
    [Estado]         VARCHAR (45) NULL,
    [Sessao_id]      INT          NOT NULL,
    [Sessao_Sala_id] INT          NOT NULL,
    [Funcionario_id] INT          NOT NULL,
    [Cliente_id]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([Funcionario_id]) REFERENCES [dbo].[Funcionario] ([id])
);

CREATE TABLE [dbo].[Login] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Utilizador] NVARCHAR (50) NOT NULL,
    [Password]   NVARCHAR (50) NOT NULL,
    [Permissoes] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);