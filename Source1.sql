USE [master]
GO
/****** Object:  Database [For_kurs]    Script Date: 11.01.2022 16:15:56 ******/
CREATE DATABASE [For_kurs]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'For_kurs', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\For_kurs.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'For_kurs_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\For_kurs_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [For_kurs] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [For_kurs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [For_kurs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [For_kurs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [For_kurs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [For_kurs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [For_kurs] SET ARITHABORT OFF 
GO
ALTER DATABASE [For_kurs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [For_kurs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [For_kurs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [For_kurs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [For_kurs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [For_kurs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [For_kurs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [For_kurs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [For_kurs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [For_kurs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [For_kurs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [For_kurs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [For_kurs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [For_kurs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [For_kurs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [For_kurs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [For_kurs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [For_kurs] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [For_kurs] SET  MULTI_USER 
GO
ALTER DATABASE [For_kurs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [For_kurs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [For_kurs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [For_kurs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [For_kurs] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [For_kurs] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [For_kurs] SET QUERY_STORE = OFF
GO
USE [For_kurs]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 11.01.2022 16:15:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Group code] [int] IDENTITY(1,1) NOT NULL,
	[Profile] [nvarchar](max) NULL,
	[Class Teachers Name] [nvarchar](max) NULL,
	[Class number] [int] NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[Group code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Duty]    Script Date: 11.01.2022 16:15:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Duty](
	[Duty code] [int] IDENTITY(1,1) NOT NULL,
	[Student code] [int] NULL,
	[Group code] [int] NULL,
	[For what] [varchar](max) NULL,
	[Amount] [int] NULL,
 CONSTRAINT [PK_Duty] PRIMARY KEY CLUSTERED 
(
	[Duty code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Magazine]    Script Date: 11.01.2022 16:15:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Magazine](
	[Magazine code] [int] IDENTITY(1,1) NOT NULL,
	[Student code] [int] NOT NULL,
	[Group code] [int] NOT NULL,
	[Subject name] [nvarchar](max) NULL,
	[Grade in 1st semester] [int] NULL,
	[Grade in 2nd semester] [int] NULL,
	[Grade for year] [int] NULL,
	[Teachers Full Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Magazine] PRIMARY KEY CLUSTERED 
(
	[Magazine code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Olympiads]    Script Date: 11.01.2022 16:15:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Olympiads](
	[Olympiad code] [int] IDENTITY(1,1) NOT NULL,
	[Student code] [int] NULL,
	[Group code] [int] NOT NULL,
	[Level of Olympiad] [nvarchar](max) NULL,
	[Max level of Olympiad] [nvarchar](max) NULL,
	[Had participation] [nvarchar](max) NULL,
	[Name of subject] [nvarchar](max) NULL,
 CONSTRAINT [PK_Olympiads] PRIMARY KEY CLUSTERED 
(
	[Olympiad code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 11.01.2022 16:15:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Student code] [int] IDENTITY(1,1) NOT NULL,
	[Group code] [int] NOT NULL,
	[Full Name] [nvarchar](max) NULL,
	[Tear birth] [nvarchar](max) NULL,
	[Male] [nvarchar](max) NULL,
	[Semester grade] [int] NULL,
 CONSTRAINT [PK_Students_1] PRIMARY KEY CLUSTERED 
(
	[Student code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [Group code]    Script Date: 11.01.2022 16:15:56 ******/
CREATE UNIQUE NONCLUSTERED INDEX [Group code] ON [dbo].[Classes]
(
	[Group code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 1, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Classes]    Script Date: 11.01.2022 16:15:56 ******/
CREATE NONCLUSTERED INDEX [IX_Classes] ON [dbo].[Classes]
(
	[Group code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Duty code]    Script Date: 11.01.2022 16:15:56 ******/
CREATE UNIQUE NONCLUSTERED INDEX [Duty code] ON [dbo].[Duty]
(
	[Duty code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 1, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Olympiad code]    Script Date: 11.01.2022 16:15:56 ******/
CREATE UNIQUE NONCLUSTERED INDEX [Olympiad code] ON [dbo].[Olympiads]
(
	[Olympiad code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Student code]    Script Date: 11.01.2022 16:15:56 ******/
CREATE UNIQUE NONCLUSTERED INDEX [Student code] ON [dbo].[Students]
(
	[Student code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 1, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Duty]  WITH CHECK ADD  CONSTRAINT [FK_Duty_Classes] FOREIGN KEY([Group code])
REFERENCES [dbo].[Classes] ([Group code])
GO
ALTER TABLE [dbo].[Duty] CHECK CONSTRAINT [FK_Duty_Classes]
GO
ALTER TABLE [dbo].[Duty]  WITH CHECK ADD  CONSTRAINT [FK_Duty_Students] FOREIGN KEY([Student code])
REFERENCES [dbo].[Students] ([Student code])
GO
ALTER TABLE [dbo].[Duty] CHECK CONSTRAINT [FK_Duty_Students]
GO
ALTER TABLE [dbo].[Magazine]  WITH CHECK ADD  CONSTRAINT [FK_Magazine_Classes] FOREIGN KEY([Group code])
REFERENCES [dbo].[Classes] ([Group code])
GO
ALTER TABLE [dbo].[Magazine] CHECK CONSTRAINT [FK_Magazine_Classes]
GO
ALTER TABLE [dbo].[Magazine]  WITH CHECK ADD  CONSTRAINT [FK_Magazine_Students] FOREIGN KEY([Student code])
REFERENCES [dbo].[Students] ([Student code])
GO
ALTER TABLE [dbo].[Magazine] CHECK CONSTRAINT [FK_Magazine_Students]
GO
ALTER TABLE [dbo].[Olympiads]  WITH CHECK ADD  CONSTRAINT [FK_Olympiads_Classes] FOREIGN KEY([Group code])
REFERENCES [dbo].[Classes] ([Group code])
GO
ALTER TABLE [dbo].[Olympiads] CHECK CONSTRAINT [FK_Olympiads_Classes]
GO
ALTER TABLE [dbo].[Olympiads]  WITH CHECK ADD  CONSTRAINT [FK_Olympiads_Students] FOREIGN KEY([Student code])
REFERENCES [dbo].[Students] ([Student code])
GO
ALTER TABLE [dbo].[Olympiads] CHECK CONSTRAINT [FK_Olympiads_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Classes] FOREIGN KEY([Group code])
REFERENCES [dbo].[Classes] ([Group code])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Classes]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Students] FOREIGN KEY([Student code])
REFERENCES [dbo].[Students] ([Student code])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Students]
GO
USE [master]
GO
ALTER DATABASE [For_kurs] SET  READ_WRITE 
GO
