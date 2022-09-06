CREATE DATABASE [KoniaEmployeeDb]
GO

USE [KoniaEmployeeDb]
GO

CREATE TABLE [Collaborators] (
    [Id] INT NOT NULL IDENTITY (1, 1),
    [Name] NVARCHAR(80) NOT NULL,
    [CreateDate] SMALLDATETIME NOT NULL DEFAULT(GETDATE())

    CONSTRAINT [PK_Collaborators] PRIMARY KEY([Id])
)