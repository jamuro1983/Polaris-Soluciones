CREATE TABLE [dbo].[Definicion] (
    [IdDefinicion] INT           IDENTITY (1, 1) NOT NULL,
    [IdPalabra]    INT           NOT NULL,
    [IdIdioma]     INT           NOT NULL,
    [Definicion]   VARCHAR (400) NOT NULL,
    CONSTRAINT [PK_Definicion] PRIMARY KEY CLUSTERED ([IdDefinicion] ASC),
    CONSTRAINT [FK_Definicion_Idioma_IdIdioma] FOREIGN KEY ([IdIdioma]) REFERENCES [dbo].[Idioma] ([IdIdioma]),
    CONSTRAINT [FK_Definicion_Palabra_IdPalabra] FOREIGN KEY ([IdPalabra]) REFERENCES [dbo].[Palabra] ([IdPalabra])
);

