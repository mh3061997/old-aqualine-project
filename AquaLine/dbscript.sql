USE [master]
GO
/****** Object:  Database [AquaLine]    Script Date: 23/12/2018 02:04:05 ******/
CREATE DATABASE [AquaLine] 
go

ALTER DATABASE [AquaLine] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AquaLine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AquaLine] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AquaLine] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AquaLine] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AquaLine] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AquaLine] SET ARITHABORT OFF 
GO
ALTER DATABASE [AquaLine] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AquaLine] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AquaLine] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AquaLine] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AquaLine] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AquaLine] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AquaLine] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AquaLine] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AquaLine] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AquaLine] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AquaLine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AquaLine] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AquaLine] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AquaLine] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AquaLine] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AquaLine] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AquaLine] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AquaLine] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AquaLine] SET  MULTI_USER 
GO
ALTER DATABASE [AquaLine] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AquaLine] SET DB_CHAINING OFF 
GO
USE [AquaLine]
GO
/****** Object:  Table [dbo].[Accountant]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accountant](
	[SSN] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Salary] [nvarchar](50) NULL,
	[HireDate] [datetime] NULL,
	[BirthDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Accountant] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assignments]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignments](
	[ID] [int] NOT NULL,
	[Status] [nvarchar](50) NULL,
	[DueDate] [date] NULL,
	[CreationDate] [date] NULL,
	[Eng_SSN] [int] NOT NULL,
	[ClientName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Assignments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[Name] [nvarchar](50) NOT NULL,
	[EmployeeCapacity] [int] NULL,
	[WorkingHoursPerWeek] [int] NULL,
 CONSTRAINT [PK_Branches] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Name] [nvarchar](50) NOT NULL,
	[Location] [nvarchar](50) NULL,
	[RepresentativeName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientsOrders]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientsOrders](
	[ID] [int] NOT NULL,
	[IssueDate] [date] NULL,
	[DueDate] [date] NULL,
	[PaymentMethod] [nvarchar](50) NULL,
	[Eng_SSN_Create] [int] NULL,
	[Manager_SSN_Create] [int] NULL,
	[Accountant_SSN_Create] [int] NULL,
	[Client_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ClientsOrders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[TaxCardNumber] [int] NOT NULL,
	[Registeration Number] [int] NULL,
	[OwnerName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[TaxCardNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Engineer]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Engineer](
	[SSN] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Salary] [nvarchar](50) NULL,
	[HireDate] [date] NULL,
	[BirthDate] [date] NOT NULL,
 CONSTRAINT [PK_Engineer] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Includes_Clientorder_Item]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Includes_Clientorder_Item](
	[OrderID] [int] NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Includes_Clientorder_Item] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[Product_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Includes_Supplierorder_Item]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Includes_Supplierorder_Item](
	[OrderID] [int] NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Includes_Supplierorder_Item] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[Product_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[SSN] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Salary] [nvarchar](50) NULL,
	[HireDate] [date] NULL,
	[BirthDate] [date] NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockItems]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockItems](
	[ProductName] [nvarchar](50) NOT NULL,
	[Weight] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
 CONSTRAINT [PK_StockItems] PRIMARY KEY CLUSTERED 
(
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stores]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stores](
	[WarehouseBranchName] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED 
(
	[WarehouseBranchName] ASC,
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Name] [nvarchar](50) NOT NULL,
	[Location] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuppliersOrders]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuppliersOrders](
	[ID] [int] NOT NULL,
	[DueDate] [datetime] NULL,
	[IssueDate] [datetime] NULL,
	[SupplierName] [nvarchar](50) NOT NULL,
	[Manager_SSN_Create] [int] NOT NULL,
 CONSTRAINT [PK_SuppliersOrders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userlogin]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userlogin](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[priv] [int] NOT NULL,
 CONSTRAINT [PK_userlogin] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 23/12/2018 02:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[Branch_Name] [nvarchar](50) NOT NULL,
	[Capacity] [int] NOT NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[Branch_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Accountant] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (1, N'Ahmed', N'3500', CAST(N'2009-05-03T00:00:00.000' AS DateTime), CAST(N'1979-10-30T00:00:00.000' AS DateTime))
INSERT [dbo].[Accountant] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (9, N'Mona Omar', N'5000', CAST(N'2006-01-02T00:00:00.000' AS DateTime), CAST(N'1989-03-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Accountant] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (12, N'Hussien Hany', N'9600', CAST(N'2000-09-03T00:00:00.000' AS DateTime), CAST(N'1965-02-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Accountant] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (65, N'Ahmed Khaled', N'10065', CAST(N'1997-05-09T00:00:00.000' AS DateTime), CAST(N'1965-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Accountant] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (90, N'Khaled Ahmed', N'5980', CAST(N'2007-11-12T00:00:00.000' AS DateTime), CAST(N'2005-02-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Accountant] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (99, N'Mohamed Monir', N'7850', CAST(N'2009-05-09T00:00:00.000' AS DateTime), CAST(N'1996-04-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Accountant] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (345, N'hany salem', N'3455', CAST(N'2018-12-21T00:00:00.000' AS DateTime), CAST(N'2018-12-21T00:00:00.000' AS DateTime))
INSERT [dbo].[Accountant] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (976, N'Ahmed Mohy', N'3455', CAST(N'2018-12-21T00:00:00.000' AS DateTime), CAST(N'2018-12-21T00:00:00.000' AS DateTime))
INSERT [dbo].[Assignments] ([ID], [Status], [DueDate], [CreationDate], [Eng_SSN], [ClientName]) VALUES (1, N'Active', CAST(N'2018-12-12' AS Date), CAST(N'2018-11-11' AS Date), 55, N'Four Seasons')
INSERT [dbo].[Assignments] ([ID], [Status], [DueDate], [CreationDate], [Eng_SSN], [ClientName]) VALUES (2, N'Active', CAST(N'2019-01-01' AS Date), CAST(N'2017-05-06' AS Date), 90, N'Four Seasons')
INSERT [dbo].[Assignments] ([ID], [Status], [DueDate], [CreationDate], [Eng_SSN], [ClientName]) VALUES (3, N'Done', CAST(N'2014-02-04' AS Date), CAST(N'2005-05-08' AS Date), 2, N'Conrad')
INSERT [dbo].[Assignments] ([ID], [Status], [DueDate], [CreationDate], [Eng_SSN], [ClientName]) VALUES (4, N'Done', CAST(N'2018-05-08' AS Date), CAST(N'2018-04-06' AS Date), 2, N'Novotel')
INSERT [dbo].[Assignments] ([ID], [Status], [DueDate], [CreationDate], [Eng_SSN], [ClientName]) VALUES (5, N'Active', CAST(N'2017-06-04' AS Date), CAST(N'2018-07-06' AS Date), 2, N'Oberoi')
INSERT [dbo].[Assignments] ([ID], [Status], [DueDate], [CreationDate], [Eng_SSN], [ClientName]) VALUES (6, N'Done', CAST(N'2018-05-06' AS Date), CAST(N'2017-05-06' AS Date), 10, N'Ritz-Carlton')
INSERT [dbo].[Assignments] ([ID], [Status], [DueDate], [CreationDate], [Eng_SSN], [ClientName]) VALUES (8, N'Active', CAST(N'2016-04-02' AS Date), CAST(N'2015-07-08' AS Date), 13, N'Movenpick')
INSERT [dbo].[Branches] ([Name], [EmployeeCapacity], [WorkingHoursPerWeek]) VALUES (N'dokki', 25, 90)
INSERT [dbo].[Branches] ([Name], [EmployeeCapacity], [WorkingHoursPerWeek]) VALUES (N'haram', 10, 60)
INSERT [dbo].[Branches] ([Name], [EmployeeCapacity], [WorkingHoursPerWeek]) VALUES (N'mohandeseen', 65, 95)
INSERT [dbo].[Branches] ([Name], [EmployeeCapacity], [WorkingHoursPerWeek]) VALUES (N'nasr city', 100, 180)
INSERT [dbo].[Branches] ([Name], [EmployeeCapacity], [WorkingHoursPerWeek]) VALUES (N'October', 120, 180)
INSERT [dbo].[Branches] ([Name], [EmployeeCapacity], [WorkingHoursPerWeek]) VALUES (N'Sharm', 60, 80)
INSERT [dbo].[Branches] ([Name], [EmployeeCapacity], [WorkingHoursPerWeek]) VALUES (N'shobra', 5, 40)
INSERT [dbo].[Branches] ([Name], [EmployeeCapacity], [WorkingHoursPerWeek]) VALUES (N'tagamoo3', 6, 42)
INSERT [dbo].[Clients] ([Name], [Location], [RepresentativeName], [PhoneNumber], [Email]) VALUES (N'Conrad', N'cairo', N'Ali Amin', N'01004698850', N'conradrep@yahoo.com')
INSERT [dbo].[Clients] ([Name], [Location], [RepresentativeName], [PhoneNumber], [Email]) VALUES (N'Dummy', N'Dummy', N'Dummy', N'Dummy', N'Dummy')
INSERT [dbo].[Clients] ([Name], [Location], [RepresentativeName], [PhoneNumber], [Email]) VALUES (N'Four Seasons', N'manial', N'Haitham', N'9222', N'xsd@gmail.com')
INSERT [dbo].[Clients] ([Name], [Location], [RepresentativeName], [PhoneNumber], [Email]) VALUES (N'Movenpick', N'Heliopolis', NULL, NULL, NULL)
INSERT [dbo].[Clients] ([Name], [Location], [RepresentativeName], [PhoneNumber], [Email]) VALUES (N'Novotel', N'October', NULL, NULL, NULL)
INSERT [dbo].[Clients] ([Name], [Location], [RepresentativeName], [PhoneNumber], [Email]) VALUES (N'Oberoi', N'Sahl Hashish', NULL, NULL, NULL)
INSERT [dbo].[Clients] ([Name], [Location], [RepresentativeName], [PhoneNumber], [Email]) VALUES (N'Ritz-carlton', N'usa', N'Michael Jacksoon', N'010', N'mh3ddd@gmail.com')
INSERT [dbo].[Clients] ([Name], [Location], [RepresentativeName], [PhoneNumber], [Email]) VALUES (N'Steigenberger', N'hurghada', N'ahmed', N'012669', N'lop@hotmail.com')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (0, CAST(N'2018-05-05' AS Date), CAST(N'2019-02-01' AS Date), N'Cash', 2, NULL, NULL, N'Conrad')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (1, CAST(N'2017-05-12' AS Date), CAST(N'2019-12-12' AS Date), N'Cash', NULL, NULL, 1, N'Four Seasons')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (2, CAST(N'2000-05-01' AS Date), CAST(N'2006-01-04' AS Date), N'Cash', NULL, NULL, NULL, N'Four Seasons')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (3, CAST(N'1999-05-08' AS Date), CAST(N'2000-04-06' AS Date), N'Cheque', NULL, NULL, NULL, N'Ritz-Carlton')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (4, CAST(N'2018-01-01' AS Date), CAST(N'2018-02-04' AS Date), N'Credit', 2, NULL, NULL, N'Steigenberger')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (5, CAST(N'2016-04-05' AS Date), CAST(N'2017-01-02' AS Date), N'Credit', NULL, 1, NULL, N'Novotel')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (6, CAST(N'2014-07-08' AS Date), CAST(N'2016-05-05' AS Date), N'Cash', 3, NULL, NULL, N'Novotel')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (7, CAST(N'2014-06-08' AS Date), CAST(N'2017-01-01' AS Date), N'Cash', 30, NULL, NULL, N'Novotel')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (8, CAST(N'2015-07-08' AS Date), CAST(N'2016-05-07' AS Date), N'Cheque', 13, NULL, NULL, N'Oberoi')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (9, CAST(N'2018-08-08' AS Date), CAST(N'2019-01-01' AS Date), N'Cash', NULL, 1, NULL, N'Conrad')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (10, CAST(N'2017-05-05' AS Date), CAST(N'2018-02-02' AS Date), N'Cash', 55, NULL, NULL, N'Conrad')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (11, CAST(N'2018-05-05' AS Date), CAST(N'2019-06-06' AS Date), N'Credit', 2, NULL, NULL, N'Oberoi')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (8899, CAST(N'2018-12-22' AS Date), CAST(N'2018-12-28' AS Date), N'Credit', NULL, NULL, 65, N'Oberoi')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (9885, CAST(N'2018-12-22' AS Date), CAST(N'2019-05-26' AS Date), N'Credit', 13, 9, 99, N'Movenpick')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (11111, CAST(N'2018-12-22' AS Date), CAST(N'2018-12-27' AS Date), N'Cheque', NULL, 9, 9, N'Four Seasons')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (56456, CAST(N'2018-12-22' AS Date), CAST(N'2018-12-29' AS Date), N'Credit', 13, 1, 1, N'Novotel')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (155555, CAST(N'2018-12-22' AS Date), CAST(N'2018-12-28' AS Date), N'Credit', NULL, 9, NULL, N'Conrad')
INSERT [dbo].[ClientsOrders] ([ID], [IssueDate], [DueDate], [PaymentMethod], [Eng_SSN_Create], [Manager_SSN_Create], [Accountant_SSN_Create], [Client_Name]) VALUES (223333, CAST(N'2018-12-22' AS Date), CAST(N'2018-12-28' AS Date), N'Credit', NULL, NULL, NULL, N'Conrad')
INSERT [dbo].[Company] ([TaxCardNumber], [Registeration Number], [OwnerName]) VALUES (426, 222222222, N'ahhhhhmed')
INSERT [dbo].[Engineer] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (2, N'Peter Brown', N'4000', CAST(N'2018-08-08' AS Date), CAST(N'1992-08-05' AS Date))
INSERT [dbo].[Engineer] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (3, N'Mohamed Salah', N'2000', CAST(N'2017-05-02' AS Date), CAST(N'1990-04-07' AS Date))
INSERT [dbo].[Engineer] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (10, N'Omar Atef', N'3200', CAST(N'2012-05-02' AS Date), CAST(N'1991-02-08' AS Date))
INSERT [dbo].[Engineer] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (13, N'David Jack', N'8500', CAST(N'2001-05-02' AS Date), CAST(N'1990-06-09' AS Date))
INSERT [dbo].[Engineer] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (30, N'Haitham Ahmed', N'1200', CAST(N'2012-01-12' AS Date), CAST(N'2006-01-04' AS Date))
INSERT [dbo].[Engineer] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (55, N'Hany Abdo', N'7999', CAST(N'2005-08-09' AS Date), CAST(N'1988-08-19' AS Date))
INSERT [dbo].[Engineer] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (90, N'Khaled Ahmed', N'5980', CAST(N'2007-11-12' AS Date), CAST(N'2005-02-09' AS Date))
INSERT [dbo].[Engineer] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (899, N'Mohanad ali', N'344', CAST(N'2019-01-17' AS Date), CAST(N'2009-06-01' AS Date))
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (1, N'Algaecide', 502)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (1, N'BioGuard', 120)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (1, N'CLA', 33)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (1, N'Parter', 90)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (2, N'Bromine', 1220)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (3, N'CLA', 22)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (3, N'Clorox', 600)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (3, N'glutamine', 90)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (4, N'Ph Increaser', 5001)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (4, N'try', 2)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (5, N'Baquacil', 3)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (6, N'Baquacil', 900)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (7, N'Baquacil', 1000)
INSERT [dbo].[Includes_Clientorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (8, N'Baquacil', 4445)
INSERT [dbo].[Includes_Supplierorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (1, N'Clorox', 54)
INSERT [dbo].[Includes_Supplierorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (1, N'Ph Increaser', 460)
INSERT [dbo].[Includes_Supplierorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (1, N'try', 460)
INSERT [dbo].[Includes_Supplierorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (2, N'CLA', 5)
INSERT [dbo].[Includes_Supplierorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (2, N'Clorox', 6)
INSERT [dbo].[Includes_Supplierorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (3, N'try', 400)
INSERT [dbo].[Includes_Supplierorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (5, N'whey protein', 750000)
INSERT [dbo].[Includes_Supplierorder_Item] ([OrderID], [Product_Name], [Quantity]) VALUES (22, N'try', 2)
INSERT [dbo].[Manager] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (1, N'Ahmed Khaled', N'50000', CAST(N'1999-05-08' AS Date), CAST(N'1960-07-08' AS Date))
INSERT [dbo].[Manager] ([SSN], [Name], [Salary], [HireDate], [BirthDate]) VALUES (9, N'Eman Hossam', N'5020', CAST(N'2018-11-12' AS Date), CAST(N'2015-02-09' AS Date))
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'Algaecide', N'2g', N'1500')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'Baquacil', N'3kg', N'4000')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'BioGuard', N'1kg', N'9000')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'Bromine', N'9kg', NULL)
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'CLA', N'1g', N'250')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'Clorox', N'5kg', N'9500')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'glutamine', NULL, NULL)
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'Parter', N'', N'')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'Ph Increaser', N'9kg', NULL)
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'polymorph', N'3.5kg', N'540')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'rrt', N'34g', N'766')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'rtl', N'54', N'33')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'shiner', N'', N'')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'try', N'no', N'500$')
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'whey protein', NULL, NULL)
INSERT [dbo].[StockItems] ([ProductName], [Weight], [Price]) VALUES (N'youss', N'', N'')
INSERT [dbo].[Stores] ([WarehouseBranchName], [ProductName], [Quantity]) VALUES (N'haram', N'Baquacil', 500)
INSERT [dbo].[Stores] ([WarehouseBranchName], [ProductName], [Quantity]) VALUES (N'haram', N'CLA', 1)
INSERT [dbo].[Stores] ([WarehouseBranchName], [ProductName], [Quantity]) VALUES (N'haram', N'Clorox', 80)
INSERT [dbo].[Stores] ([WarehouseBranchName], [ProductName], [Quantity]) VALUES (N'mohandeseen', N'Bromine', 700)
INSERT [dbo].[Stores] ([WarehouseBranchName], [ProductName], [Quantity]) VALUES (N'shobra', N'Algaecide', 9000)
INSERT [dbo].[Stores] ([WarehouseBranchName], [ProductName], [Quantity]) VALUES (N'tagamoo3', N'try', 700)
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'ahmedcomp', N'october', N'0100000', N'mh3')
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'chinaltd', N'china', N'010', N'mh@hotmail.com')
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'egyptchemicals', N'cairo', N'01555', N'egypt@gmail.com')
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'egyptianchemo', N'giza', N'012', N'mug@YAHOO.COM')
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'mowared', N'egypt', N'266164', N'egyptoo@gmail.com')
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'mychemicals', N'canada', N'9998885', N'mych@chemicals.com')
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'mysup', N'japan', N'05555', NULL)
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'supplierx', N'here', N'4555554', N'sdg@dhg.com')
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'toyuse', N'mexico', N'26165', N'fhdgh')
INSERT [dbo].[Suppliers] ([Name], [Location], [PhoneNumber], [Email]) VALUES (N'xyz', N'usa', N'018888', N'usa@fha.com')
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (1, CAST(N'2017-05-12T00:00:00.000' AS DateTime), CAST(N'2016-12-12T00:00:00.000' AS DateTime), N'chinaltd', 1)
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (2, CAST(N'2017-04-04T00:00:00.000' AS DateTime), CAST(N'2016-05-05T00:00:00.000' AS DateTime), N'chinaltd', 1)
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (3, CAST(N'2014-05-05T00:00:00.000' AS DateTime), CAST(N'2013-05-05T00:00:00.000' AS DateTime), N'mysup', 1)
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (4, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2018-05-05T00:00:00.000' AS DateTime), N'mowared', 1)
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (5, CAST(N'2018-05-05T00:00:00.000' AS DateTime), CAST(N'2018-05-01T00:00:00.000' AS DateTime), N'mysup', 1)
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (6, CAST(N'2018-07-05T00:00:00.000' AS DateTime), CAST(N'2018-05-05T00:00:00.000' AS DateTime), N'mysup', 1)
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (7, CAST(N'2019-05-05T00:00:00.000' AS DateTime), CAST(N'2018-05-05T00:00:00.000' AS DateTime), N'mysup', 1)
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (8, CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2018-05-05T00:00:00.000' AS DateTime), N'mowared', 1)
INSERT [dbo].[SuppliersOrders] ([ID], [DueDate], [IssueDate], [SupplierName], [Manager_SSN_Create]) VALUES (22, CAST(N'2015-05-01T00:00:00.000' AS DateTime), CAST(N'2014-05-02T00:00:00.000' AS DateTime), N'egyptchemicals', 9)
INSERT [dbo].[userlogin] ([username], [password], [priv]) VALUES (N'acc1', N'1234', 2)
INSERT [dbo].[userlogin] ([username], [password], [priv]) VALUES (N'admin', N'admin', 3)
INSERT [dbo].[userlogin] ([username], [password], [priv]) VALUES (N'eng1', N'eng', 1)
INSERT [dbo].[Warehouse] ([Branch_Name], [Capacity]) VALUES (N'dokki', 5000)
INSERT [dbo].[Warehouse] ([Branch_Name], [Capacity]) VALUES (N'haram', 9000)
INSERT [dbo].[Warehouse] ([Branch_Name], [Capacity]) VALUES (N'mohandeseen', 4000)
INSERT [dbo].[Warehouse] ([Branch_Name], [Capacity]) VALUES (N'nasr city', 5000)
INSERT [dbo].[Warehouse] ([Branch_Name], [Capacity]) VALUES (N'October', 70000)
INSERT [dbo].[Warehouse] ([Branch_Name], [Capacity]) VALUES (N'shobra', 50)
INSERT [dbo].[Warehouse] ([Branch_Name], [Capacity]) VALUES (N'tagamoo3', 4500)
ALTER TABLE [dbo].[Assignments]  WITH CHECK ADD  CONSTRAINT [FK_Assignments_Clients] FOREIGN KEY([ClientName])
REFERENCES [dbo].[Clients] ([Name])
GO
ALTER TABLE [dbo].[Assignments] CHECK CONSTRAINT [FK_Assignments_Clients]
GO
ALTER TABLE [dbo].[Assignments]  WITH CHECK ADD  CONSTRAINT [FK_Assignments_Engineer] FOREIGN KEY([Eng_SSN])
REFERENCES [dbo].[Engineer] ([SSN])
GO
ALTER TABLE [dbo].[Assignments] CHECK CONSTRAINT [FK_Assignments_Engineer]
GO
ALTER TABLE [dbo].[ClientsOrders]  WITH CHECK ADD  CONSTRAINT [FK_ClientsOrders_Accountant] FOREIGN KEY([Accountant_SSN_Create])
REFERENCES [dbo].[Accountant] ([SSN])
GO
ALTER TABLE [dbo].[ClientsOrders] CHECK CONSTRAINT [FK_ClientsOrders_Accountant]
GO
ALTER TABLE [dbo].[ClientsOrders]  WITH CHECK ADD  CONSTRAINT [FK_ClientsOrders_Clients] FOREIGN KEY([Client_Name])
REFERENCES [dbo].[Clients] ([Name])
GO
ALTER TABLE [dbo].[ClientsOrders] CHECK CONSTRAINT [FK_ClientsOrders_Clients]
GO
ALTER TABLE [dbo].[ClientsOrders]  WITH CHECK ADD  CONSTRAINT [FK_ClientsOrders_Engineer] FOREIGN KEY([Eng_SSN_Create])
REFERENCES [dbo].[Engineer] ([SSN])
GO
ALTER TABLE [dbo].[ClientsOrders] CHECK CONSTRAINT [FK_ClientsOrders_Engineer]
GO
ALTER TABLE [dbo].[ClientsOrders]  WITH CHECK ADD  CONSTRAINT [FK_ClientsOrders_Manager] FOREIGN KEY([Manager_SSN_Create])
REFERENCES [dbo].[Manager] ([SSN])
GO
ALTER TABLE [dbo].[ClientsOrders] CHECK CONSTRAINT [FK_ClientsOrders_Manager]
GO
ALTER TABLE [dbo].[Includes_Clientorder_Item]  WITH CHECK ADD  CONSTRAINT [FK_Includes_Clientorder_Item_ClientsOrders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[ClientsOrders] ([ID])
GO
ALTER TABLE [dbo].[Includes_Clientorder_Item] CHECK CONSTRAINT [FK_Includes_Clientorder_Item_ClientsOrders]
GO
ALTER TABLE [dbo].[Includes_Clientorder_Item]  WITH CHECK ADD  CONSTRAINT [FK_Includes_Clientorder_Item_StockItems] FOREIGN KEY([Product_Name])
REFERENCES [dbo].[StockItems] ([ProductName])
GO
ALTER TABLE [dbo].[Includes_Clientorder_Item] CHECK CONSTRAINT [FK_Includes_Clientorder_Item_StockItems]
GO
ALTER TABLE [dbo].[Includes_Supplierorder_Item]  WITH CHECK ADD  CONSTRAINT [FK_Includes_Supplierorder_Item_StockItems] FOREIGN KEY([Product_Name])
REFERENCES [dbo].[StockItems] ([ProductName])
GO
ALTER TABLE [dbo].[Includes_Supplierorder_Item] CHECK CONSTRAINT [FK_Includes_Supplierorder_Item_StockItems]
GO
ALTER TABLE [dbo].[Includes_Supplierorder_Item]  WITH CHECK ADD  CONSTRAINT [FK_Includes_Supplierorder_Item_SuppliersOrders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[SuppliersOrders] ([ID])
GO
ALTER TABLE [dbo].[Includes_Supplierorder_Item] CHECK CONSTRAINT [FK_Includes_Supplierorder_Item_SuppliersOrders]
GO
ALTER TABLE [dbo].[Stores]  WITH CHECK ADD  CONSTRAINT [FK_Stores_StockItems] FOREIGN KEY([ProductName])
REFERENCES [dbo].[StockItems] ([ProductName])
GO
ALTER TABLE [dbo].[Stores] CHECK CONSTRAINT [FK_Stores_StockItems]
GO
ALTER TABLE [dbo].[Stores]  WITH CHECK ADD  CONSTRAINT [FK_Stores_Warehouse] FOREIGN KEY([WarehouseBranchName])
REFERENCES [dbo].[Warehouse] ([Branch_Name])
GO
ALTER TABLE [dbo].[Stores] CHECK CONSTRAINT [FK_Stores_Warehouse]
GO
ALTER TABLE [dbo].[SuppliersOrders]  WITH CHECK ADD  CONSTRAINT [FK_SuppliersOrders_Manager] FOREIGN KEY([Manager_SSN_Create])
REFERENCES [dbo].[Manager] ([SSN])
GO
ALTER TABLE [dbo].[SuppliersOrders] CHECK CONSTRAINT [FK_SuppliersOrders_Manager]
GO
ALTER TABLE [dbo].[SuppliersOrders]  WITH CHECK ADD  CONSTRAINT [FK_SuppliersOrders_Suppliers] FOREIGN KEY([SupplierName])
REFERENCES [dbo].[Suppliers] ([Name])
GO
ALTER TABLE [dbo].[SuppliersOrders] CHECK CONSTRAINT [FK_SuppliersOrders_Suppliers]
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Branches] FOREIGN KEY([Branch_Name])
REFERENCES [dbo].[Branches] ([Name])
GO
ALTER TABLE [dbo].[Warehouse] CHECK CONSTRAINT [FK_Warehouse_Branches]
GO
ALTER TABLE [dbo].[Assignments]  WITH CHECK ADD  CONSTRAINT [CHK_Status] CHECK  (([Status]='active' OR [status]='Done'))
GO
ALTER TABLE [dbo].[Assignments] CHECK CONSTRAINT [CHK_Status]
GO
ALTER TABLE [dbo].[ClientsOrders]  WITH CHECK ADD  CONSTRAINT [CHK_date] CHECK  (([IssueDate]<[DueDate]))
GO
ALTER TABLE [dbo].[ClientsOrders] CHECK CONSTRAINT [CHK_date]
GO
ALTER TABLE [dbo].[ClientsOrders]  WITH CHECK ADD  CONSTRAINT [CHK_PaymentMethod] CHECK  (([PaymentMethod]='Cash' OR [PaymentMethod]='Credit' OR [PaymentMethod]='Cheque'))
GO
ALTER TABLE [dbo].[ClientsOrders] CHECK CONSTRAINT [CHK_PaymentMethod]
GO
ALTER TABLE [dbo].[SuppliersOrders]  WITH CHECK ADD  CONSTRAINT [CHK_date_supplier] CHECK  (([IssueDate]<[DueDate]))
GO
ALTER TABLE [dbo].[SuppliersOrders] CHECK CONSTRAINT [CHK_date_supplier]
GO
/****** Object:  StoredProcedure [dbo].[deleteaccountant]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteaccountant] @ManName nvarchar(50)
as
begin
delete from Accountant
where Name=@ManName
end
GO
/****** Object:  StoredProcedure [dbo].[deleteassignment]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteassignment] @asid int
as
begin
delete from Assignments
where ID=@asid
end
GO
/****** Object:  StoredProcedure [dbo].[deletebranch]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deletebranch] @branch nvarchar(50)
as
begin
delete from Branches
where Name=@branch
end
GO
/****** Object:  StoredProcedure [dbo].[deleteclient]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteclient] @clName nvarchar(50)
as
begin
delete from Clients
where Name=@clName
end
GO
/****** Object:  StoredProcedure [dbo].[deleteclientorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteclientorder] @ordid int
as
begin
delete from ClientsOrders
where ID=@ordid
end
GO
/****** Object:  StoredProcedure [dbo].[deleteengineer]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteengineer] @ManName nvarchar(50)
as
begin
delete from Engineer
where Name=@ManName
end
GO
/****** Object:  StoredProcedure [dbo].[deleteitemfromclientorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[deleteitemfromclientorder] @ordid int, @ordprodname nvarchar(50)
as
begin
delete from Includes_Clientorder_Item
where OrderID=@ordid AND Product_Name = @ordprodname
end
GO
/****** Object:  StoredProcedure [dbo].[deleteitemfromsupplierorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[deleteitemfromsupplierorder] @ordid int, @ordprodname nvarchar(50)
as
begin
delete from Includes_Supplierorder_Item
where OrderID=@ordid AND Product_Name = @ordprodname
end
GO
/****** Object:  StoredProcedure [dbo].[deletemanager]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deletemanager] @ManName nvarchar(50)
as
begin
delete from Manager
where Name=@ManName
end
GO
/****** Object:  StoredProcedure [dbo].[deletestockitems]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deletestockitems] @ProductName nvarchar(50)
as
begin
delete from StockItems
where ProductName=@ProductName
end
GO
/****** Object:  StoredProcedure [dbo].[deletesupplier]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deletesupplier] @ProductName nvarchar(50)
as
begin
delete from Suppliers
where Name=@ProductName
end
GO
/****** Object:  StoredProcedure [dbo].[deletesupplierorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deletesupplierorder] @ordid int
as
begin
delete from SuppliersOrders
where ID=@ordid
end
GO
/****** Object:  StoredProcedure [dbo].[deletewarehouse]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deletewarehouse] @branch nvarchar(50)
as
begin
delete from Warehouse
where Branch_Name=@branch
end
GO
/****** Object:  StoredProcedure [dbo].[getaccountants]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getaccountants]
as
begin
select * 
from Accountant
end
GO
/****** Object:  StoredProcedure [dbo].[getassignments]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getassignments]
as
begin
select * 
from Assignments
end
GO
/****** Object:  StoredProcedure [dbo].[getbranches]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getbranches]
as
begin
select * 
from Branches
end
GO
/****** Object:  StoredProcedure [dbo].[getbranchnamess]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getbranchnamess]
as
begin
select Name
from Branches
end
GO
/****** Object:  StoredProcedure [dbo].[getclientorderitemsall]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getclientorderitemsall]
as
begin
select * 
from Includes_Clientorder_Item
end
GO
/****** Object:  StoredProcedure [dbo].[getclientorders]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getclientorders]
as
begin
select * 
from ClientsOrders
end
GO
/****** Object:  StoredProcedure [dbo].[getclients]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getclients]
as
begin
select * 
from Clients
end
GO
/****** Object:  StoredProcedure [dbo].[getclientwithmostassignments]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getclientwithmostassignments]
as
begin
select ClientName, Count(*)
from Assignments
group by ClientName
order by Count(*) DESC
end
GO
/****** Object:  StoredProcedure [dbo].[getclientwithmostorders]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getclientwithmostorders]
as
begin
select Client_Name, Count(*) 
from ClientsOrders
group by Client_Name
order by Count(*) DESC
end
GO
/****** Object:  StoredProcedure [dbo].[getengineers]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getengineers]
as
begin
select * 
from Engineer
end
GO
/****** Object:  StoredProcedure [dbo].[getengwmosttasks]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getengwmosttasks]
as 
begin
Select Distinct Engineer.Name,Eng_SSN,Count(Eng_SSN) 
from Engineer
right join Assignments on Eng_SSN=SSN
group by Name,Eng_SSN
order by Count(Eng_SSN) DESC
end
GO
/****** Object:  StoredProcedure [dbo].[getitemsinclientorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getitemsinclientorder] @ordid int
as
begin
select * 
from Includes_Clientorder_Item
WHERE OrderID=@ordid
end
GO
/****** Object:  StoredProcedure [dbo].[getitemsinsupplierorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[getitemsinsupplierorder] @ordid int
as
begin
select * 
from Includes_Supplierorder_Item
WHERE OrderID=@ordid
end
GO
/****** Object:  StoredProcedure [dbo].[getloginpriv]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getloginpriv] @username nvarchar(50),@password nvarchar(50)
as
begin
select priv 
from userlogin
where username=@username AND password=@password
end 
GO
/****** Object:  StoredProcedure [dbo].[getmanagers]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getmanagers]
as
begin
select * 
from Manager
end
GO
/****** Object:  StoredProcedure [dbo].[getmostordereditem]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getmostordereditem]
as
begin
select Product_Name ,Sum(Quantity)
from Includes_Clientorder_Item
group by Product_Name
order by Sum(Quantity) DESC
end
GO
/****** Object:  StoredProcedure [dbo].[getmostsupplierorderfrom]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getmostsupplierorderfrom]
as
begin
select SupplierName, Count(*) 
from SuppliersOrders
group by SupplierName
order by Count(*) DESC
end
GO
/****** Object:  StoredProcedure [dbo].[getorderincludingitem]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getorderincludingitem] @itemname nvarchar(50)
as
begin
select * 
from Includes_Clientorder_Item
WHERE Product_Name=@itemname
end
GO
/****** Object:  StoredProcedure [dbo].[getstockitems]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[getstockitems]
AS
Begin
select * from dbo.StockItems
end
GO
/****** Object:  StoredProcedure [dbo].[getsupplierorderincludingitem]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[getsupplierorderincludingitem] @itemname nvarchar(50)
as
begin
select * 
from Includes_Supplierorder_Item
WHERE Product_Name=@itemname
end
GO
/****** Object:  StoredProcedure [dbo].[getsupplierorderitemsall]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[getsupplierorderitemsall]
as
begin
select * 
from Includes_Supplierorder_Item
end
GO
/****** Object:  StoredProcedure [dbo].[getsupplierorders]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getsupplierorders]
as
begin
select * 
from SuppliersOrders
end
GO
/****** Object:  StoredProcedure [dbo].[getsuppliers]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getsuppliers]
as
begin
select * 
from Suppliers
end
GO
/****** Object:  StoredProcedure [dbo].[getwarehouse]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getwarehouse]
as
begin
select * 
from Warehouse
end
GO
/****** Object:  StoredProcedure [dbo].[insertaccountant]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertaccountant] @manssn int ,@manname nvarchar(50),@mansalary nvarchar(50),@manhiredate date, @manbirthdate date
as
begin
insert into Accountant(SSN,Name,Salary,HireDate,BirthDate)
values (@manssn,@manname,@mansalary,@manhiredate,@manbirthdate)
end
GO
/****** Object:  StoredProcedure [dbo].[insertassignment]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertassignment] @asid int, @asstatus nvarchar(50), @asduedate date, @ascreationdate date, @asengssn int ,@asclientname nvarchar(50)
as
begin
insert into Assignments(ID,Status,DueDate,CreationDate,Eng_SSN,ClientName)
values (@asid,@asstatus,@asduedate,@ascreationdate,@asengssn,@asclientname)
end
GO
/****** Object:  StoredProcedure [dbo].[insertbranch]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertbranch] @branchname nvarchar(50) ,@capacity int, @hours int
as
begin
insert into Branches(Name,EmployeeCapacity,WorkingHoursPerWeek)
values (@branchname,@capacity,@hours)
end
GO
/****** Object:  StoredProcedure [dbo].[insertclient]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertclient] @clName nvarchar(50),@cllocation nvarchar(50),@clrepname nvarchar(50), @clphonenumber nvarchar(50), @clemail nvarchar(50)
as
begin
insert into Clients(Name,Location,RepresentativeName,PhoneNumber,Email)
values (@clName,@cllocation,@clrepname,@clphonenumber,@clemail)
end
GO
/****** Object:  StoredProcedure [dbo].[insertclientorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertclientorder] @ordid int, @ordissuedate date, @ordduedate date, @ordspaymethod nvarchar(50),@ordengssn int, @ordmanssncreate int,@ordacccreate int, @ordclientname nvarchar(50) 
as
begin
insert into ClientsOrders(ID,IssueDate,DueDate,PaymentMethod,Eng_SSN_Create,Manager_SSN_Create,Accountant_SSN_Create,Client_Name)
values (@ordid,@ordissuedate,@ordduedate,@ordspaymethod,@ordengssn,@ordmanssncreate,@ordacccreate,@ordclientname)
end
GO
/****** Object:  StoredProcedure [dbo].[insertengineer]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertengineer] @manssn int ,@manname nvarchar(50),@mansalary nvarchar(50),@manhiredate date, @manbirthdate date
as
begin
insert into Engineer(SSN,Name,Salary,HireDate,BirthDate)
values (@manssn,@manname,@mansalary,@manhiredate,@manbirthdate)
end
GO
/****** Object:  StoredProcedure [dbo].[insertitemintoorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertitemintoorder] @ordid int ,@ordprodname nvarchar(50), @qty int
as
begin
insert into Includes_Clientorder_Item(OrderID,Product_Name,Quantity)
values (@ordid,@ordprodname,@qty)
end
GO
/****** Object:  StoredProcedure [dbo].[insertitemintosupplierorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[insertitemintosupplierorder] @ordid int ,@ordprodname nvarchar(50), @qty int
as
begin
insert into Includes_Supplierorder_Item(OrderID,Product_Name,Quantity)
values (@ordid,@ordprodname,@qty)
end
GO
/****** Object:  StoredProcedure [dbo].[insertmanager]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertmanager] @manssn int ,@manname nvarchar(50),@mansalary nvarchar(50),@manhiredate date, @manbirthdate date
as
begin
insert into Manager(SSN,Name,Salary,HireDate,BirthDate)
values (@manssn,@manname,@mansalary,@manhiredate,@manbirthdate)
end
GO
/****** Object:  StoredProcedure [dbo].[insertstockitem]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertstockitem] @ProductName nvarchar(50) ,@weight nvarchar(50),@price nvarchar(50)
as
begin
insert into StockItems(ProductName,Weight,Price)
values (@ProductName,@weight,@price)
end
GO
/****** Object:  StoredProcedure [dbo].[insertsupplier]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertsupplier] @supname nvarchar(50) ,@suplocation nvarchar(50),@supphonenumber nvarchar(50),@supemail nvarchar(50)
as
begin
insert into Suppliers(Name,Location,PhoneNumber,Email)
values (@supname,@suplocation,@supphonenumber,@supemail)
end
GO
/****** Object:  StoredProcedure [dbo].[insertsupplierorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertsupplierorder] @ordid int, @ordduedate date, @ordissuedate date, @ordsuppliername nvarchar(50), @ordmanssncreate int 
as
begin
insert into SuppliersOrders(ID,DueDate,IssueDate,SupplierName,Manager_SSN_Create)
values (@ordid,@ordduedate,@ordissuedate,@ordsuppliername,@ordmanssncreate)
end
GO
/****** Object:  StoredProcedure [dbo].[insertwarehouse]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertwarehouse] @branchname nvarchar(50) ,@capacity int
as
begin
insert into Warehouse(Branch_Name,Capacity)
values (@branchname,@capacity)
end
GO
/****** Object:  StoredProcedure [dbo].[storesdeleteitem]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[storesdeleteitem] @warname nvarchar(50),@itemname nvarchar(50)
as
begin
delete from Stores
where WarehouseBranchName=@warname AND ProductName = @itemname
end
GO
/****** Object:  StoredProcedure [dbo].[storesgetitemsinwar]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[storesgetitemsinwar] @warname nvarchar(50)
as 
begin
select *
from Stores
where WarehouseBranchName=@warname
end
GO
/****** Object:  StoredProcedure [dbo].[storesinsertiteminwar]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[storesinsertiteminwar] @warname nvarchar(50),@itemname nvarchar(50),@qty int
as
begin
insert into Stores(WarehouseBranchName,ProductName,Quantity)
values(@warname,@itemname,@qty)
end
GO
/****** Object:  StoredProcedure [dbo].[storesupdateitemqty]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[storesupdateitemqty] @warname nvarchar(50),@itemname nvarchar(50),@qty int
as
begin
update Stores
set Quantity=@qty 
where WarehouseBranchName=@warname AND ProductName=@itemname
end
GO
/****** Object:  StoredProcedure [dbo].[updateaccountant]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateaccountant] @manssn int ,@manname nvarchar(50),@mansalary nvarchar(50),@manhiredate date, @manbirthdate date
as 
begin 
update Accountant
set  SSN=@manssn , Name=@manname , Salary=@mansalary , HireDate=@manhiredate , BirthDate=@manbirthdate
where Name=@manname
end
GO
/****** Object:  StoredProcedure [dbo].[updateassignment]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateassignment] @asid int, @asstatus nvarchar(50), @asduedate date, @ascreationdate date, @asengssn int ,@asclientname nvarchar(50)
as 
begin 
update Assignments
set  ID=@asid , Status=@asstatus, DueDate=@asduedate,CreationDate=@ascreationdate, Eng_SSN=@asengssn,ClientName=@asclientname
where ID=@asid
end
GO
/****** Object:  StoredProcedure [dbo].[updatebranch]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updatebranch] @oldbranchname nvarchar(50),@newbranchname nvarchar(50),@capacity int, @hours int
as 
begin 
update Branches
set  Name=@newbranchname ,EmployeeCapacity=@capacity , WorkingHoursPerWeek=@hours
where Name=@oldbranchname
end
GO
/****** Object:  StoredProcedure [dbo].[updateclient]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateclient] @clName nvarchar(50),@cllocation nvarchar(50),@clrepname nvarchar(50), @clphonenumber nvarchar(50), @clemail nvarchar(50)
as 
begin 
update Clients
set  Name=@clName , Location=@cllocation , RepresentativeName=@clrepname , PhoneNumber=@clphonenumber , Email=@clemail
where Name=@clName
end
GO
/****** Object:  StoredProcedure [dbo].[updateclientorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateclientorder] @ordid int, @ordissuedate date, @ordduedate date, @ordspaymethod nvarchar(50),@ordengssn int, @ordmanssncreate int,@ordacccreate int, @ordclientname nvarchar(50) 
as 
begin 
update ClientsOrders
set  ID=@ordid, DueDate=@ordduedate, IssueDate=@ordissuedate, PaymentMethod=@ordspaymethod, Eng_SSN_Create=@ordengssn, Manager_SSN_Create=@ordmanssncreate, Accountant_SSN_Create=@ordacccreate, Client_Name=@ordclientname
where ID=@ordid
end
GO
/****** Object:  StoredProcedure [dbo].[updateengineer]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateengineer] @manssn int ,@manname nvarchar(50),@mansalary nvarchar(50),@manhiredate date, @manbirthdate date
as 
begin 
update Engineer
set  SSN=@manssn , Name=@manname , Salary=@mansalary , HireDate=@manhiredate , BirthDate=@manbirthdate
where Name=@manname
end
GO
/****** Object:  StoredProcedure [dbo].[updateitemiqty]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateitemiqty] @ordid int,@itemname nvarchar(50) ,@qty int
as 
begin 
update Includes_Clientorder_Item
set  Quantity=@qty
where OrderID=@ordid AND Product_Name=@itemname
end
GO
/****** Object:  StoredProcedure [dbo].[updateitemiqtysupplier]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[updateitemiqtysupplier] @ordid int,@itemname nvarchar(50) ,@qty int
as 
begin 
update Includes_Supplierorder_Item
set  Quantity=@qty
where OrderID=@ordid AND Product_Name=@itemname
end
GO
/****** Object:  StoredProcedure [dbo].[updatelegalinfo]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[updatelegalinfo] @taxnum int, @regnum int, @name nvarchar(50)
as
begin
update Company
set TaxCardNumber=@taxnum,[Registeration Number]=@regnum, OwnerName=@name
end
GO
/****** Object:  StoredProcedure [dbo].[updatemanager]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updatemanager] @manssn int ,@manname nvarchar(50),@mansalary nvarchar(50),@manhiredate date, @manbirthdate date
as 
begin 
update Manager
set  SSN=@manssn , Name=@manname , Salary=@mansalary , HireDate=@manhiredate , BirthDate=@manbirthdate
where Name=@manname
end
GO
/****** Object:  StoredProcedure [dbo].[updatestockitem]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updatestockitem] @ProductName nvarchar(50) ,@weight nvarchar(50),@price nvarchar(50)
as 
begin 
update StockItems
set  ProductName=@ProductName , Weight=@weight, Price=@price
where ProductName=@ProductName
end
GO
/****** Object:  StoredProcedure [dbo].[updatesupplier]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updatesupplier] @supname nvarchar(50) ,@suplocation nvarchar(50),@supphonenumber nvarchar(50),@supemail nvarchar(50)
as 
begin 
update Suppliers
set  Name=@supname , Location=@suplocation , PhoneNumber=@supphonenumber, Email=@supemail
where Name=@supname
end
GO
/****** Object:  StoredProcedure [dbo].[updatesupplierorder]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updatesupplierorder] @ordid int, @ordduedate date, @ordissuedate date, @ordsuppliername nvarchar(50), @ordmanssncreate int 
as 
begin 
update SuppliersOrders
set  ID=@ordid, DueDate=@ordduedate, IssueDate=@ordissuedate, SupplierName=@ordsuppliername,Manager_SSN_Create=@ordmanssncreate
where ID=@ordid
end
GO
/****** Object:  StoredProcedure [dbo].[updatewarehousecapacity]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatewarehousecapacity] @branchname nvarchar(50) ,@capacity int
as 
begin 
update Warehouse
set  Capacity=@capacity
where Branch_Name=@branchname
end
GO
/****** Object:  StoredProcedure [dbo].[viewlegalinfo]    Script Date: 23/12/2018 02:04:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[viewlegalinfo]
as
begin
select * from Company
end
GO
USE [master]
GO
ALTER DATABASE [AquaLine] SET  READ_WRITE 
GO
