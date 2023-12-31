USE [master]
GO
/****** Object:  Database [patients]    Script Date: 6.01.2023 21:28:39 ******/
CREATE DATABASE [patients]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'patients', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\patients.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'patients_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\patients_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [patients] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [patients].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [patients] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [patients] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [patients] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [patients] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [patients] SET ARITHABORT OFF 
GO
ALTER DATABASE [patients] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [patients] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [patients] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [patients] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [patients] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [patients] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [patients] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [patients] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [patients] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [patients] SET  DISABLE_BROKER 
GO
ALTER DATABASE [patients] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [patients] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [patients] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [patients] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [patients] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [patients] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [patients] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [patients] SET RECOVERY FULL 
GO
ALTER DATABASE [patients] SET  MULTI_USER 
GO
ALTER DATABASE [patients] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [patients] SET DB_CHAINING OFF 
GO
ALTER DATABASE [patients] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [patients] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [patients] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [patients] SET QUERY_STORE = OFF
GO
USE [patients]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [patients]
GO
/****** Object:  Table [dbo].[adminDB]    Script Date: 6.01.2023 21:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adminDB](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_adminDB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patientDB]    Script Date: 6.01.2023 21:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patientDB](
	[patientID] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[contactNO] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[DOB] [nvarchar](50) NULL,
	[languages] [nvarchar](50) NULL,
	[diagnostics] [nvarchar](50) NULL,
 CONSTRAINT [PK_patientDB] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[adminDB] ON 

INSERT [dbo].[adminDB] ([ID], [username], [password]) VALUES (1, N'amro', N'dara')
INSERT [dbo].[adminDB] ([ID], [username], [password]) VALUES (2, N'ifon', N'nokia')
INSERT [dbo].[adminDB] ([ID], [username], [password]) VALUES (3, N'man', N'woman')
INSERT [dbo].[adminDB] ([ID], [username], [password]) VALUES (4, N'woman', N'man')
SET IDENTITY_INSERT [dbo].[adminDB] OFF
SET IDENTITY_INSERT [dbo].[patientDB] ON 

INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (5, N'', N'', N'', N'asda', N'', N'', N'female', N'4 Ocak 2023 Çarşamba', N'', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (6, N'asd', N'asd', N'', N'', N'', N'', N'male', N'4 Ocak 2023 Çarşamba', N'', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (7, N'asd', N'asdwsa', N'', N'', N'', N'', N'male', N'4 Ocak 2023 Çarşamba', N'arabic turkish', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (8, N'asd', N'asdwsa', N'', N'', N'', N'', N'male', N'4 Ocak 2023 Çarşamba', N'arabic turkish', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (9, N'asdasdas', N'dasdsa', N'', N'', N'', N'', N'female', N'4 Ocak 2023 Çarşamba', N'', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (10, N'sdasd', N'', N'', N'', N'', N'', N'female', N'4 Ocak 2023 Çarşamba', N'', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (11, N'asda', N'dasd', N'21312', N'asd', N'', N'', N'female', N'4 Ocak 2023 Çarşamba', N' turkish', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (12, N'', N'', N'', N'', N'', N'', N'female', N'2.01.2023', N'', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (13, N'ggggg', N'fffff', N'', N'', N'', N'', N'male', N'4.01.2023', N'arabic english turkish', N'')
INSERT [dbo].[patientDB] ([patientID], [firstname], [lastname], [contactNO], [email], [address], [city], [gender], [DOB], [languages], [diagnostics]) VALUES (14, N'asdasdasd', N'sdas', N'das', N'asd', N'asdasd', N'asdasd', N'male', N'4.01.2023', N'arabic english', N'')
SET IDENTITY_INSERT [dbo].[patientDB] OFF
USE [master]
GO
ALTER DATABASE [patients] SET  READ_WRITE 
GO
