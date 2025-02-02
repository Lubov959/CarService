USE [master]
GO
/****** Object:  Database [z111]    Script Date: 07.11.2024 12:38:31 ******/
CREATE DATABASE [z111]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'z111', FILENAME = N'D:\MSSQL14.SQLSERVER\MSSQL\DATA\z111.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'z111_log', FILENAME = N'D:\MSSQL14.SQLSERVER\MSSQL\DATA\z111_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [z111] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [z111].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [z111] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [z111] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [z111] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [z111] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [z111] SET ARITHABORT OFF 
GO
ALTER DATABASE [z111] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [z111] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [z111] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [z111] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [z111] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [z111] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [z111] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [z111] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [z111] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [z111] SET  DISABLE_BROKER 
GO
ALTER DATABASE [z111] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [z111] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [z111] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [z111] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [z111] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [z111] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [z111] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [z111] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [z111] SET  MULTI_USER 
GO
ALTER DATABASE [z111] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [z111] SET DB_CHAINING OFF 
GO
ALTER DATABASE [z111] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [z111] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [z111] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [z111] SET QUERY_STORE = OFF
GO
USE [z111]
GO
/****** Object:  Table [dbo].[type]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type](
	[typeID] [int] IDENTITY(1,1) NOT NULL,
	[typeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_type] PRIMARY KEY CLUSTERED 
(
	[typeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[patronymic] [nvarchar](50) NOT NULL,
	[phone] [char](11) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[typeID] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Users]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Users]
AS
SELECT        dbo.[user].userID AS Номер, dbo.[user].surname AS Фамилия, dbo.[user].name AS Имя, dbo.[user].patronymic AS Отчество, dbo.[user].phone AS Телефон, dbo.[user].login AS Логин, CONVERT(Nvarchar(MAX), 
                         DecryptByPassphrase('MyPassword', dbo.[user].password)) AS Пароль, dbo.type.typeName AS Роль
FROM            dbo.[user] INNER JOIN
                         dbo.type ON dbo.[user].typeID = dbo.type.typeID
GO
/****** Object:  Table [dbo].[request]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[request](
	[requestID] [int] IDENTITY(1,1) NOT NULL,
	[startDate] [date] NULL,
	[carModelID] [int] NOT NULL,
	[problemDescryptionID] [int] NOT NULL,
	[requestStatusID] [int] NOT NULL,
	[completionDate] [date] NULL,
	[repairPartsID] [int] NULL,
	[masterID] [int] NULL,
	[clientID] [int] NOT NULL,
 CONSTRAINT [PK_request] PRIMARY KEY CLUSTERED 
(
	[requestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comment]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comment](
	[commentID] [int] IDENTITY(1,1) NOT NULL,
	[message] [nvarchar](50) NOT NULL,
	[requestID] [int] NOT NULL,
 CONSTRAINT [PK_comment] PRIMARY KEY CLUSTERED 
(
	[commentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carType]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carType](
	[carTypeID] [int] IDENTITY(1,1) NOT NULL,
	[carTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_carType] PRIMARY KEY CLUSTERED 
(
	[carTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[problemDescryption]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[problemDescryption](
	[problemDescryptionID] [int] IDENTITY(1,1) NOT NULL,
	[problemDescryptionName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_problemDescryption] PRIMARY KEY CLUSTERED 
(
	[problemDescryptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[requestStatus]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[requestStatus](
	[requestStatusID] [int] IDENTITY(1,1) NOT NULL,
	[requestStatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_requestStatus] PRIMARY KEY CLUSTERED 
(
	[requestStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carModel]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carModel](
	[carModelID] [int] IDENTITY(1,1) NOT NULL,
	[carModelName] [nvarchar](max) NOT NULL,
	[carTypeID] [int] NOT NULL,
 CONSTRAINT [PK_carModel] PRIMARY KEY CLUSTERED 
(
	[carModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[repairParts]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[repairParts](
	[repairPartsID] [int] IDENTITY(1,1) NOT NULL,
	[repairPartsName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_repairParts] PRIMARY KEY CLUSTERED 
(
	[repairPartsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Requests]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Requests]
AS
SELECT        dbo.request.requestID AS Номер, dbo.request.startDate AS [Дата начала], dbo.carModel.carModelName AS Модель, dbo.carType.carTypeName AS [Тип машины], 
                         dbo.problemDescryption.problemDescryptionName AS Проблема, dbo.requestStatus.requestStatusName AS Статус, dbo.request.completionDate AS [Дата окончания], dbo.repairParts.repairPartsName AS Запчасти, 
                         dbo.request.masterID AS [Номер мастера], mast.surname AS Мастер, dbo.request.clientID AS [Номер клиента], client.surname AS Клиент, dbo.comment.message AS Комментарий
FROM            dbo.request LEFT OUTER JOIN
                         dbo.requestStatus ON dbo.request.requestStatusID = dbo.requestStatus.requestStatusID LEFT OUTER JOIN
                         dbo.carModel ON dbo.request.carModelID = dbo.carModel.carModelID LEFT OUTER JOIN
                         dbo.carType ON dbo.carModel.carTypeID = dbo.carType.carTypeID LEFT OUTER JOIN
                         dbo.problemDescryption ON dbo.request.problemDescryptionID = dbo.problemDescryption.problemDescryptionID LEFT OUTER JOIN
                         dbo.repairParts ON dbo.request.repairPartsID = dbo.repairParts.repairPartsID LEFT OUTER JOIN
                         dbo.[user] AS mast ON dbo.request.masterID = mast.userID LEFT OUTER JOIN
                         dbo.[user] AS client ON dbo.request.clientID = client.userID LEFT OUTER JOIN
                         dbo.comment ON dbo.request.requestID = dbo.comment.requestID
GO
/****** Object:  Table [dbo].[history]    Script Date: 07.11.2024 12:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[history](
	[historyID] [int] IDENTITY(1,1) NOT NULL,
	[time] [date] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[entered] [bit] NULL,
 CONSTRAINT [PK_history] PRIMARY KEY CLUSTERED 
(
	[historyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[carModel] ON 

INSERT [dbo].[carModel] ([carModelID], [carModelName], [carTypeID]) VALUES (1, N'Hyundai Avante (CN7)', 1)
INSERT [dbo].[carModel] ([carModelID], [carModelName], [carTypeID]) VALUES (2, N'Nissan 180SX ', 1)
INSERT [dbo].[carModel] ([carModelID], [carModelName], [carTypeID]) VALUES (3, N'Toyota 2000GT ', 1)
INSERT [dbo].[carModel] ([carModelID], [carModelName], [carTypeID]) VALUES (4, N'Citroen Berlingo (B9)', 2)
INSERT [dbo].[carModel] ([carModelID], [carModelName], [carTypeID]) VALUES (5, N'УАЗ 2360 ', 2)
SET IDENTITY_INSERT [dbo].[carModel] OFF
GO
SET IDENTITY_INSERT [dbo].[carType] ON 

INSERT [dbo].[carType] ([carTypeID], [carTypeName]) VALUES (1, N'Легковая')
INSERT [dbo].[carType] ([carTypeID], [carTypeName]) VALUES (2, N'Грузовая')
INSERT [dbo].[carType] ([carTypeID], [carTypeName]) VALUES (3, N'Сидан')
INSERT [dbo].[carType] ([carTypeID], [carTypeName]) VALUES (4, N'Сидан')
SET IDENTITY_INSERT [dbo].[carType] OFF
GO
SET IDENTITY_INSERT [dbo].[comment] ON 

INSERT [dbo].[comment] ([commentID], [message], [requestID]) VALUES (1, N'Очень странно.', 1)
INSERT [dbo].[comment] ([commentID], [message], [requestID]) VALUES (2, N'Будем разбираться!', 2)
INSERT [dbo].[comment] ([commentID], [message], [requestID]) VALUES (3, N'Будем разбираться!', 3)
INSERT [dbo].[comment] ([commentID], [message], [requestID]) VALUES (4, N'Класс', 9)
INSERT [dbo].[comment] ([commentID], [message], [requestID]) VALUES (5, N'Сделано', 10)
SET IDENTITY_INSERT [dbo].[comment] OFF
GO
SET IDENTITY_INSERT [dbo].[history] ON 

INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (1, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (2, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (3, CAST(N'2024-11-02' AS Date), N'login12', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (4, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (5, CAST(N'2024-11-02' AS Date), N'login12', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (6, CAST(N'2024-11-02' AS Date), N'login12', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (7, CAST(N'2024-11-02' AS Date), N'login3', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (8, CAST(N'2024-11-02' AS Date), N'login3', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (9, CAST(N'2024-11-02' AS Date), N'login3', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (10, CAST(N'2024-11-02' AS Date), N'login3', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (11, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (12, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (13, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (14, CAST(N'2024-11-02' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (15, CAST(N'2024-11-02' AS Date), N'login2', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (16, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (17, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (18, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (19, CAST(N'2024-11-02' AS Date), N'login13', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (20, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (21, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (22, CAST(N'2024-11-02' AS Date), N'login13', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (23, CAST(N'2024-11-05' AS Date), N'login2', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (24, CAST(N'2024-11-05' AS Date), N'login2', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (25, CAST(N'2024-11-05' AS Date), N'login4', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (26, CAST(N'2024-11-05' AS Date), N'login12', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (27, CAST(N'2024-11-05' AS Date), N'login4', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (28, CAST(N'2024-11-05' AS Date), N'login15', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (29, CAST(N'2024-11-05' AS Date), N'login10', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (30, CAST(N'2024-11-05' AS Date), N'login10', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (31, CAST(N'2024-11-05' AS Date), N'DG', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (32, CAST(N'2024-11-05' AS Date), N'DG', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (33, CAST(N'2024-11-05' AS Date), N'DG', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (34, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (35, CAST(N'2024-11-05' AS Date), N'login4', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (36, CAST(N'2024-11-05' AS Date), N'login15', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (37, CAST(N'2024-11-05' AS Date), N'впав', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (38, CAST(N'2024-11-05' AS Date), N'впав', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (39, CAST(N'2024-11-05' AS Date), N'login11', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (40, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (41, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (42, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (43, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (44, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (45, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (46, CAST(N'2024-11-05' AS Date), N'вп', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (47, CAST(N'2024-11-05' AS Date), N'вп', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (48, CAST(N'2024-11-05' AS Date), N'oginldkf', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (49, CAST(N'2024-11-05' AS Date), N'oginldkf', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (50, CAST(N'2024-11-05' AS Date), N'oginldkf', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (51, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (52, CAST(N'2024-11-05' AS Date), N'dsfs', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (53, CAST(N'2024-11-05' AS Date), N'dsfs', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (54, CAST(N'2024-11-05' AS Date), N'dsfs', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (55, CAST(N'2024-11-05' AS Date), N'login2', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (56, CAST(N'2024-11-05' AS Date), N'dfg', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (57, CAST(N'2024-11-05' AS Date), N'dfg', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (58, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (59, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (60, CAST(N'2024-11-05' AS Date), N'sdfs', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (61, CAST(N'2024-11-05' AS Date), N'sdfs', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (62, CAST(N'2024-11-05' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (63, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (64, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (65, CAST(N'2024-11-06' AS Date), N'login12', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (66, CAST(N'2024-11-06' AS Date), N'login8', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (67, CAST(N'2024-11-06' AS Date), N'', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (68, CAST(N'2024-11-06' AS Date), N'login12', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (69, CAST(N'2024-11-06' AS Date), N'login12ddf', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (70, CAST(N'2024-11-06' AS Date), N'login12ddf', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (71, CAST(N'2024-11-06' AS Date), N'login12', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (72, CAST(N'2024-11-06' AS Date), N'login12fdg', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (73, CAST(N'2024-11-06' AS Date), N'login12fdg', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (74, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (75, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (76, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (77, CAST(N'2024-11-06' AS Date), N'login4', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (78, CAST(N'2024-11-06' AS Date), N'login4', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (79, CAST(N'2024-11-06' AS Date), N'login4', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (80, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (81, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (82, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (83, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (84, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (85, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (86, CAST(N'2024-11-06' AS Date), N'ыва', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (87, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (88, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (89, CAST(N'2024-11-06' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (90, CAST(N'2024-11-06' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (91, CAST(N'2024-11-06' AS Date), N'login11', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (92, CAST(N'2024-11-06' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (93, CAST(N'2024-11-06' AS Date), N'login11', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (94, CAST(N'2024-11-06' AS Date), N'login11', 0)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (95, CAST(N'2024-11-06' AS Date), N'login1', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (96, CAST(N'2024-11-06' AS Date), N'login12', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (97, CAST(N'2024-11-06' AS Date), N'login4', 1)
INSERT [dbo].[history] ([historyID], [time], [login], [entered]) VALUES (98, CAST(N'2024-11-06' AS Date), N'login15', 1)
SET IDENTITY_INSERT [dbo].[history] OFF
GO
SET IDENTITY_INSERT [dbo].[problemDescryption] ON 

INSERT [dbo].[problemDescryption] ([problemDescryptionID], [problemDescryptionName]) VALUES (1, N'Отказали тормоза.')
INSERT [dbo].[problemDescryption] ([problemDescryptionID], [problemDescryptionName]) VALUES (2, N'В салоне пахнет бензином.')
INSERT [dbo].[problemDescryption] ([problemDescryptionID], [problemDescryptionName]) VALUES (3, N'Руль плохо крутится.')
INSERT [dbo].[problemDescryption] ([problemDescryptionID], [problemDescryptionName]) VALUES (4, N'Поменять масло.')
INSERT [dbo].[problemDescryption] ([problemDescryptionID], [problemDescryptionName]) VALUES (5, N'Не заводится.')
SET IDENTITY_INSERT [dbo].[problemDescryption] OFF
GO
SET IDENTITY_INSERT [dbo].[repairParts] ON 

INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (1, N'Шуруп')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (2, N'Гайка')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (3, N'Отвертка')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (4, N'Масло')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (5, N'Тормозная колодка')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (6, N'Кабель')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (7, N'Колесо')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (8, N'Стекло')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (9, N'Руль')
INSERT [dbo].[repairParts] ([repairPartsID], [repairPartsName]) VALUES (10, N'Двигатель')
SET IDENTITY_INSERT [dbo].[repairParts] OFF
GO
SET IDENTITY_INSERT [dbo].[request] ON 

INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (1, CAST(N'2023-06-06' AS Date), 1, 1, 2, CAST(N'2024-11-05' AS Date), 5, 2, 7)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (2, CAST(N'2023-05-05' AS Date), 2, 1, 1, NULL, 3, 3, 8)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (3, CAST(N'2022-07-07' AS Date), 3, 2, 2, CAST(N'2023-01-01' AS Date), 3, 3, 9)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (4, CAST(N'2023-08-02' AS Date), 4, 3, 3, NULL, NULL, NULL, 8)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (5, CAST(N'2023-08-02' AS Date), 5, 3, 3, NULL, NULL, NULL, 9)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (8, NULL, 3, 4, 3, NULL, NULL, NULL, 8)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (9, CAST(N'2024-11-06' AS Date), 3, 5, 2, CAST(N'2024-11-06' AS Date), 8, 10, 7)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (10, CAST(N'2024-11-06' AS Date), 3, 5, 2, CAST(N'2024-11-10' AS Date), 7, 10, 6)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (11, NULL, 5, 4, 3, NULL, NULL, NULL, 6)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (12, NULL, 5, 3, 3, NULL, NULL, NULL, 6)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (13, CAST(N'2024-11-07' AS Date), 4, 3, 2, CAST(N'2024-11-07' AS Date), NULL, 3, 6)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (14, NULL, 5, 2, 1, NULL, NULL, 2, 6)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (15, NULL, 3, 3, 1, NULL, NULL, 3, 7)
INSERT [dbo].[request] ([requestID], [startDate], [carModelID], [problemDescryptionID], [requestStatusID], [completionDate], [repairPartsID], [masterID], [clientID]) VALUES (16, NULL, 4, 1, 3, NULL, NULL, NULL, 7)
SET IDENTITY_INSERT [dbo].[request] OFF
GO
SET IDENTITY_INSERT [dbo].[requestStatus] ON 

INSERT [dbo].[requestStatus] ([requestStatusID], [requestStatusName]) VALUES (1, N'В процессе ремонта')
INSERT [dbo].[requestStatus] ([requestStatusID], [requestStatusName]) VALUES (2, N'Готова к выдаче')
INSERT [dbo].[requestStatus] ([requestStatusID], [requestStatusName]) VALUES (3, N'Новая заявка')
INSERT [dbo].[requestStatus] ([requestStatusID], [requestStatusName]) VALUES (4, N'Отклонена')
SET IDENTITY_INSERT [dbo].[requestStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[type] ON 

INSERT [dbo].[type] ([typeID], [typeName]) VALUES (1, N'Менеджер')
INSERT [dbo].[type] ([typeID], [typeName]) VALUES (2, N'Автомеханик')
INSERT [dbo].[type] ([typeID], [typeName]) VALUES (3, N'Заказчик')
INSERT [dbo].[type] ([typeID], [typeName]) VALUES (4, N'Оператор')
SET IDENTITY_INSERT [dbo].[type] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (1, N'Белов', N'Александр', N'Давидович', N'89210563128', N'login1', N' 숃邸㖇骰Ṏ埨쑺廳汈ភ伊꽽쵋黝ᛳⓇဏ쮲굜ꏇ�', 1)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (2, N'Харитонова', N'Мария', N'Павловна', N'89535078985', N'login2', N' ᆕ砡ꢿ�뇪妆ꃽᱟҩ遧⿬篽覈꛰⸚楹直李醤괣䉚峕', 2)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (3, N'Марков', N'Давид', N'Иванович', N'89210673849', N'login3', N' ⰿ᷎憓먕쁊㴁슰然檸Ⱅ炽廑�临뺜魲儺ᖓ�蝲埕稱', 2)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (4, N'Громова', N'Анна', N'Семёновна', N'89990563748', N'login4', N' �策＼ℰ缵℗틐藞�﬉秒䭖㿊ኔ碿௢�蠀厒姆䕫鞍', 4)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (5, N'Карташова', N'Мария', N'Данииловна', N'89994563847', N'login5', N' ڞꫂ龮扞섵ﻹ婫ડ棴脃䋾畾ꕑ̼ᦍꫧ諀⧺겫좇꙰', 4)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (6, N'Касаткин', N'Егор', N'Львович', N'89219567849', N'login11', N' 隅≅駍踫뾾㘚炌嫪㉓詃쎾쥮뼅暨覯⎙헷镗⨆묂⿺⾔り', 3)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (7, N'Ильина', N'Тамара', N'Даниловна', N'89219567841', N'login12', N' 띐ϷⓏ申種璖㡕ꂣ̃帣惱뛜洦뇒糝혏枿ʇ딫�ﲹ', 3)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (8, N'Елисеева', N'Юлиана', N'Алексеевна', N'89219567842', N'login13', N' 煇�찻楳䱚У�穝～�쥓留烆餖晍즀䵡䇧քꢵ콷␠鬴뿀', 3)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (9, N'Никифорова', N'Алиса', N'Тимофеевна', N'89219567843', N'login14', N' 휥凲䃎碬蠽붃ݚ뻤ᤀ暝虗怽籠�䲼�ැ㙶ᱡ媛', 3)
INSERT [dbo].[user] ([userID], [surname], [name], [patronymic], [phone], [login], [password], [typeID]) VALUES (10, N'Васильев', N'Али', N'Евгеньевич', N'89219567844', N'login15', N' 贏糎ና倗�膍߹耉隙畺狝瀖⭋친냢棍䭪�忸湁⥪⛎', 2)
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[carModel]  WITH CHECK ADD  CONSTRAINT [FK_carModel_carType] FOREIGN KEY([carTypeID])
REFERENCES [dbo].[carType] ([carTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[carModel] CHECK CONSTRAINT [FK_carModel_carType]
GO
ALTER TABLE [dbo].[comment]  WITH CHECK ADD  CONSTRAINT [FK_comment_request] FOREIGN KEY([requestID])
REFERENCES [dbo].[request] ([requestID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comment] CHECK CONSTRAINT [FK_comment_request]
GO
ALTER TABLE [dbo].[request]  WITH CHECK ADD  CONSTRAINT [FK_request_carModel] FOREIGN KEY([carModelID])
REFERENCES [dbo].[carModel] ([carModelID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[request] CHECK CONSTRAINT [FK_request_carModel]
GO
ALTER TABLE [dbo].[request]  WITH CHECK ADD  CONSTRAINT [FK_request_problemDescryption] FOREIGN KEY([problemDescryptionID])
REFERENCES [dbo].[problemDescryption] ([problemDescryptionID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[request] CHECK CONSTRAINT [FK_request_problemDescryption]
GO
ALTER TABLE [dbo].[request]  WITH CHECK ADD  CONSTRAINT [FK_request_repairParts] FOREIGN KEY([repairPartsID])
REFERENCES [dbo].[repairParts] ([repairPartsID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[request] CHECK CONSTRAINT [FK_request_repairParts]
GO
ALTER TABLE [dbo].[request]  WITH CHECK ADD  CONSTRAINT [FK_request_requestStatus] FOREIGN KEY([requestStatusID])
REFERENCES [dbo].[requestStatus] ([requestStatusID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[request] CHECK CONSTRAINT [FK_request_requestStatus]
GO
ALTER TABLE [dbo].[request]  WITH CHECK ADD  CONSTRAINT [FK_request_user] FOREIGN KEY([masterID])
REFERENCES [dbo].[user] ([userID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[request] CHECK CONSTRAINT [FK_request_user]
GO
ALTER TABLE [dbo].[request]  WITH CHECK ADD  CONSTRAINT [FK_request_user1] FOREIGN KEY([clientID])
REFERENCES [dbo].[user] ([userID])
GO
ALTER TABLE [dbo].[request] CHECK CONSTRAINT [FK_request_user1]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_type] FOREIGN KEY([typeID])
REFERENCES [dbo].[type] ([typeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_type]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD CHECK  (([phone] like '8[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "request"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "requestStatus"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 234
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "carModel"
            Begin Extent = 
               Top = 6
               Left = 284
               Bottom = 119
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "carType"
            Begin Extent = 
               Top = 120
               Left = 284
               Bottom = 216
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "problemDescryption"
            Begin Extent = 
               Top = 234
               Left = 38
               Bottom = 330
               Right = 267
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "repairParts"
            Begin Extent = 
               Top = 216
               Left = 268
               Bottom = 312
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "mast"
            Begin Extent = 
               Top = 330
               Left = 38
               Bottom = 460
               Right = 212
            End
            D' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Requests'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'isplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "client"
            Begin Extent = 
               Top = 330
               Left = 250
               Bottom = 460
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "comment"
            Begin Extent = 
               Top = 6
               Left = 496
               Bottom = 119
               Right = 670
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Requests'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Requests'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "user"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "type"
            Begin Extent = 
               Top = 6
               Left = 250
               Bottom = 102
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Users'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Users'
GO
USE [master]
GO
ALTER DATABASE [z111] SET  READ_WRITE 
GO
