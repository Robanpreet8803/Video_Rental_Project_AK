USE [master]
GO
/****** Object:  Database [VideoRental]    Script Date: 26/06/2021 1:36:43 PM ******/
CREATE DATABASE [VideoRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRental_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoRental_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRental.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoRental] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRental] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRental] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRental] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRental] SET QUERY_STORE = OFF
GO
USE [VideoRental]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 26/06/2021 1:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[Bid] [int] IDENTITY(1,1) NOT NULL,
	[Cid] [varchar](50) NULL,
	[Mid] [varchar](50) NULL,
	[BookingDt] [varchar](50) NULL,
	[ReturnDt] [varchar](50) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[Bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 26/06/2021 1:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video]    Script Date: 26/06/2021 1:36:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video](
	[Mid] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Ratting] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Cost] [varchar](50) NULL,
	[Copy] [varchar](50) NULL,
	[Plot] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
(
	[Mid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([Bid], [Cid], [Mid], [BookingDt], [ReturnDt]) VALUES (1, N'1', N'1', N'6/22/2021', N'6/22/2021')
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([ID], [Name], [Address], [Contact]) VALUES (1, N'qw', N'qw', N'123')
SET IDENTITY_INSERT [dbo].[customer] OFF
SET IDENTITY_INSERT [dbo].[Video] ON 

INSERT [dbo].[Video] ([Mid], [Name], [Ratting], [Year], [Cost], [Copy], [Plot], [Genre]) VALUES (1, N'Johnson', N'4.5', N'2019', N'5', N'3', N'ff', N'we')
SET IDENTITY_INSERT [dbo].[Video] OFF
USE [master]
GO
ALTER DATABASE [VideoRental] SET  READ_WRITE 
GO
