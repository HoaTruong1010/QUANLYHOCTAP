USE [master]
GO
/****** Object:  Database [QuanLyHocTap]    Script Date: 3/22/2023 11:46:25 AM ******/
CREATE DATABASE [QuanLyHocTap]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyHocTap', FILENAME = N'D:\LTCSDL\QLHT\QuanLyHocTap.mdf' , SIZE = 51200KB , MAXSIZE = 102400KB , FILEGROWTH = 10240KB )
 LOG ON 
( NAME = N'QuanLyHocTap_log', FILENAME = N'D:\LTCSDL\QLHT\QuanLyHocTap.ldf' , SIZE = 10240KB , MAXSIZE = 51200KB , FILEGROWTH = 10240KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyHocTap] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHocTap].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHocTap] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHocTap] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHocTap] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyHocTap] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHocTap] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyHocTap] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHocTap] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHocTap] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyHocTap] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyHocTap] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyHocTap] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyHocTap] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyHocTap', N'ON'
GO
ALTER DATABASE [QuanLyHocTap] SET QUERY_STORE = OFF
GO
USE [QuanLyHocTap]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 3/22/2023 11:46:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[ClassID] [varchar](8) NOT NULL,
	[ClassName] [varchar](20) NOT NULL,
	[TotalStudent] [int] NOT NULL,
	[TeacherID] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scores]    Script Date: 3/22/2023 11:46:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scores](
	[TeachingID] [int] NOT NULL,
	[StudentID] [varchar](10) NOT NULL,
	[Registration_Date] [date] NOT NULL,
	[MidtermScore] [decimal](4, 2) NULL,
	[ModifiedDateOfMidtermScore] [date] NULL,
	[EndPointScore] [decimal](3, 2) NULL,
	[ModifiedDateOfEndPointScore] [date] NULL,
 CONSTRAINT [PK_Score] PRIMARY KEY CLUSTERED 
(
	[TeachingID] ASC,
	[StudentID] ASC,
	[Registration_Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 3/22/2023 11:46:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [varchar](10) NOT NULL,
	[StudentName] [varchar](20) NOT NULL,
	[DayOfBirth] [date] NOT NULL,
	[ID] [varchar](12) NOT NULL,
	[Email] [varchar](40) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
	[StudentAddress] [varchar](100) NOT NULL,
	[ClassID] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 3/22/2023 11:46:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectID] [varchar](8) NOT NULL,
	[SubjectName] [varchar](25) NOT NULL,
	[Credits] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 3/22/2023 11:46:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherID] [varchar](8) NOT NULL,
	[TeacherName] [varchar](20) NOT NULL,
	[DayOfBirth] [date] NOT NULL,
	[ID] [varchar](12) NOT NULL,
	[Email] [varchar](40) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
	[TeacherAddress] [varchar](100) NOT NULL,
	[TeacherCertificate] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teaching]    Script Date: 3/22/2023 11:46:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teaching](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [varchar](8) NOT NULL,
	[SubjectID] [varchar](8) NOT NULL,
	[RegisterDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVKT0001', N'Toan', CAST(N'1994-02-04' AS Date), N'038598336441', N'gvkt0001@gmail.com', N'0976448128', N'9833 Mt. Dias Blv. Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVKT0002', N'G', CAST(N'1990-08-09' AS Date), N'074498124573', N'gvkt0002@gmail.com', N'0842197563', N'5672 Hale Dr. Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVKT0003', N'H', CAST(N'1992-07-09' AS Date), N'013000015894', N'gvkt0003@gmail.com', N'0344986666', N'6387 Scenic Avenue Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVKT0004', N'I', CAST(N'1997-05-07' AS Date), N'012365484125', N'gvkt0004@gmail.com', N'0215877774', N'8713 Yosemite Ct. Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVKT0005', N'J', CAST(N'1995-04-10' AS Date), N'065428913654', N'gvkt0005@gmail.com', N'0288647933', N'250 Race Court Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVLA0001', N'K', CAST(N'1986-06-11' AS Date), N'023651934870', N'gvla0001@gmail.com', N'0264473981', N'1318 Lasalle Street Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVLA0002', N'L', CAST(N'1991-09-12' AS Date), N'021563478120', N'gvla0002@gmail.com', N'0888439991', N'5415 San Gabriel Dr. Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVLA0003', N'X', CAST(N'1987-07-10' AS Date), N'056987132469', N'gvla0003@gmail.com', N'0344488167', N'9265 La Paz Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVLA0004', N'Q', CAST(N'1994-11-12' AS Date), N'012579161087', N'gvla00014@gmail.com', N'0336666789', N'8157 W. Book Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVLA0005', N'Z', CAST(N'1987-11-11' AS Date), N'745893148527', N'gvla0005@gmail.com', N'0332224687', N'
4912 La Vuelta
 Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVNN0001', N'T', CAST(N'1988-01-30' AS Date), N'092230688710', N'gvnn0001@gmail.com', N'0200051368', N'6696 Anchor Drive
 Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVNN0002', N'H', CAST(N'1996-02-24' AS Date), N'098632147855', N'gvnn0002@gmail.com', N'0220154986', N'40 Ellis St.
 Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVNN0003', N'U', CAST(N'1990-05-19' AS Date), N'040026587310', N'gvnn0003@gmail.com', N'0236874416', N'
1873 Lion Circle
 Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVNN0004', N'Y', CAST(N'1991-12-31' AS Date), N'084653211122', N'gvnn0004@gmail.com', N'0996325874', N'
3148 Rose Street
 Bothell', N'TIEN SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVNN0005', N'S', CAST(N'1989-06-29' AS Date), N'088654123337', N'gvkt0005@gmail.com', N'0335874628', N'6872 Thornwood Dr. Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVTH0001', N'A', CAST(N'1991-01-01' AS Date), N'052478116449', N'abc@gmail.com', N'0349001672', N'1970 Napa Ct. Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVTH0002', N'C', CAST(N'1989-04-01' AS Date), N'054987618214', N'gvth0002@gmail.com', N'0147543698', N'7484 Roundtree Drive Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVTH0003', N'D', CAST(N'1989-04-07' AS Date), N'099365478546', N'gvth0003@gmail.com', N'0817543698', N'9539 Glenside Dr Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVTH0004', N'E', CAST(N'1988-02-04' AS Date), N'056983214789', N'gvth0004@gmail.com', N'0716943842', N'1226 Shoe St. Bothell', N'THAC SI')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [DayOfBirth], [ID], [Email], [Phone], [TeacherAddress], [TeacherCertificate]) VALUES (N'GVTH0005', N'F', CAST(N'1987-01-01' AS Date), N'032569871412', N'gvth0005@gmail.com', N'0874692365', N'1399 Firestone Drive Bothell', N'THAC SI')
GO
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'KT0100', N'Analytics', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'KT0200', N'Macroeconomic', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'KT0300', N'Microeconomics', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'KT0400', N'Linear algebra', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'KT0500', N'General economics', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'LA0100', N'General law', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'LA0200', N'Civil law', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'LA0300', N'Administrative law', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'LA0400', N'Inheritance law', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'LA0500', N'Judicial Law', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'NN0100', N'Listening', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'NN0200', N'Reading', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'NN0300', N'Writing', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'NN0400', N'Speaking', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'NN0500', N'Travel translation', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'TH0100', N'Programming base', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'TH0200', N'Web design', 3)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'TH0300', N'Network administrator', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'TH0400', N'Operating system', 4)
INSERT [dbo].[Subjects] ([SubjectID], [SubjectName], [Credits]) VALUES (N'TH0500', N'Database', 3)
GO
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH20IT01', N'IT01', 50, N'GVTH0002')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH20IT02', N'IT02', 50, N'GVTH0004')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH20KT01', N'KT01', 50, N'GVKT0001')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH20KT02', N'KT02', 50, N'GVKT0003')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH20LA01', N'LA01', 50, N'GVLA0003')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH20LA02', N'LA02', 50, N'GVLA0002')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH20NN01', N'NN01', 50, N'GVNN0003')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH20NN02', N'NN02', 50, N'GVNN0004')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH21IT01', N'IT11', 50, N'GVTH0003')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH21IT02', N'IT12', 50, N'GVTH0005')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH21KT01', N'KT11', 50, N'GVKT0002')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH21KT02', N'KT12', 50, N'GVKT0005')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH21LA01', N'LA11', 50, N'GVLA0001')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH21LA02', N'LA12', 50, N'GVLA0004')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH21NN01', N'NN11', 50, N'GVNN0001')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH21NN02', N'NN12', 50, N'GVNN0005')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH22IT01', N'IT21', 50, N'GVTH0001')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH22KT01', N'KT21', 50, N'GVKT0004')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH22LA01', N'LA21', 50, N'GVLA0005')
INSERT [dbo].[Classes] ([ClassID], [ClassName], [TotalStudent], [TeacherID]) VALUES (N'DH22NN01', N'NN21', 50, N'GVNN0002')
GO
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000001', N'Maria Anders', CAST(N'1999-01-06' AS Date), N'046987263159', N'0000000001@gmail.cpm', N'0335466687', N'Obere Str. 57 Berlin', N'DH20IT01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000002', N'Ana Trujillo', CAST(N'1999-06-03' AS Date), N'002569874115', N'0000000002@gmail.cpm', N'0665987465', N'Avda. de la Constitución 2222 México D.F.', N'DH21LA01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000003', N'Antonio Moreno', CAST(N'2000-07-19' AS Date), N'050006229874', N'0000000003@gmail.cpm', N'0998765125', N'Mataderos  2312 México D.F.', N'DH20IT02')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000004', N'Thomas Hardy', CAST(N'1999-12-21' AS Date), N'099000658777', N'0000000004@gmail.cpm', N'0336987452', N'120 Hanover Sq. London', N'DH21KT02')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000005', N'
Christina Berglund', CAST(N'1998-11-07' AS Date), N'088569994120', N'0000000005@gmail.cpm', N'0998865479', N'Berguvsvägen  8 Luleå', N'DH20KT02')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000006', N'Hanna Moos
', CAST(N'2000-09-01' AS Date), N'055844199334', N'0000000006@gmail.cpm', N'0660146987', N'Forsterstr. 57
Mannheim', N'DH20LA02')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000007', N'Frédérique Citeaux', CAST(N'1998-12-21' AS Date), N'019987765320', N'0000000007@gmail.cpm', N'0666541884', N'City
24, place Kléber Strasbourg', N'DH21NN02')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000008', N'Martín Sommer', CAST(N'2000-01-01' AS Date), N'025547149993', N'0000000008@gmail.cpm', N'0564854985', N'City
C/ Araquil, 67 Madrid', N'DH22KT01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000009', N'Laurence Lebihan
', CAST(N'2001-09-04' AS Date), N'088546332977', N'0000000009@gmail.cpm', N'0565468796', N'City12, rue des Bouchers Marseille', N'DH20IT01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000010', N'Elizabeth Lincoln', CAST(N'1999-12-12' AS Date), N'011145889965', N'0000000010@gmail.cpm', N'0546849785', N'City
23 Tsawassen Blvd. Tsawassen', N'DH20KT02')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000011', N'Victoria Ashworth', CAST(N'2000-04-09' AS Date), N'018899955514', N'0000000011@gmail.cpm', N'0587498511', N'City
Fauntleroy Circus London', N'DH20IT02')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000012', N'Patricio Simpson', CAST(N'1998-03-28' AS Date), N'099988885551', N'0000000012@gmail.cpm', N'0215468748', N'City
Cerrito 333 Buenos Aires', N'DH22IT01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000013', N'Francisco Chang', CAST(N'2001-05-22' AS Date), N'033664887772', N'0000000013@gmail.cpm', N'0156468799', N'City
Sierras de Granada 9993 México D.F.', N'DH20NN01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000014', N'Yang Wang', CAST(N'2001-06-04' AS Date), N'022599915226', N'0000000014@gmail.cpm', N'0215648788', N'City
Hauptstr. 29 Bern', N'DH20IT01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000015', N'Pedro Afonso', CAST(N'2000-08-26' AS Date), N'099447856333', N'0000000015@gmail.cpm', N'0156848754', N'City
Av. dos Lusíadas, 23 São Paulo', N'DH21IT01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000016', N'Elizabeth Brown', CAST(N'2001-09-13' AS Date), N'055887444111', N'0000000016@gmail.cpm', N'0548574878', N'City
Berkeley Gardens
12  Brewery London', N'DH20LA02')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000017', N'Sven Ottlieb', CAST(N'1998-07-11' AS Date), N'033666555881', N'0000000017@gmail.cpm', N'0154798784', N'City
Walserweg 21 Aachen', N'DH21LA01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000018', N'Janine Labrune', CAST(N'1999-05-25' AS Date), N'099334561888', N'0000000018@gmail.cpm', N'0323564878', N'67, rue des Cinquante Otages Nantes', N'DH20IT01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000019', N'Ann Devon', CAST(N'2000-04-29' AS Date), N'022299974161', N'0000000019@gmail.cpm', N'0215485052', N'City
35 King George London', N'DH20NN01')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DayOfBirth], [ID], [Email], [Phone], [StudentAddress], [ClassID]) VALUES (N'0000000020', N'Roland Mendel', CAST(N'2001-03-30' AS Date), N'022299986315', N'0000000020@gmail.cpm', N'0215687842', N'City
Kirchgasse 6 Graz', N'DH22LA01')
GO
SET IDENTITY_INSERT [dbo].[Teaching] ON 

INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (1, N'GVKT0001', N'KT0300', CAST(N'2023-03-21' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (2, N'GVKT0001', N'KT0400', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (3, N'GVKT0003', N'KT0200', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (4, N'GVKT0004', N'KT0500', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (5, N'GVKT0005', N'KT0400', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (6, N'GVLA0001', N'LA0400', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (7, N'GVLA0001', N'LA0500', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (8, N'GVLA0002', N'LA0300', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (9, N'GVLA0004', N'LA0500', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (10, N'GVLA0005', N'LA0100', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (11, N'GVNN0001', N'NN0300', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (12, N'GVNN0002', N'NN0300', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (13, N'GVNN0004', N'NN0200', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (14, N'GVTH0001', N'TH0100', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (15, N'GVTH0001', N'TH0400', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (16, N'GVTH0002', N'TH0100', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (17, N'GVTH0002', N'TH0300', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (18, N'GVTH0003', N'TH0500', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (19, N'GVTH0004', N'TH0200', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Teaching] ([ID], [TeacherID], [SubjectID], [RegisterDate]) VALUES (20, N'GVTH0005', N'TH0100', CAST(N'2022-12-20' AS Date))
SET IDENTITY_INSERT [dbo].[Teaching] OFF
GO
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (1, N'0000000001', CAST(N'2022-12-25' AS Date), CAST(9.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(9.80 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (1, N'0000000007', CAST(N'2022-12-25' AS Date), CAST(4.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(6.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (1, N'0000000016', CAST(N'2022-12-25' AS Date), CAST(1.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(9.50 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (2, N'0000000010', CAST(N'2022-12-25' AS Date), CAST(9.80 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(5.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (2, N'0000000020', CAST(N'2022-12-25' AS Date), CAST(8.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(7.50 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (3, N'0000000003', CAST(N'2022-12-25' AS Date), CAST(5.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(7.80 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (4, N'0000000006', CAST(N'2022-12-25' AS Date), CAST(4.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(6.50 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (5, N'0000000012', CAST(N'2022-12-25' AS Date), CAST(2.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(7.30 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (7, N'0000000001', CAST(N'2022-12-25' AS Date), CAST(9.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(9.80 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (9, N'0000000011', CAST(N'2022-12-25' AS Date), CAST(8.50 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(9.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (10, N'0000000004', CAST(N'2022-12-25' AS Date), CAST(7.50 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(7.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (10, N'0000000018', CAST(N'2022-12-25' AS Date), CAST(2.50 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(1.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (11, N'0000000009', CAST(N'2022-12-25' AS Date), CAST(7.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(8.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (14, N'0000000002', CAST(N'2022-12-25' AS Date), CAST(8.50 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(8.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (14, N'0000000003', CAST(N'2022-12-25' AS Date), CAST(7.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(9.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (17, N'0000000004', CAST(N'2022-12-25' AS Date), CAST(6.50 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(9.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (17, N'0000000005', CAST(N'2022-12-25' AS Date), CAST(5.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(6.50 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (18, N'0000000001', CAST(N'2022-12-25' AS Date), CAST(8.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(9.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (20, N'0000000004', CAST(N'2022-12-25' AS Date), CAST(6.50 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(8.30 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
INSERT [dbo].[Scores] ([TeachingID], [StudentID], [Registration_Date], [MidtermScore], [ModifiedDateOfMidtermScore], [EndPointScore], [ModifiedDateOfEndPointScore]) VALUES (20, N'0000000007', CAST(N'2022-12-25' AS Date), CAST(6.00 AS Decimal(4, 2)), CAST(N'2023-03-08' AS Date), CAST(7.00 AS Decimal(3, 2)), CAST(N'2023-03-08' AS Date))
GO
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([TeacherID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Scores]  WITH CHECK ADD  CONSTRAINT [FK1_Score] FOREIGN KEY([TeachingID])
REFERENCES [dbo].[Teaching] ([ID])
GO
ALTER TABLE [dbo].[Scores] CHECK CONSTRAINT [FK1_Score]
GO
ALTER TABLE [dbo].[Scores]  WITH CHECK ADD  CONSTRAINT [FK2_Score] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[Scores] CHECK CONSTRAINT [FK2_Score]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ClassID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teaching]  WITH CHECK ADD FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([SubjectID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teaching]  WITH CHECK ADD FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([TeacherID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [QuanLyHocTap] SET  READ_WRITE 
GO
