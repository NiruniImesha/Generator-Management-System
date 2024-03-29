USE [master]
GO
/****** Object:  Database [generatorManagement]    Script Date: 05/08/2023 16:54:08 ******/
CREATE DATABASE [generatorManagement] ON  PRIMARY 
( NAME = N'generatorManagement', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\Data\generatorManagement.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'generatorManagement_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\Data\generatorManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [generatorManagement] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [generatorManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [generatorManagement] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [generatorManagement] SET ANSI_NULLS OFF
GO
ALTER DATABASE [generatorManagement] SET ANSI_PADDING OFF
GO
ALTER DATABASE [generatorManagement] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [generatorManagement] SET ARITHABORT OFF
GO
ALTER DATABASE [generatorManagement] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [generatorManagement] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [generatorManagement] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [generatorManagement] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [generatorManagement] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [generatorManagement] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [generatorManagement] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [generatorManagement] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [generatorManagement] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [generatorManagement] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [generatorManagement] SET  DISABLE_BROKER
GO
ALTER DATABASE [generatorManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [generatorManagement] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [generatorManagement] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [generatorManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [generatorManagement] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [generatorManagement] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [generatorManagement] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [generatorManagement] SET  READ_WRITE
GO
ALTER DATABASE [generatorManagement] SET RECOVERY FULL
GO
ALTER DATABASE [generatorManagement] SET  MULTI_USER
GO
ALTER DATABASE [generatorManagement] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [generatorManagement] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'generatorManagement', N'ON'
GO
USE [generatorManagement]
GO
/****** Object:  Table [dbo].[user]    Script Date: 05/08/2023 16:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[userID] [char](4) NOT NULL,
	[userName] [varchar](15) NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [user_pk] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[service_history]    Script Date: 05/08/2023 16:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[service_history](
	[serviceTurn] [int] IDENTITY(1,1) NOT NULL,
	[currentTotDuration] [decimal](18, 0) NULL,
	[generatorID] [nvarchar](50) NULL,
	[serviceDate] [date] NULL,
	[serviceType] [varchar](10) NULL,
 CONSTRAINT [history_pk] PRIMARY KEY CLUSTERED 
(
	[serviceTurn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__history__8CB3E99A108B795B] UNIQUE NONCLUSTERED 
(
	[serviceTurn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[service_duration_data]    Script Date: 05/08/2023 16:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service_duration_data](
	[serviceID] [nvarchar](12) NOT NULL,
	[generatorID] [nvarchar](50) NOT NULL,
	[EngineserviceDurationMonths] [int] NULL,
	[EngineserviceDurationHours] [int] NULL,
	[AirserviceDurationMonths] [int] NULL,
	[AirserviceDurationHours] [int] NULL,
	[SedimentserviceDurationMonths] [int] NULL,
	[SedimentserviceDurationHours] [int] NULL,
	[ValveserviceDurationMonths] [int] NULL,
	[ValveserviceDurationHours] [int] NULL,
	[SparkserviceDurationMonths] [int] NULL,
	[SparkserviceDurationHours] [int] NULL,
	[FuelserviceDurationMonths] [int] NULL,
	[FuelserviceDurationHours] [int] NULL,
	[FuelSeviceDurationYears] [int] NULL,
 CONSTRAINT [service_pk] PRIMARY KEY CLUSTERED 
(
	[serviceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[generator]    Script Date: 05/08/2023 16:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[generator](
	[genNo] [nvarchar](50) NOT NULL,
	[model] [varchar](10) NULL,
	[frequency] [int] NULL,
	[tankSize] [int] NULL,
	[totalDuration] [decimal](10, 2) NULL,
	[firstServiceMonth] [int] NULL,
	[firstServiceHours] [int] NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [generator_pk] PRIMARY KEY CLUSTERED 
(
	[genNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__generato__86604CDD023D5A04] UNIQUE NONCLUSTERED 
(
	[genNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[daily_generator_usage]    Script Date: 05/08/2023 16:54:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[daily_generator_usage](
	[serviceNo] [int] IDENTITY(1,1) NOT NULL,
	[start] [time](7) NULL,
	[startUser] [char](4) NULL,
	[stop] [time](7) NULL,
	[stopUser] [char](4) NULL,
	[Duration] [decimal](2, 2) NULL,
	[date] [date] NULL,
 CONSTRAINT [genServ_pk] PRIMARY KEY CLUSTERED 
(
	[serviceNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[serviceNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK__generator__start__0BC6C43E]    Script Date: 05/08/2023 16:54:09 ******/
ALTER TABLE [dbo].[daily_generator_usage]  WITH CHECK ADD FOREIGN KEY([startUser])
REFERENCES [dbo].[user] ([userID])
GO
/****** Object:  ForeignKey [FK__generator__stopU__0CBAE877]    Script Date: 05/08/2023 16:54:09 ******/
ALTER TABLE [dbo].[daily_generator_usage]  WITH CHECK ADD FOREIGN KEY([stopUser])
REFERENCES [dbo].[user] ([userID])
GO
