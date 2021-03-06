USE [master]
GO
/****** Object:  Database [AttendanceDB]    Script Date: 9/21/2015 7:31:19 PM ******/
CREATE DATABASE [AttendanceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AttendanceDB', FILENAME = N'F:\AttendanceAppBalancika-master\AttendanceDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AttendanceDB_log', FILENAME = N'F:\AttendanceAppBalancika-master\AttendanceDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AttendanceDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AttendanceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AttendanceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AttendanceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AttendanceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AttendanceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AttendanceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AttendanceDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AttendanceDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [AttendanceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AttendanceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AttendanceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AttendanceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AttendanceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AttendanceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AttendanceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AttendanceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AttendanceDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AttendanceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AttendanceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AttendanceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AttendanceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AttendanceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AttendanceDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AttendanceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AttendanceDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AttendanceDB] SET  MULTI_USER 
GO
ALTER DATABASE [AttendanceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AttendanceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AttendanceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AttendanceDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AttendanceDB', N'ON'
GO
USE [AttendanceDB]
GO
/****** Object:  Table [dbo].[tbl_attendance]    Script Date: 9/21/2015 7:31:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_attendance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_tbl_attendance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_stuff]    Script Date: 9/21/2015 7:31:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_stuff](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[fullname] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_stuff] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_attendance] ON 

INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (4, 5, CAST(0x703A0B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (5, 6, CAST(0x703A0B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (6, 5, CAST(0x143A0B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (9, 5, CAST(0x6E390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (10, 6, CAST(0x6E390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (11, 5, CAST(0x91390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (12, 6, CAST(0x91390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (13, 5, CAST(0xB5390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (14, 6, CAST(0xB5390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (16, 6, CAST(0xE5390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (17, 5, CAST(0xCB390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (18, 5, CAST(0xCC390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (19, 5, CAST(0xD8390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (20, 5, CAST(0xD9390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (21, 5, CAST(0xDA390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (22, 5, CAST(0xDB390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (23, 5, CAST(0xDC390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (24, 5, CAST(0xDD390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (25, 5, CAST(0xDE390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (26, 5, CAST(0xE1390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (27, 5, CAST(0xE2390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (28, 5, CAST(0xE3390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (29, 5, CAST(0xE4390B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (30, 5, CAST(0x713A0B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (31, 4, CAST(0x713A0B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (32, 5, CAST(0x723A0B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (33, 6, CAST(0x723A0B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (34, 7, CAST(0x723A0B00 AS Date))
INSERT [dbo].[tbl_attendance] ([Id], [userId], [date]) VALUES (35, 4, CAST(0x723A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[tbl_attendance] OFF
SET IDENTITY_INSERT [dbo].[tbl_stuff] ON 

INSERT [dbo].[tbl_stuff] ([Id], [username], [password], [fullname]) VALUES (4, N'delowar', N'delowar123', N'Delowar Hosen')
INSERT [dbo].[tbl_stuff] ([Id], [username], [password], [fullname]) VALUES (5, N'omi', N'omi123', N'Khairul Omi')
INSERT [dbo].[tbl_stuff] ([Id], [username], [password], [fullname]) VALUES (6, N'shibly', N'shibly123', N'Musfiqur Shibly')
INSERT [dbo].[tbl_stuff] ([Id], [username], [password], [fullname]) VALUES (7, N'mashfiq', N'mashfiq123', N'Masfiq Nahid')
SET IDENTITY_INSERT [dbo].[tbl_stuff] OFF
USE [master]
GO
ALTER DATABASE [AttendanceDB] SET  READ_WRITE 
GO
