USE [master]
GO
/****** Object:  Database [SalesForce]    Script Date: 18.02.2022 09:00:30 ******/
CREATE DATABASE [SalesForce]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalesForce', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SalesForce.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SalesForce_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SalesForce_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SalesForce] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalesForce].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalesForce] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalesForce] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalesForce] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalesForce] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalesForce] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalesForce] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SalesForce] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalesForce] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalesForce] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalesForce] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalesForce] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalesForce] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalesForce] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalesForce] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalesForce] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SalesForce] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalesForce] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalesForce] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalesForce] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalesForce] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalesForce] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalesForce] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalesForce] SET RECOVERY FULL 
GO
ALTER DATABASE [SalesForce] SET  MULTI_USER 
GO
ALTER DATABASE [SalesForce] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalesForce] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalesForce] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalesForce] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SalesForce] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SalesForce', N'ON'
GO
USE [SalesForce]
GO
/****** Object:  Table [dbo].[Tbl_Customers]    Script Date: 18.02.2022 09:00:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Adress] [nvarchar](150) NULL,
 CONSTRAINT [PK_Tbl_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Oppurtunity]    Script Date: 18.02.2022 09:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Oppurtunity](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OppurtunityType] [nvarchar](50) NULL,
	[OppurtunityHeader] [nvarchar](50) NULL,
	[OppurtunityDetail] [nvarchar](50) NULL,
	[OppurtunityCustomerName] [nvarchar](100) NULL,
	[OppurtunityCustomerAdress] [nvarchar](100) NULL,
	[OppurtunityExpireDate] [datetime] NULL,
	[OppurtunityEntery] [nvarchar](100) NULL,
	[OppurtunityDescription] [nvarchar](100) NULL,
	[OppurtunityStartDate] [datetime] NULL,
 CONSTRAINT [PK_Tbl_Oppurtunity] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_OrderAssigment]    Script Date: 18.02.2022 09:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_OrderAssigment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[OrderID] [int] NULL,
 CONSTRAINT [PK_Tbl_OrderAssigment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_OrderDetails]    Script Date: 18.02.2022 09:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_OrderDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[TotalPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Tbl_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Orders]    Script Date: 18.02.2022 09:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NULL CONSTRAINT [DF_Tbl_Orders_OrderDate]  DEFAULT (getdate()),
	[CustomerID] [int] NULL,
	[UserID] [int] NULL,
	[OrderDelivery] [bit] NULL,
	[OrderStatus] [bit] NULL,
 CONSTRAINT [PK_Tbl_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Products]    Script Date: 18.02.2022 09:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[Price] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Tbl_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Users]    Script Date: 18.02.2022 09:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserEmail] [varchar](100) NULL,
	[UserPassword] [varchar](100) NULL,
	[UserType] [varchar](100) NULL,
	[ParentID] [int] NULL,
	[UserImagePath] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_WorkOrders]    Script Date: 18.02.2022 09:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_WorkOrders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[Status] [nchar](10) NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Tbl_WorkOrders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Tbl_Customers] ON 

INSERT [dbo].[Tbl_Customers] ([ID], [CustomerName], [Adress]) VALUES (4, N'Beşiktaş', N'Beşiltaş/istanbul')
SET IDENTITY_INSERT [dbo].[Tbl_Customers] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Oppurtunity] ON 

INSERT [dbo].[Tbl_Oppurtunity] ([ID], [OppurtunityType], [OppurtunityHeader], [OppurtunityDetail], [OppurtunityCustomerName], [OppurtunityCustomerAdress], [OppurtunityExpireDate], [OppurtunityEntery], [OppurtunityDescription], [OppurtunityStartDate]) VALUES (1, N'Upcelllll', N'Başlık', N'Başlık detay', N'Hasan çelik a.ş', N'Hemşin/Rize', CAST(N'2022-03-20 00:00:00.000' AS DateTime), N'ASLI', N'boyacı', NULL)
INSERT [dbo].[Tbl_Oppurtunity] ([ID], [OppurtunityType], [OppurtunityHeader], [OppurtunityDetail], [OppurtunityCustomerName], [OppurtunityCustomerAdress], [OppurtunityExpireDate], [OppurtunityEntery], [OppurtunityDescription], [OppurtunityStartDate]) VALUES (2, N'QQQQQQQ', N'TTTTTTTT', N'RRRRRR', N'EEEEEEE', N'CCCCCCCC', NULL, N'SSSSS', N'SSSSSSS', NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Oppurtunity] OFF
SET IDENTITY_INSERT [dbo].[Tbl_OrderAssigment] ON 

INSERT [dbo].[Tbl_OrderAssigment] ([ID], [UserID], [OrderID]) VALUES (3, 1, 1)
INSERT [dbo].[Tbl_OrderAssigment] ([ID], [UserID], [OrderID]) VALUES (4, 4, NULL)
INSERT [dbo].[Tbl_OrderAssigment] ([ID], [UserID], [OrderID]) VALUES (5, 5, 1)
INSERT [dbo].[Tbl_OrderAssigment] ([ID], [UserID], [OrderID]) VALUES (6, 4, 1)
INSERT [dbo].[Tbl_OrderAssigment] ([ID], [UserID], [OrderID]) VALUES (7, 3, 1)
INSERT [dbo].[Tbl_OrderAssigment] ([ID], [UserID], [OrderID]) VALUES (8, 1, 1)
INSERT [dbo].[Tbl_OrderAssigment] ([ID], [UserID], [OrderID]) VALUES (9, 1, 1)
SET IDENTITY_INSERT [dbo].[Tbl_OrderAssigment] OFF
SET IDENTITY_INSERT [dbo].[Tbl_OrderDetails] ON 

INSERT [dbo].[Tbl_OrderDetails] ([ID], [OrderID], [ProductID], [Quantity], [TotalPrice]) VALUES (2, 1, 1, 10, CAST(252.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tbl_OrderDetails] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Orders] ON 

INSERT [dbo].[Tbl_Orders] ([ID], [OrderDate], [CustomerID], [UserID], [OrderDelivery], [OrderStatus]) VALUES (1, CAST(N'2022-02-16' AS Date), 4, 1, 0, 1)
SET IDENTITY_INSERT [dbo].[Tbl_Orders] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Products] ON 

INSERT [dbo].[Tbl_Products] ([ID], [ProductName], [Price]) VALUES (1, N'Kahve', CAST(25.20 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tbl_Products] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Users] ON 

INSERT [dbo].[Tbl_Users] ([ID], [UserEmail], [UserPassword], [UserType], [ParentID], [UserImagePath]) VALUES (1, N'kurye1@gmail.com', N'OT34', N'Kurye', 2, N'AdminLTE-3.1.0/dist/img/Avatar.png')
INSERT [dbo].[Tbl_Users] ([ID], [UserEmail], [UserPassword], [UserType], [ParentID], [UserImagePath]) VALUES (2, N'kuryeadmin1@gmail.com', N'OT34', N'KuryeAdmin', NULL, N'AdminLTE-3.1.0/dist/img/Avatar2.png
')
INSERT [dbo].[Tbl_Users] ([ID], [UserEmail], [UserPassword], [UserType], [ParentID], [UserImagePath]) VALUES (3, N'kurye2@gmail.com', N'OT34', N'Kurye', 2, N'AdminLTE-3.1.0/dist/img/Avatar3.png
')
INSERT [dbo].[Tbl_Users] ([ID], [UserEmail], [UserPassword], [UserType], [ParentID], [UserImagePath]) VALUES (4, N'kurye3@gmail.com', N'OT34', N'Kurye', 2, N'AdminLTE-3.1.0/dist/img/Avatar4.png
')
INSERT [dbo].[Tbl_Users] ([ID], [UserEmail], [UserPassword], [UserType], [ParentID], [UserImagePath]) VALUES (5, N'kurye4@gmail.com', N'OT34', N'Kurye', 6, N'AdminLTE-3.1.0/dist/img/Avatar5.png')
INSERT [dbo].[Tbl_Users] ([ID], [UserEmail], [UserPassword], [UserType], [ParentID], [UserImagePath]) VALUES (6, N'kuryeadmin2@gmail.com', N'OT34', N'KuryeAdmin', 6, N'AdminLTE-3.1.0/dist/img/Avatar5.png')
SET IDENTITY_INSERT [dbo].[Tbl_Users] OFF
ALTER TABLE [dbo].[Tbl_WorkOrders] ADD  CONSTRAINT [DF_Tbl_WorkOrders_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Tbl_OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_OrderDetails_Tbl_Orders] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Tbl_Orders] ([ID])
GO
ALTER TABLE [dbo].[Tbl_OrderDetails] CHECK CONSTRAINT [FK_Tbl_OrderDetails_Tbl_Orders]
GO
ALTER TABLE [dbo].[Tbl_OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_OrderDetails_Tbl_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Tbl_Products] ([ID])
GO
ALTER TABLE [dbo].[Tbl_OrderDetails] CHECK CONSTRAINT [FK_Tbl_OrderDetails_Tbl_Products]
GO
ALTER TABLE [dbo].[Tbl_Orders]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Orders_Tbl_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Tbl_Customers] ([ID])
GO
ALTER TABLE [dbo].[Tbl_Orders] CHECK CONSTRAINT [FK_Tbl_Orders_Tbl_Customers]
GO
ALTER TABLE [dbo].[Tbl_Orders]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Orders_Tbl_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Tbl_Users] ([ID])
GO
ALTER TABLE [dbo].[Tbl_Orders] CHECK CONSTRAINT [FK_Tbl_Orders_Tbl_Users]
GO
ALTER TABLE [dbo].[Tbl_WorkOrders]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_WorkOrders_Tbl_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Tbl_Orders] ([ID])
GO
ALTER TABLE [dbo].[Tbl_WorkOrders] CHECK CONSTRAINT [FK_Tbl_WorkOrders_Tbl_Orders]
GO
USE [master]
GO
ALTER DATABASE [SalesForce] SET  READ_WRITE 
GO
