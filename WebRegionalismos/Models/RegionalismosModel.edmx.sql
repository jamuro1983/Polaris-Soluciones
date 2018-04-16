
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/16/2018 13:48:10
-- Generated from EDMX file: C:\Polaris Soluciones\WebRegionalismos\Models\RegionalismosModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbRegionalismos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Definicion_Idioma_IdIdioma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definicion] DROP CONSTRAINT [FK_Definicion_Idioma_IdIdioma];
GO
IF OBJECT_ID(N'[dbo].[FK_Definicion_Pais_IdPais]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definicion] DROP CONSTRAINT [FK_Definicion_Pais_IdPais];
GO
IF OBJECT_ID(N'[dbo].[FK_Definicion_Palabra_IdPalabra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Definicion] DROP CONSTRAINT [FK_Definicion_Palabra_IdPalabra];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Definicion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Definicion];
GO
IF OBJECT_ID(N'[dbo].[Idioma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Idioma];
GO
IF OBJECT_ID(N'[dbo].[Pais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pais];
GO
IF OBJECT_ID(N'[dbo].[Palabra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Palabra];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Definicion'
CREATE TABLE [dbo].[Definicion] (
    [IdDefinicion] int IDENTITY(1,1) NOT NULL,
    [IdPalabra] int  NOT NULL,
    [IdIdioma] int  NOT NULL,
    [Definicion1] varchar(400)  NOT NULL,
    [IdPais] char(3)  NOT NULL
);
GO

-- Creating table 'Idioma'
CREATE TABLE [dbo].[Idioma] (
    [IdIdioma] int IDENTITY(1,1) NOT NULL,
    [DescripcionIdioma] varchar(50)  NOT NULL
);
GO

-- Creating table 'Pais'
CREATE TABLE [dbo].[Pais] (
    [IdPais] char(3)  NOT NULL,
    [DescripcionPais] varchar(50)  NOT NULL
);
GO

-- Creating table 'Palabra'
CREATE TABLE [dbo].[Palabra] (
    [IdPalabra] int IDENTITY(1,1) NOT NULL,
    [DescripcionPalabra] varchar(50)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdDefinicion] in table 'Definicion'
ALTER TABLE [dbo].[Definicion]
ADD CONSTRAINT [PK_Definicion]
    PRIMARY KEY CLUSTERED ([IdDefinicion] ASC);
GO

-- Creating primary key on [IdIdioma] in table 'Idioma'
ALTER TABLE [dbo].[Idioma]
ADD CONSTRAINT [PK_Idioma]
    PRIMARY KEY CLUSTERED ([IdIdioma] ASC);
GO

-- Creating primary key on [IdPais] in table 'Pais'
ALTER TABLE [dbo].[Pais]
ADD CONSTRAINT [PK_Pais]
    PRIMARY KEY CLUSTERED ([IdPais] ASC);
GO

-- Creating primary key on [IdPalabra] in table 'Palabra'
ALTER TABLE [dbo].[Palabra]
ADD CONSTRAINT [PK_Palabra]
    PRIMARY KEY CLUSTERED ([IdPalabra] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdIdioma] in table 'Definicion'
ALTER TABLE [dbo].[Definicion]
ADD CONSTRAINT [FK_Definicion_Idioma_IdIdioma]
    FOREIGN KEY ([IdIdioma])
    REFERENCES [dbo].[Idioma]
        ([IdIdioma])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Definicion_Idioma_IdIdioma'
CREATE INDEX [IX_FK_Definicion_Idioma_IdIdioma]
ON [dbo].[Definicion]
    ([IdIdioma]);
GO

-- Creating foreign key on [IdPalabra] in table 'Definicion'
ALTER TABLE [dbo].[Definicion]
ADD CONSTRAINT [FK_Definicion_Palabra_IdPalabra]
    FOREIGN KEY ([IdPalabra])
    REFERENCES [dbo].[Palabra]
        ([IdPalabra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Definicion_Palabra_IdPalabra'
CREATE INDEX [IX_FK_Definicion_Palabra_IdPalabra]
ON [dbo].[Definicion]
    ([IdPalabra]);
GO

-- Creating foreign key on [IdPais] in table 'Definicion'
ALTER TABLE [dbo].[Definicion]
ADD CONSTRAINT [FK_Definicion_Pais_IdPais]
    FOREIGN KEY ([IdPais])
    REFERENCES [dbo].[Pais]
        ([IdPais])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Definicion_Pais_IdPais'
CREATE INDEX [IX_FK_Definicion_Pais_IdPais]
ON [dbo].[Definicion]
    ([IdPais]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------