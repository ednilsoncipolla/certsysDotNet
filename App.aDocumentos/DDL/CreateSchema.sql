IF(DB_ID('certsysDb') is null) 
begin
	create database certsysDb
end;
GO

use certsysDb;
GO

if object_id('Usuarios') is null
begin
	CREATE TABLE [dbo].[Usuarios](
		[Id] [integer] identity NOT NULL,
		[Login] [varchar](50) NOT NULL,
		[Senha] [varchar](20) NOT NULL,
		[CreatedAt] [datetime] NOT NULL,
		[UpdateAt] [datetime] NULL,
		[Ativo] [bit] NOT NULL Default (1),
	 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([Id] ASC)
	) ON [PRIMARY]
end;
GO

if object_id('Fornecedores') is null
begin
	CREATE TABLE [Fornecedores](
		[Id] [integer] identity NOT NULL,
		[Nome] [varchar](200) NOT NULL,
		[Cnpj] [varchar](20) NOT NULL,
		[Endereco] [varchar](150) NOT NULL,
		[CreatedAt] [datetime] NOT NULL,
		[UpdateAt] [datetime] NULL,
		[Ativo] [bit] NOT NULL Default (1),
	 CONSTRAINT [PK_Fonecedores] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)
	) ON [PRIMARY]
end;
GO

if object_id('Produtos') is null
begin
	CREATE TABLE [dbo].[Produtos](
		[Id] [integer] identity NOT NULL,
		[Nome] [varchar](50) NOT NULL,
		[Quantidade] [decimal](18, 2) NOT NULL CONSTRAINT [DF_Produtos_Quantidade] DEFAULT ((0)),
		[FornecedorId] [integer] NOT NULL,
		[CreatedAt] [datetime] NOT NULL,
		[UpdateAt] [datetime] NULL,
		[Ativo] [bit] NOT NULL Default (1),
	 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED ([Id] ASC)
	 , CONSTRAINT FK_Produto_Fornecedor FOREIGN KEY ([FornecedorId])
        REFERENCES Fornecedores ([Id])
	) ON [PRIMARY]
end;
GO
