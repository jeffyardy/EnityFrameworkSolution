
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/13/2017 12:46:21
-- Generated from EDMX file: D:\Durgesh\EnityFrameworkSolution\ModelFirstEfConApp\MultiDbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MultiDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Members'
CREATE TABLE [dbo].[Members] (
    [MemberId] int IDENTITY(1,1) NOT NULL,
    [MemberName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Games'
CREATE TABLE [dbo].[Games] (
    [GameId] int IDENTITY(1,1) NOT NULL,
    [GameName] nvarchar(max)  NOT NULL,
    [Fees] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'MemberGame'
CREATE TABLE [dbo].[MemberGame] (
    [Members_MemberId] int  NOT NULL,
    [Games_GameId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MemberId] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [PK_Members]
    PRIMARY KEY CLUSTERED ([MemberId] ASC);
GO

-- Creating primary key on [GameId] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [PK_Games]
    PRIMARY KEY CLUSTERED ([GameId] ASC);
GO

-- Creating primary key on [Members_MemberId], [Games_GameId] in table 'MemberGame'
ALTER TABLE [dbo].[MemberGame]
ADD CONSTRAINT [PK_MemberGame]
    PRIMARY KEY CLUSTERED ([Members_MemberId], [Games_GameId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Members_MemberId] in table 'MemberGame'
ALTER TABLE [dbo].[MemberGame]
ADD CONSTRAINT [FK_MemberGame_Member]
    FOREIGN KEY ([Members_MemberId])
    REFERENCES [dbo].[Members]
        ([MemberId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Games_GameId] in table 'MemberGame'
ALTER TABLE [dbo].[MemberGame]
ADD CONSTRAINT [FK_MemberGame_Game]
    FOREIGN KEY ([Games_GameId])
    REFERENCES [dbo].[Games]
        ([GameId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MemberGame_Game'
CREATE INDEX [IX_FK_MemberGame_Game]
ON [dbo].[MemberGame]
    ([Games_GameId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------