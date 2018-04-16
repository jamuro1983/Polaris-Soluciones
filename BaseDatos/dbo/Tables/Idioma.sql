CREATE TABLE [dbo].[Idioma] (
    [IdIdioma]          INT          IDENTITY (1, 1) NOT NULL,
    [DescripcionIdioma] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED ([IdIdioma] ASC)
);

