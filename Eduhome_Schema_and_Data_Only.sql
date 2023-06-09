USE [master]
GO
/****** Object:  Database [db_a9898e_ruslanaspnetcore01]    Script Date: 5/7/2023 2:11:20 AM ******/
CREATE DATABASE [db_a9898e_ruslanaspnetcore01]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_a9898e_ruslanaspnetcore01_Data', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_a9898e_ruslanaspnetcore01_DATA.mdf' , SIZE = 8192KB , MAXSIZE = 1024000KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'db_a9898e_ruslanaspnetcore01_Log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_a9898e_ruslanaspnetcore01_Log.LDF' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_a9898e_ruslanaspnetcore01].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET  MULTI_USER 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET QUERY_STORE = OFF
GO
USE [db_a9898e_ruslanaspnetcore01]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/7/2023 2:11:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Fullname] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bios]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Pinterest] [nvarchar](max) NULL,
	[Twitter] [nvarchar](max) NULL,
	[Vimeo] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Site] [nvarchar](max) NULL,
	[SliderDescription] [nvarchar](max) NULL,
	[SliderTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_Bios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Explain] [nvarchar](max) NOT NULL,
	[AuthorName] [nvarchar](max) NOT NULL,
	[Date] [nvarchar](max) NOT NULL,
	[BlogBody] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[PreTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Subject] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseContents]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseContents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[About] [nvarchar](max) NULL,
	[HowToApply] [nvarchar](max) NULL,
	[Certification] [nvarchar](max) NULL,
 CONSTRAINT [PK_CourseContents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseFeatures]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseFeatures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sarts] [nvarchar](max) NOT NULL,
	[Duration] [nvarchar](max) NOT NULL,
	[ClassDuration] [nvarchar](max) NOT NULL,
	[SkillLevel] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NOT NULL,
	[StudentCount] [int] NOT NULL,
	[Assement] [nvarchar](max) NOT NULL,
	[CourseFee] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_CourseFeatures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CourseContentId] [int] NOT NULL,
	[CourseFeatureId] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[EventName] [nvarchar](max) NOT NULL,
	[EventDurationTime] [nvarchar](max) NOT NULL,
	[Venue] [nvarchar](max) NOT NULL,
	[Explain] [nvarchar](max) NOT NULL,
	[Date] [nvarchar](max) NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventSpikers]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventSpikers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[SpeakerId] [int] NOT NULL,
 CONSTRAINT [PK_EventSpikers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Informations]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Informations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Informations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notices]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Notices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Replies]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Replies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Subject] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Replies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skills]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Language] [int] NOT NULL,
	[TeamLeader] [int] NOT NULL,
	[Development] [int] NOT NULL,
	[Design] [int] NOT NULL,
	[Innovation] [int] NOT NULL,
	[Communication] [int] NOT NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sliders]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sliders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sliders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Speakers]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Speakers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Profession] [nvarchar](max) NULL,
 CONSTRAINT [PK_Speakers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Explain] [nvarchar](max) NULL,
	[Fullname] [nvarchar](max) NULL,
	[Profession] [nvarchar](max) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](70) NOT NULL,
	[Profession] [nvarchar](70) NOT NULL,
	[About] [nvarchar](400) NOT NULL,
	[Degree] [nvarchar](60) NOT NULL,
	[Experience] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](70) NOT NULL,
	[Hobbies] [nvarchar](50) NOT NULL,
	[Faculity] [nvarchar](100) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[SkypeAddress] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Facebook] [nvarchar](max) NOT NULL,
	[Pinterest] [nvarchar](max) NOT NULL,
	[Twitter] [nvarchar](max) NOT NULL,
	[Vimeo] [nvarchar](max) NOT NULL,
	[SkillId] [int] NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videos]    Script Date: 5/7/2023 2:11:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VideoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Videos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200704133115_CreateDataBase', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200704152749_CreateTeacherandSkillss', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200704153127_AddSkypeAdress', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200704155302_AddBiosTeacherTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200704155957_AddImageColumnTeacher', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200704161811_AddTeachersIdColumnBios', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200704170932_DeleteBios', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200705065141_UpdateRelationTeacherSkills', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200705065755_RelationTeacherAndSkill', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200705075005_AddColumn', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200705104404_CreateCourseTables', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200705120832_UpdatenameTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200705141738_CreateBioTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200705162514_CreateBlogTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200705162945_UpdateBlog', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200706101323_AddColumnBlog', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200706110316_CreateEventandSpiker', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200706114351_UpdateEventTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200706142034_AddUserSystem', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200707123220_CreateSliderandSliderContent', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200707142333_CreateNoticeStudentInformationTables', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200707142958_UpdateTables', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200707143314_AddVideoTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200708090515_CreateClientTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200708134430_AddImagePathColumnSlider', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200708135149_DeleteImagePathColumn', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200709095034_UpdateSliderTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200709114158_UpdateSliderandBio', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710092108_UpdateCourseTable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710105154_UpdateCourse', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200710105352_updateCourseCoulmns', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200715130320_CreateManyToManyRelationship', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200715135009_AddDal', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200717131854_CreateReply', N'2.1.14-servicing-32113')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'12676ad0-4bb6-4b3d-8e7e-6baed69060fb', N'Members', N'MEMBERS', N'a0891c27-3ce6-4c8e-ad8a-5bece362eb25')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'aab5df88-ca21-425d-8143-de4224c60315', N'Admin', N'ADMIN', N'aab5df88-ca21-425d-8143-de4224c60319')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'28c30abd-b1fa-4c44-b151-2307e6e18cad', N'12676ad0-4bb6-4b3d-8e7e-6baed69060fb')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [IsDeleted], [Fullname]) VALUES (N'28c30abd-b1fa-4c44-b151-2307e6e18cad', N'RuslanEyvazli', N'RUSLANEYVAZLI', N'rus.eyvazli@gmail.com', N'RUS.EYVAZLI@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEM5LCTPcslkBeeUWBqKU/TuyDpYQdsXyDrDwKhbUEYkc24TptkBaCsd7SV+WV8VXNA==', N'DO2AFP7BI4ZRZPSE6J2ALMHUNTH4XZW2', N'de409b50-fcc2-44e8-9646-6c48366c94f6', NULL, 0, 0, NULL, 1, 0, 0, N'Ruslan')
