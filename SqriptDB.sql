USE [master]
GO
/****** Object:  Database [Rykova_SampleDB]    Script Date: 24.05.2023 10:59:18 ******/
CREATE DATABASE [Rykova_SampleDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Rykova_SampleDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Rykova_SampleDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Rykova_SampleDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Rykova_SampleDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Rykova_SampleDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Rykova_SampleDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Rykova_SampleDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Rykova_SampleDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Rykova_SampleDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Rykova_SampleDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Rykova_SampleDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Rykova_SampleDB] SET  MULTI_USER 
GO
ALTER DATABASE [Rykova_SampleDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Rykova_SampleDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Rykova_SampleDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Rykova_SampleDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Rykova_SampleDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Rykova_SampleDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Rykova_SampleDB] SET QUERY_STORE = OFF
GO
USE [Rykova_SampleDB]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 24.05.2023 10:59:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [int] NOT NULL,
	[name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24.05.2023 10:59:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[login] [nvarchar](20) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[roleId] [int] NOT NULL,
	[FIO] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Roles] ([id], [name]) VALUES (1, N'Главная крыса')
INSERT [dbo].[Roles] ([id], [name]) VALUES (2, N'Музыкальная крыса')
INSERT [dbo].[Roles] ([id], [name]) VALUES (3, N'Смешная крыса')
INSERT [dbo].[Roles] ([id], [name]) VALUES (4, N'ваня шешин')
INSERT [dbo].[Roles] ([id], [name]) VALUES (5, N'Крыса')
GO
INSERT [dbo].[Users] ([login], [password], [roleId], [FIO]) VALUES (N'alinatop', N'qwerty', 1, N'Пономарева А. Ф.')
INSERT [dbo].[Users] ([login], [password], [roleId], [FIO]) VALUES (N'andreitop', N'qwerty', 2, N'Сахаров А. В.')
INSERT [dbo].[Users] ([login], [password], [roleId], [FIO]) VALUES (N'ivandurak', N'qwerty', 4, N'Шешин И. М.')
INSERT [dbo].[Users] ([login], [password], [roleId], [FIO]) VALUES (N'mashatop', N'qwerty', 5, N'Рыкова М. С.')
INSERT [dbo].[Users] ([login], [password], [roleId], [FIO]) VALUES (N'svetatop', N'qwerty', 3, N'Стаханова С. И.')
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([roleId])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [Rykova_SampleDB] SET  READ_WRITE 
GO
