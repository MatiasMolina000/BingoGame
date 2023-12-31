USE master
GO

IF ( EXISTS( SELECT NAME FROM sys.databases where name = 'BingoGame' ) ) BEGIN
	DROP DATABASE BingoGame
END

CREATE DATABASE BingoGame
GO

USE BingoGame
GO


CREATE TABLE dbo.Roles(
Id TINYINT NOT NULL PRIMARY KEY IDENTITY(1,1),
[Role] VARCHAR(25) NOT NULL
)
GO

CREATE TABLE dbo.UStatus(
Id TINYINT NOT NULL PRIMARY KEY IDENTITY(1,1),
[Status] VARCHAR(25) NOT NULL
)
GO

CREATE TABLE dbo.Users(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
[User] VARCHAR(25) NOT NULL,
StatusId TINYINT FOREIGN KEY REFERENCES dbo.UStatus(Id),
Email VARCHAR(50) NOT NULL,
[Password] VARCHAR(256) NOT NULL,
[PassTemp] VARCHAR(256) NOT NULL,
Created DATETIME NOT NULL  DEFAULT(GETDATE())
)
GO

CREATE TABLE dbo.UserRoles(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
UserId INT FOREIGN KEY REFERENCES dbo.Users(Id),
RoleId TINYINT FOREIGN KEY REFERENCES dbo.Roles(Id)
)
GO

CREATE TABLE dbo.GStatus(
Id TINYINT NOT NULL PRIMARY KEY IDENTITY(1,1),
[Status] VARCHAR(25) NOT NULL
)
GO

CREATE TABLE dbo.Games(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
UserId INT FOREIGN KEY REFERENCES dbo.Users(Id),
StatusId TINYINT FOREIGN KEY REFERENCES dbo.GStatus(Id),
[Start] DATETIME NOT NULL  DEFAULT(GETDATE()),
[End] DATETIME NULL,
[Status] TINYINT NOT NULL
)
GO

CREATE TABLE dbo.BingoCage(
Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
GameId INT FOREIGN KEY REFERENCES dbo.Games(Id),
Number INT NOT NULL,
Created DATETIME NOT NULL DEFAULT(GETDATE())
)
GO

CREATE SCHEMA [Replica]
GO


CREATE TABLE [Replica].Games(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
[User] VARCHAR(25) NOT NULL,
[Status] VARCHAR(25) NOT NULL,
[Start] DATETIME NOT NULL,
[End] DATETIME NULL,
Winners VARCHAR(25) NULL
)
GO

CREATE TABLE [Replica].BingoCage(
Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
GameId INT FOREIGN KEY REFERENCES [Replica].Games(Id),
Number INT NOT NULL,
Created DATETIME NOT NULL
)
GO

CREATE TABLE [Replica].BingoCard(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
GameId INT FOREIGN KEY REFERENCES [Replica].Games(Id),
[Card] TINYINT NOT NULL,
Numbers VARCHAR(100) NOT NULL,
Completed BIT NOT NULL
)
GO