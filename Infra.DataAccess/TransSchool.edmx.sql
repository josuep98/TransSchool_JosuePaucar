
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/01/2023 20:19:24
-- Generated from EDMX file: C:\@Jp\TransSchool_JosuePaucar\Infra.DataAccess\TransSchool.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TransSchoolJosuePaucar];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Estudiant__Repre__4BAC3F29]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Estudiante] DROP CONSTRAINT [FK__Estudiant__Repre__4BAC3F29];
GO
IF OBJECT_ID(N'[dbo].[FK__Incidenci__RutaI__5165187F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Incidencia] DROP CONSTRAINT [FK__Incidenci__RutaI__5165187F];
GO
IF OBJECT_ID(N'[dbo].[FK__Ruta__Estudiante__4E88ABD4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ruta] DROP CONSTRAINT [FK__Ruta__Estudiante__4E88ABD4];
GO
IF OBJECT_ID(N'[dbo].[FK__RutaTrans__RutaI__5629CD9C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RutaTransporte] DROP CONSTRAINT [FK__RutaTrans__RutaI__5629CD9C];
GO
IF OBJECT_ID(N'[dbo].[FK__RutaTrans__Trans__571DF1D5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RutaTransporte] DROP CONSTRAINT [FK__RutaTrans__Trans__571DF1D5];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Estudiante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estudiante];
GO
IF OBJECT_ID(N'[dbo].[Incidencia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Incidencia];
GO
IF OBJECT_ID(N'[dbo].[Representante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Representante];
GO
IF OBJECT_ID(N'[dbo].[Ruta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ruta];
GO
IF OBJECT_ID(N'[dbo].[RutaTransporte]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RutaTransporte];
GO
IF OBJECT_ID(N'[dbo].[Transporte]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transporte];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Estudiante'
CREATE TABLE [dbo].[Estudiante] (
    [EstudianteId] int IDENTITY(1,1) NOT NULL,
    [Nombres] varchar(60)  NULL,
    [Apellidos] varchar(60)  NULL,
    [Identificacion] varchar(13)  NULL,
    [Telefono] varchar(10)  NULL,
    [FechaNacimiento] datetime  NULL,
    [Nacionalidad] varchar(30)  NULL,
    [Sexo] char(1)  NULL,
    [Dirección] varchar(60)  NULL,
    [Coordenadas] varchar(max)  NULL,
    [RepresentanteId] int  NULL
);
GO

-- Creating table 'Incidencia'
CREATE TABLE [dbo].[Incidencia] (
    [IncidenciaId] int IDENTITY(1,1) NOT NULL,
    [Tipo] char(1)  NULL,
    [Titulo] varchar(20)  NULL,
    [Mensaje] nvarchar(max)  NULL,
    [RutaId] int  NULL
);
GO

-- Creating table 'Representante'
CREATE TABLE [dbo].[Representante] (
    [RepresentanteId] int IDENTITY(1,1) NOT NULL,
    [Nombres] varchar(60)  NULL,
    [Apellidos] varchar(60)  NULL,
    [Identificacion] varchar(13)  NULL,
    [Telefono] varchar(10)  NULL,
    [FechaNacimiento] datetime  NULL,
    [Nacionalidad] varchar(30)  NULL,
    [Sexo] char(1)  NULL,
    [EstadoCivil] char(1)  NULL,
    [Dirección] varchar(60)  NULL
);
GO

-- Creating table 'Ruta'
CREATE TABLE [dbo].[Ruta] (
    [RutaId] int IDENTITY(1,1) NOT NULL,
    [FechaRuta] datetime  NULL,
    [HoraInicio] time  NULL,
    [PuntoInicio] varchar(max)  NULL,
    [HoraFin] time  NULL,
    [PuntoFin] varchar(max)  NULL,
    [EstudianteId] int  NULL
);
GO

-- Creating table 'RutaTransporte'
CREATE TABLE [dbo].[RutaTransporte] (
    [RutaTransporteId] int IDENTITY(1,1) NOT NULL,
    [RutaId] int  NULL,
    [TransporteId] int  NULL
);
GO

-- Creating table 'Transporte'
CREATE TABLE [dbo].[Transporte] (
    [TransporteId] int IDENTITY(1,1) NOT NULL,
    [Placa] varchar(8)  NULL,
    [Tipo] char(1)  NULL,
    [Capacidad] int  NULL,
    [Transportista] varchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EstudianteId] in table 'Estudiante'
ALTER TABLE [dbo].[Estudiante]
ADD CONSTRAINT [PK_Estudiante]
    PRIMARY KEY CLUSTERED ([EstudianteId] ASC);
GO

-- Creating primary key on [IncidenciaId] in table 'Incidencia'
ALTER TABLE [dbo].[Incidencia]
ADD CONSTRAINT [PK_Incidencia]
    PRIMARY KEY CLUSTERED ([IncidenciaId] ASC);
GO

-- Creating primary key on [RepresentanteId] in table 'Representante'
ALTER TABLE [dbo].[Representante]
ADD CONSTRAINT [PK_Representante]
    PRIMARY KEY CLUSTERED ([RepresentanteId] ASC);
GO

-- Creating primary key on [RutaId] in table 'Ruta'
ALTER TABLE [dbo].[Ruta]
ADD CONSTRAINT [PK_Ruta]
    PRIMARY KEY CLUSTERED ([RutaId] ASC);
GO

-- Creating primary key on [RutaTransporteId] in table 'RutaTransporte'
ALTER TABLE [dbo].[RutaTransporte]
ADD CONSTRAINT [PK_RutaTransporte]
    PRIMARY KEY CLUSTERED ([RutaTransporteId] ASC);
GO

-- Creating primary key on [TransporteId] in table 'Transporte'
ALTER TABLE [dbo].[Transporte]
ADD CONSTRAINT [PK_Transporte]
    PRIMARY KEY CLUSTERED ([TransporteId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RepresentanteId] in table 'Estudiante'
ALTER TABLE [dbo].[Estudiante]
ADD CONSTRAINT [FK__Estudiant__Repre__4BAC3F29]
    FOREIGN KEY ([RepresentanteId])
    REFERENCES [dbo].[Representante]
        ([RepresentanteId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Estudiant__Repre__4BAC3F29'
CREATE INDEX [IX_FK__Estudiant__Repre__4BAC3F29]
ON [dbo].[Estudiante]
    ([RepresentanteId]);
GO

-- Creating foreign key on [EstudianteId] in table 'Ruta'
ALTER TABLE [dbo].[Ruta]
ADD CONSTRAINT [FK__Ruta__Estudiante__4E88ABD4]
    FOREIGN KEY ([EstudianteId])
    REFERENCES [dbo].[Estudiante]
        ([EstudianteId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Ruta__Estudiante__4E88ABD4'
CREATE INDEX [IX_FK__Ruta__Estudiante__4E88ABD4]
ON [dbo].[Ruta]
    ([EstudianteId]);
GO

-- Creating foreign key on [RutaId] in table 'Incidencia'
ALTER TABLE [dbo].[Incidencia]
ADD CONSTRAINT [FK__Incidenci__RutaI__5165187F]
    FOREIGN KEY ([RutaId])
    REFERENCES [dbo].[Ruta]
        ([RutaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Incidenci__RutaI__5165187F'
CREATE INDEX [IX_FK__Incidenci__RutaI__5165187F]
ON [dbo].[Incidencia]
    ([RutaId]);
GO

-- Creating foreign key on [RutaId] in table 'RutaTransporte'
ALTER TABLE [dbo].[RutaTransporte]
ADD CONSTRAINT [FK__RutaTrans__RutaI__5629CD9C]
    FOREIGN KEY ([RutaId])
    REFERENCES [dbo].[Ruta]
        ([RutaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RutaTrans__RutaI__5629CD9C'
CREATE INDEX [IX_FK__RutaTrans__RutaI__5629CD9C]
ON [dbo].[RutaTransporte]
    ([RutaId]);
GO

-- Creating foreign key on [TransporteId] in table 'RutaTransporte'
ALTER TABLE [dbo].[RutaTransporte]
ADD CONSTRAINT [FK__RutaTrans__Trans__571DF1D5]
    FOREIGN KEY ([TransporteId])
    REFERENCES [dbo].[Transporte]
        ([TransporteId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RutaTrans__Trans__571DF1D5'
CREATE INDEX [IX_FK__RutaTrans__Trans__571DF1D5]
ON [dbo].[RutaTransporte]
    ([TransporteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------