SET IDENTITY_INSERT [dbo].[Bios] ON 

INSERT [dbo].[Bios] ([Id], [PhoneNumber], [Facebook], [Pinterest], [Twitter], [Vimeo], [Address], [Site], [SliderDescription], [SliderTitle]) VALUES (1, N'+48516492663', N'Ruslan Eyvazli', N'rusey', N'Ruslan Eyvazli', N'Ruslan', N'Ruslan', N'Ruslan.eyvazli.com', N'I must explain to you how all this mistaken idea of denouncing pleasure and prsing pain was born and I will give you a complete account of the system  ', N'EDUCATION MAKES HUMANITY ')
SET IDENTITY_INSERT [dbo].[Bios] OFF
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Explain], [AuthorName], [Date], [BlogBody], [Image], [PreTitle]) VALUES (1, N'I MUST EXPLAIN TO YOU HOW ALL THIS A MISTAKEN IDEA', N'Ruslan', N'20-03-2023', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui

I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam

I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam

I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam', N'blog-detail.jpg', N'I MUST EXPLAIN TO YOU HOW ALL THIS A MISTAKEN IDEA')
INSERT [dbo].[Blogs] ([Id], [Explain], [AuthorName], [Date], [BlogBody], [Image], [PreTitle]) VALUES (24, N'I MUST EXPLAIN TO YOU HOW ALL THIS A MISTAKEN IDEA', N'Ruslan', N'20-03-2023', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam volutatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui

I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam

I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque la udantium, totam rem aperiam

I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human haness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque sa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo emo enim ipsam', N'blog-detail.jpg', N'I MUST EXPLAIN TO YOU HOW ALL THIS A MISTAKEN IDEA')
SET IDENTITY_INSERT [dbo].[Blogs] OFF
SET IDENTITY_INSERT [dbo].[CourseContents] ON 

INSERT [dbo].[CourseContents] ([Id], [About], [HowToApply], [Certification]) VALUES (1, N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss', N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss', N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss

I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human')
INSERT [dbo].[CourseContents] ([Id], [About], [HowToApply], [Certification]) VALUES (2, N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss', N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss', N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss')
INSERT [dbo].[CourseContents] ([Id], [About], [HowToApply], [Certification]) VALUES (3, N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss', N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss', N'I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human happinescias unde omnis iste natus error sit volptatem accuntium mque laudantium perspiciatis unde omnis iste natuss')
SET IDENTITY_INSERT [dbo].[CourseContents] OFF
SET IDENTITY_INSERT [dbo].[CourseFeatures] ON 

INSERT [dbo].[CourseFeatures] ([Id], [Sarts], [Duration], [ClassDuration], [SkillLevel], [Language], [StudentCount], [Assement], [CourseFee]) VALUES (1, N'25 JUNE, 2017', N'6 MONTH', N'3 HOURS', N'ALL LEVEL', N'ENGLISH', 420, N'SELF', CAST(789.00 AS Decimal(18, 2)))
INSERT [dbo].[CourseFeatures] ([Id], [Sarts], [Duration], [ClassDuration], [SkillLevel], [Language], [StudentCount], [Assement], [CourseFee]) VALUES (2, N'25 JUNE, 2017', N'6 MONTH', N'3 HOURS', N'ALL LEVEL', N'ENGLISH', 420, N'SELF', CAST(789.00 AS Decimal(18, 2)))
INSERT [dbo].[CourseFeatures] ([Id], [Sarts], [Duration], [ClassDuration], [SkillLevel], [Language], [StudentCount], [Assement], [CourseFee]) VALUES (3, N'25 JUNE, 2017', N'6 MONTH', N'3 HOURS', N'ALL LEVEL', N'ENGLISH', 420, N'SELF', CAST(789.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[CourseFeatures] OFF
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([Id], [Image], [CourseName], [Description], [CourseContentId], [CourseFeatureId]) VALUES (3, N'course5.jpg', N'CSE ENGINEERING', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui', 1, 1)
INSERT [dbo].[Courses] ([Id], [Image], [CourseName], [Description], [CourseContentId], [CourseFeatureId]) VALUES (14, N'course4.jpg', N'POLITICAL SCIENCE', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness', 2, 2)
INSERT [dbo].[Courses] ([Id], [Image], [CourseName], [Description], [CourseContentId], [CourseFeatureId]) VALUES (16, N'course3.jpg', N'MICRO BIOLOGY', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness', 3, 3)
SET IDENTITY_INSERT [dbo].[Courses] OFF
SET IDENTITY_INSERT [dbo].[Events] ON 

INSERT [dbo].[Events] ([Id], [Image], [EventName], [EventDurationTime], [Venue], [Explain], [Date]) VALUES (1, N'event13.jpg', N'ADVANCE WED DEVELOPMENT WORKSHOP', N'9:30am - 4:45pm', N' Cristal Centre, 254 New Yourk', N'20-06-2023', N'20 June')
INSERT [dbo].[Events] ([Id], [Image], [EventName], [EventDurationTime], [Venue], [Explain], [Date]) VALUES (2, N'aab5df88-ca21-425d-8143-de4224c60315event9.jpg', N'DIGITAL MARKETING ANALYSIS', N'9.00 AM - 4.45 PM', N'New Yourk City', N'
18 June ', N'
18 June ')
INSERT [dbo].[Events] ([Id], [Image], [EventName], [EventDurationTime], [Venue], [Explain], [Date]) VALUES (4, N'5ce1b7e1-a46f-463b-9bfc-6b646445ac5eevent3.jpg', N'LEARNING ENGLISH HISTORY', N'9.00 AM - 4.45 PM', N'New Yourk City', N'16 June  ', N'16 June ')
INSERT [dbo].[Events] ([Id], [Image], [EventName], [EventDurationTime], [Venue], [Explain], [Date]) VALUES (5, N'd4c08caa-8184-4112-9f2f-e4c3de5b5e82event2.jpg', N'UI & UX DESIGNER MEETUP', N'9.00 AM - 4.45 PM', N'New Yourk City', N'16 June  ', N'16 June ')
SET IDENTITY_INSERT [dbo].[Events] OFF
SET IDENTITY_INSERT [dbo].[EventSpikers] ON 

INSERT [dbo].[EventSpikers] ([Id], [EventId], [SpeakerId]) VALUES (1, 1, 1)
INSERT [dbo].[EventSpikers] ([Id], [EventId], [SpeakerId]) VALUES (2, 2, 2)
SET IDENTITY_INSERT [dbo].[EventSpikers] OFF
SET IDENTITY_INSERT [dbo].[Informations] ON 

INSERT [dbo].[Informations] ([Id], [Image], [Title], [Description]) VALUES (1, N'about.png', N'WELCOME TO EDUHOME', N'I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system, and expound the actual teachings the master-builder of humanit happiness

I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system')
INSERT [dbo].[Informations] ([Id], [Image], [Title], [Description]) VALUES (2, N'about.png', N'WELCOME TO EDUHOME', N'I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system, and expound the actual teachings the master-builder of humanit happiness

I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system')
SET IDENTITY_INSERT [dbo].[Informations] OFF
SET IDENTITY_INSERT [dbo].[Notices] ON 

INSERT [dbo].[Notices] ([Id], [Date], [Description]) VALUES (1, N'5, June 2017', N'I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete')
INSERT [dbo].[Notices] ([Id], [Date], [Description]) VALUES (2, N'4, June 2017', N'I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete')
INSERT [dbo].[Notices] ([Id], [Date], [Description]) VALUES (3, N'3, June 2017', N'I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete')
INSERT [dbo].[Notices] ([Id], [Date], [Description]) VALUES (4, N'5, June 2017', N'I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete')
INSERT [dbo].[Notices] ([Id], [Date], [Description]) VALUES (5, N'4, June 2017', N'I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete')
INSERT [dbo].[Notices] ([Id], [Date], [Description]) VALUES (6, N'3, June 2017', N'I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete')
SET IDENTITY_INSERT [dbo].[Notices] OFF
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([Id], [Language], [TeamLeader], [Development], [Design], [Innovation], [Communication]) VALUES (1, 85, 90, 85, 95, 85, 95)
INSERT [dbo].[Skills] ([Id], [Language], [TeamLeader], [Development], [Design], [Innovation], [Communication]) VALUES (2, 85, 90, 85, 95, 85, 95)
INSERT [dbo].[Skills] ([Id], [Language], [TeamLeader], [Development], [Design], [Innovation], [Communication]) VALUES (3, 85, 90, 85, 95, 85, 95)
INSERT [dbo].[Skills] ([Id], [Language], [TeamLeader], [Development], [Design], [Innovation], [Communication]) VALUES (4, 85, 90, 85, 95, 85, 95)
SET IDENTITY_INSERT [dbo].[Skills] OFF
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [Image]) VALUES (1, N'416d8438-9f53-404c-a548-e066434614e8slider1.jpg')
INSERT [dbo].[Sliders] ([Id], [Image]) VALUES (2, N'4872ef3a-2b7f-4960-abe5-3057a009e5cfslider2.jpg')
INSERT [dbo].[Sliders] ([Id], [Image]) VALUES (3, N'c1223b19-b5e1-41ef-accf-eb99570d9dbfslider1.jpg')
INSERT [dbo].[Sliders] ([Id], [Image]) VALUES (4, N'fe8954e1-e555-4157-8470-1508945fce6aslider3.jpg')
INSERT [dbo].[Sliders] ([Id], [Image]) VALUES (5, N'home.png')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
SET IDENTITY_INSERT [dbo].[Speakers] ON 

INSERT [dbo].[Speakers] ([Id], [Fullname], [Image], [Profession]) VALUES (1, N'Anthony Smith', N'ee01e021-b1e2-4e26-9b16-b21d7c0ebe72speaker1.jpg', N'CEO, Hastech')
INSERT [dbo].[Speakers] ([Id], [Fullname], [Image], [Profession]) VALUES (2, N'Lucy Rose', N'aab5df88-ca21-425d-8143-de4224c60315event9.jpg', N'Developer, STD')
SET IDENTITY_INSERT [dbo].[Speakers] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Image], [Explain], [Fullname], [Profession]) VALUES (1, N'testimonial.jpg', N'I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account of the system, and expound the actual', N'David Morgan', N'Student, CSE')
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([Id], [FullName], [Profession], [About], [Degree], [Experience], [Email], [Hobbies], [Faculity], [PhoneNumber], [SkypeAddress], [Image], [Facebook], [Pinterest], [Twitter], [Vimeo], [SkillId]) VALUES (2, N'STUART KELVIN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'stuart@eduhome.com', N'music, travelling, catching fish', N'Din, Department of Micro Biology', N'(+125) 5896 548 9874', N'stuart.k', N'18ba43b7-3767-435a-96bc-0310a3b4c030teacher8.jpg', N'stuart.k', N'stuart.k', N'stuart.k', N'stuart.k', 1)
INSERT [dbo].[Teachers] ([Id], [FullName], [Profession], [About], [Degree], [Experience], [Email], [Hobbies], [Faculity], [PhoneNumber], [SkypeAddress], [Image], [Facebook], [Pinterest], [Twitter], [Vimeo], [SkillId]) VALUES (4, N'EAMILY CRISTIAN', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'stuart@eduhome.com', N'music, travelling, catching fish', N'Din, Department of Micro Biology', N'(+125) 5896 548 9874', N'stuart.k', N'teacher10.jpg', N'stuart.k', N'stuart.k', N'stuart.k', N'stuart.k', 2)
INSERT [dbo].[Teachers] ([Id], [FullName], [Profession], [About], [Degree], [Experience], [Email], [Hobbies], [Faculity], [PhoneNumber], [SkypeAddress], [Image], [Facebook], [Pinterest], [Twitter], [Vimeo], [SkillId]) VALUES (7, N'KEVIN WILLIAMS', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'stuart@eduhome.com', N'music, travelling, catching fish', N'Din, Department of Micro Biology', N'(+125) 5896 548 9874', N'stuart.k', N'teacher6.jpg', N'stuart.k', N'stuart.k', N'stuart.k', N'stuart.k', 3)
INSERT [dbo].[Teachers] ([Id], [FullName], [Profession], [About], [Degree], [Experience], [Email], [Hobbies], [Faculity], [PhoneNumber], [SkypeAddress], [Image], [Facebook], [Pinterest], [Twitter], [Vimeo], [SkillId]) VALUES (9, N'SALINA GOMAZE', N'Associate Professor', N'I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium ue laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quas i architeo beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas', N'PHD in Micro Biology', N'7 years experience', N'stuart@eduhome.com', N'music, travelling, catching fish', N'Din, Department of Micro Biology', N'(+125) 5896 548 9874', N'stuart.k', N'teacher4.jpg', N'stuart.k', N'stuart.k', N'stuart.k', N'stuart.k', 4)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Courses_CourseContentId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Courses_CourseContentId] ON [dbo].[Courses]
(
	[CourseContentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Courses_CourseFeatureId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Courses_CourseFeatureId] ON [dbo].[Courses]
(
	[CourseFeatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EventSpikers_EventId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_EventSpikers_EventId] ON [dbo].[EventSpikers]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EventSpikers_SpeakerId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_EventSpikers_SpeakerId] ON [dbo].[EventSpikers]
(
	[SpeakerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Teachers_SkillId]    Script Date: 5/7/2023 2:11:48 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Teachers_SkillId] ON [dbo].[Teachers]
(
	[SkillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Courses] ADD  DEFAULT ((0)) FOR [CourseContentId]
GO
ALTER TABLE [dbo].[Courses] ADD  DEFAULT ((0)) FOR [CourseFeatureId]
GO
ALTER TABLE [dbo].[EventSpikers] ADD  DEFAULT ((0)) FOR [EventId]
GO
ALTER TABLE [dbo].[EventSpikers] ADD  DEFAULT ((0)) FOR [SpeakerId]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT (N'') FOR [Image]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT (N'') FOR [Facebook]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT (N'') FOR [Pinterest]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT (N'') FOR [Twitter]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT (N'') FOR [Vimeo]
GO
ALTER TABLE [dbo].[Teachers] ADD  DEFAULT ((0)) FOR [SkillId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_CourseContents_CourseContentId] FOREIGN KEY([CourseContentId])
REFERENCES [dbo].[CourseContents] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_CourseContents_CourseContentId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_CourseFeatures_CourseFeatureId] FOREIGN KEY([CourseFeatureId])
REFERENCES [dbo].[CourseFeatures] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_CourseFeatures_CourseFeatureId]
GO
ALTER TABLE [dbo].[EventSpikers]  WITH CHECK ADD  CONSTRAINT [FK_EventSpikers_Events_EventId] FOREIGN KEY([EventId])
REFERENCES [dbo].[Events] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventSpikers] CHECK CONSTRAINT [FK_EventSpikers_Events_EventId]
GO
ALTER TABLE [dbo].[EventSpikers]  WITH CHECK ADD  CONSTRAINT [FK_EventSpikers_Speakers_SpeakerId] FOREIGN KEY([SpeakerId])
REFERENCES [dbo].[Speakers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventSpikers] CHECK CONSTRAINT [FK_EventSpikers_Speakers_SpeakerId]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Skills_SkillId] FOREIGN KEY([SkillId])
REFERENCES [dbo].[Skills] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Skills_SkillId]
GO
USE [master]
GO
ALTER DATABASE [db_a9898e_ruslanaspnetcore01] SET  READ_WRITE 
GO
