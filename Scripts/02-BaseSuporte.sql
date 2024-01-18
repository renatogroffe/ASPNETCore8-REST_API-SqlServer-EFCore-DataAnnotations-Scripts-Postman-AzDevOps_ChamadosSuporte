USE BaseSuporte
GO

CREATE TABLE [dbo].[Chamados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataAbertura] [datetime2](7) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[DescritivoRequisicao] [varchar](500) NOT NULL,
	[Solucionado] [bit] NOT NULL
)
GO

ALTER TABLE [dbo].[Chamados] ADD  CONSTRAINT [PK_Chamados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
GO

PRINT 'Tabela dbo.Chamados criada com sucesso!'