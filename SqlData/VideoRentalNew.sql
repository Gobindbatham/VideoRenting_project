USE [master]
GO
/****** Object:  Database [VideoRentalNew]    Script Date: 10/05/2021 11:45:55 PM ******/
CREATE DATABASE [VideoRentalNew]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRentalNew_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRentalNew.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoRentalNew_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRentalNew.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoRentalNew] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRentalNew].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRentalNew] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRentalNew] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRentalNew] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRentalNew] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRentalNew] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRentalNew] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoRentalNew] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRentalNew] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRentalNew] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRentalNew] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRentalNew] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRentalNew] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRentalNew] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRentalNew] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRentalNew] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRentalNew] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRentalNew] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRentalNew] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRentalNew] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRentalNew] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRentalNew] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRentalNew] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRentalNew] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRentalNew] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRentalNew] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRentalNew] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRentalNew] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRentalNew] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRentalNew] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRentalNew] SET QUERY_STORE = OFF
GO
USE [VideoRentalNew]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 10/05/2021 11:45:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [varchar](50) NULL,
	[VideoID] [varchar](50) NULL,
	[BookingDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/05/2021 11:45:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[contact] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video]    Script Date: 10/05/2021 11:45:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video](
	[VideoID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Ratting] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Cost] [varchar](50) NULL,
	[Copies] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
(
	[VideoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([BookingID], [CustomerID], [VideoID], [BookingDate], [ReturnDate]) VALUES (1, N'1', N'1', N'5/10/2021', N'5/10/2021')
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [Name], [address], [contact], [Email]) VALUES (1, N'mohn', N'nz', N'879456', N'mohn@gmil.com')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Video] ON 

INSERT [dbo].[Video] ([VideoID], [Name], [Ratting], [Year], [Cost], [Copies], [Genre]) VALUES (1, N'Gunday', N'4.6', N'2019', N'5', N'4', N'comedy')
SET IDENTITY_INSERT [dbo].[Video] OFF
USE [master]
GO
ALTER DATABASE [VideoRentalNew] SET  READ_WRITE 
GO
