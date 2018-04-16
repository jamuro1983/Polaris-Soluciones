CREATE TABLE [dbo].[Pais] (
    [IdPais]          CHAR (3)     NOT NULL,
    [DescripcionPais] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED ([IdPais] ASC)
);

