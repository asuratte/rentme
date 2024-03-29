USE [master]
GO
/****** Object:  Database [cs6232-g1]    Script Date: 4/6/2022 9:53:42 AM ******/
CREATE DATABASE [cs6232-g1]
 CONTAINMENT = NONE
 ON  PRIMARY
( NAME = N'cs6232-g1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON
( NAME = N'cs6232-g1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-g1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULLS OFF
GO
ALTER DATABASE [cs6232-g1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [cs6232-g1] SET ARITHABORT OFF
GO
ALTER DATABASE [cs6232-g1] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [cs6232-g1] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [cs6232-g1] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [cs6232-g1] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [cs6232-g1] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [cs6232-g1] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [cs6232-g1] SET  DISABLE_BROKER
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [cs6232-g1] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [cs6232-g1] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [cs6232-g1] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [cs6232-g1] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [cs6232-g1] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [cs6232-g1] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [cs6232-g1] SET RECOVERY FULL
GO
ALTER DATABASE [cs6232-g1] SET  MULTI_USER
GO
ALTER DATABASE [cs6232-g1] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [cs6232-g1] SET DB_CHAINING OFF
GO
ALTER DATABASE [cs6232-g1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO
ALTER DATABASE [cs6232-g1] SET TARGET_RECOVERY_TIME = 60 SECONDS
GO
ALTER DATABASE [cs6232-g1] SET DELAYED_DURABILITY = DISABLED
GO
ALTER DATABASE [cs6232-g1] SET ACCELERATED_DATABASE_RECOVERY = OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g1', N'ON'
GO
ALTER DATABASE [cs6232-g1] SET QUERY_STORE = OFF
GO
USE [cs6232-g1]
GO
/****** Object:  Table [dbo].[admin_employee]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin_employee](
	[employeeID] [int] NOT NULL,
 CONSTRAINT [PK_admin_employee] PRIMARY KEY CLUSTERED
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[employeeID] [int] IDENTITY(10,1) NOT NULL,
	[sex] [char](1) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[firstName] [varchar](45) NOT NULL,
	[lastName] [varchar](45) NOT NULL,
	[phone] [char](10) NOT NULL,
	[address1] [varchar](45) NOT NULL,
	[address2] [varchar](45) NULL,
	[city] [varchar](45) NOT NULL,
	[state] [char](2) NOT NULL,
	[zipCode] [char](5) NOT NULL,
	[username] [varchar](45) NOT NULL,
	[password] [varchar](60) NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[furniture]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[furniture](
	[furnitureID] [varchar](10) NOT NULL,
	[name] [varchar](45) NOT NULL,
	[style] [varchar](45) NOT NULL,
	[category] [varchar](45) NOT NULL,
	[description] [varchar](80) NOT NULL,
	[rentalRate] [decimal](9, 2) NOT NULL,
	[totalQuantity] [int] NOT NULL,
 CONSTRAINT [PK_furniture] PRIMARY KEY CLUSTERED
(
	[furnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[furniture_category]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[furniture_category](
	[categoryName] [varchar](45) NOT NULL,
 CONSTRAINT [PK_furniture_category] PRIMARY KEY CLUSTERED
(
	[categoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[furniture_style]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[furniture_style](
	[styleName] [varchar](45) NOT NULL,
 CONSTRAINT [PK_furniture_style] PRIMARY KEY CLUSTERED
(
	[styleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[member]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member](
	[memberID] [int] IDENTITY(1000,1) NOT NULL,
	[sex] [char](1) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[firstName] [varchar](45) NOT NULL,
	[lastName] [varchar](45) NOT NULL,
	[phone] [char](10) NOT NULL,
	[address1] [varchar](45) NOT NULL,
	[address2] [varchar](45) NULL,
	[city] [varchar](45) NOT NULL,
	[state] [char](2) NOT NULL,
	[zipCode] [char](5) NOT NULL,
 CONSTRAINT [PK_member] PRIMARY KEY CLUSTERED
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[regular_employee]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[regular_employee](
	[employeeID] [int] NOT NULL,
 CONSTRAINT [PK_regular_employee] PRIMARY KEY CLUSTERED
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rental_item]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rental_item](
	[transactionID] [int] NOT NULL,
	[furnitureID] [varchar](10) NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_rental_item] PRIMARY KEY CLUSTERED
(
	[transactionID] ASC,
	[furnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rental_transaction]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rental_transaction](
	[transactionID] [int] IDENTITY(1,1) NOT NULL,
	[memberID] [int] NOT NULL,
	[employeeID] [int] NOT NULL,
	[rentalDate] [datetime] NOT NULL,
	[dueDate] [datetime] NOT NULL,
 CONSTRAINT [PK_rental_transaction] PRIMARY KEY CLUSTERED
(
	[transactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[return_item]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[return_item](
	[transactionID] [int] NOT NULL,
	[rentalTransactionID] [int] NOT NULL,
	[furnitureID] [varchar](10) NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_return_item] PRIMARY KEY CLUSTERED
(
	[transactionID] ASC,
	[rentalTransactionID] ASC,
	[furnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[return_transaction]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[return_transaction](
	[transactionID] [int] IDENTITY(1,1) NOT NULL,
	[memberID] [int] NOT NULL,
	[employeeID] [int] NOT NULL,
	[returnDate] [datetime] NOT NULL,
 CONSTRAINT [PK_return_transaction] PRIMARY KEY CLUSTERED
(
	[transactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[state]    Script Date: 4/6/2022 9:53:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[state](
	[code] [char](2) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_state] PRIMARY KEY CLUSTERED
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[admin_employee] ([employeeID]) VALUES (10)
INSERT [dbo].[admin_employee] ([employeeID]) VALUES (11)
GO
SET IDENTITY_INSERT [dbo].[employee] ON

INSERT [dbo].[employee] ([employeeID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode], [username], [password]) VALUES (10, N'M', CAST(N'1985-09-20' AS Date), N'Burgess', N'Laise', N'7062099426', N'31 Mccormick Parkway', NULL, N'Columbus', N'GA', N'31914', N'blaise0', N'WF8WNvGTUoZzqgaoriociw==')
INSERT [dbo].[employee] ([employeeID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode], [username], [password]) VALUES (11, N'F', CAST(N'1986-09-08' AS Date), N'Lana', N'Lawrenson', N'4044299388', N'53819 Dayton Junction', NULL, N'Atlanta', N'GA', N'30358', N'llawrenson1', N'Xzkw4E3rkKquRay/Nm997A==')
INSERT [dbo].[employee] ([employeeID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode], [username], [password]) VALUES (12, N'M', CAST(N'1999-01-20' AS Date), N'Millard', N'Kienle', N'7062958616', N'0 Sutherland Trail', N'Apt 2E', N'Columbus', N'GA', N'31998', N'mkienle2', N'WF8WNvGTUoZzqgaoriociw==')
INSERT [dbo].[employee] ([employeeID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode], [username], [password]) VALUES (13, N'M', CAST(N'1965-01-13' AS Date), N'Kelley', N'Chaman', N'9123111248', N'4644 Towne Parkway', NULL, N'Savannah', N'GA', N'31422', N'kchaman3', N'v226g+Iqc/dZRuVKEteSZg==')
INSERT [dbo].[employee] ([employeeID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode], [username], [password]) VALUES (14, N'F', CAST(N'1981-08-05' AS Date), N'Delcine', N'Elbourne', N'4785409290', N'05 West Road', NULL, N'Macon', N'GA', N'31205', N'delbourne4', N'hM+ZiLa0tZsBfOvuy876hQ==')
INSERT [dbo].[employee] ([employeeID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode], [username], [password]) VALUES (15, N'M', CAST(N'1986-05-15' AS Date), N'Salomo', N'Cobbe', N'4042913682', N'6 Luster Drive', NULL, N'Atlanta', N'GA', N'30301', N'scobbe5', N'TvVZLptAvCF0hi3aCCvBig==')
INSERT [dbo].[employee] ([employeeID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode], [username], [password]) VALUES (16, N'F', CAST(N'1987-04-29' AS Date), N'Madlen', N'Cheston', N'4044530126', N'193 Mifflin Pass', N'Unit 7', N'Atlanta', N'GA', N'30356', N'mcheston6', N'Ake7A9AQ3gGzMtgVPfRc8Q==')
INSERT [dbo].[employee] ([employeeID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode], [username], [password]) VALUES (17, N'M', CAST(N'1981-03-22' AS Date), N'Cal', N'Adelsberg', N'4045142511', N'365 Jay Hill', NULL, N'Decatur', N'GA', N'30089', N'cadelsberg7', N'eA1mISjX/625zPuMaYe5pw==')
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0001', N'Lark Square Arm Sofa', N'Modern', N'Sofa', N'84" square arm sofa with button-tufted detail', CAST(15.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0002', N'Ibiza Flared Arm Sofa', N'Traditional', N'Sofa', N'80" flared arm sofa with premium upholstered fabric', CAST(15.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0003', N'Wetumka Cross Leg Coffee Table', N'Industrial', N'Coffee Table', N'Cross leg coffee table with steel base and manufactured wood top', CAST(5.00 AS Decimal(9, 2)), 15)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0004', N'Vaughn Coffee Table', N'Modern', N'Coffee Table', N'Round coffee table with storage shelf and steel base', CAST(5.00 AS Decimal(9, 2)), 15)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0005', N'Tarryn Wide Armchair', N'Country', N'Accent Chair', N'30" wide armchair with foam-filled polyester upholstry', CAST(5.00 AS Decimal(9, 2)), 25)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0006', N'Arnett Low Profile Bed', N'Traditional', N'Bed', N'Platform bed with solid wood frame and polyster upholstry', CAST(10.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0007', N'Marla Platform Bed', N'Industrial', N'Bed', N'Platform bed with black metal frame and wooden accents', CAST(10.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0008', N'Smith Tall Nightstand', N'Coastal', N'Nightstand', N'Two drawer nightstand with whitewash and gray finish', CAST(5.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0009', N'Weston 6 Drawer Dresser', N'Industrial', N'Dresser', N'58" dresser made from solid acacia wood', CAST(10.00 AS Decimal(9, 2)), 25)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0010', N'Dayna TV Stand', N'French Country', N'TV Stand', N'Solid backed stand with enclosed cabinets and brass hardware', CAST(8.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0011', N'Dakota Dining Table', N'Modern', N'Dining Table', N'Four person solid wood dining table with glass top', CAST(10.00 AS Decimal(9, 2)), 15)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0012', N'Dakota Dining Chair', N'Modern', N'Dining Chair', N'Faux leather upholstered dining chair', CAST(5.00 AS Decimal(9, 2)), 60)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0013', N'Pasha Dining Table', N'Mid-Century Modern', N'Dining Table', N'Four person table with pedestal base and anti-scratch white finish', CAST(10.00 AS Decimal(9, 2)), 15)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0014', N'Pasha Dining Chair', N'Mid-Century Modern', N'Dining Chair', N'Oak-look metal legs dining chair with fabric upholstered seat', CAST(5.00 AS Decimal(9, 2)), 60)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0015', N'Weare Office Desk', N'Glam', N'Desk', N'Solid wood desk with two drawers and brass finish on the base', CAST(8.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0016', N'Samora Console Table', N'Traditional', N'Console Table', N'Versatile console table made from engineered wood with cabinet doors', CAST(8.00 AS Decimal(9, 2)), 15)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0017', N'Joel Tall End Table', N'Country', N'End Table', N'24" clean-lined end table with washed gray finish', CAST(5.00 AS Decimal(9, 2)), 25)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0018', N'Isley Square Arm Loveseat', N'Boho', N'Loveseat', N'57" square arm loveseat with solid wood legs and polyester-blend upholstry', CAST(12.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0019', N'Garren Wide Armchair', N'Mid-Century Modern', N'Accent Chair', N'40" tufted club chair on tapered wooden feet with polyester upholstry', CAST(8.00 AS Decimal(9, 2)), 25)
INSERT [dbo].[furniture] ([furnitureID], [name], [style], [category], [description], [rentalRate], [totalQuantity]) VALUES (N'f0020', N'Corridon Accent Cabinet', N'Traditional', N'Cabinet', N'Tall 2-door wood cabinet with antique bronze metal finish', CAST(8.00 AS Decimal(9, 2)), 15)
GO
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Accent Chair')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Bar Stool')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Bed')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Bench')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Cabinet')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Coffee Table')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Console Table')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Desk')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Dining Chair')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Dining Table')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Dresser')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'End Table')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Loveseat')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Nightstand')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Recliner')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'Sofa')
INSERT [dbo].[furniture_category] ([categoryName]) VALUES (N'TV Stand')
GO
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'American Traditional')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Beach')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Boho')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Classic Farmhouse')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Classical Industrial')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Coastal')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Country')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'French Country')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Glam')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Industrial')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Mid-Century Modern')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Modern')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Modern Farmhouse')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Nautical')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Rustic')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Traditional')
INSERT [dbo].[furniture_style] ([styleName]) VALUES (N'Transitional Modern')
GO
SET IDENTITY_INSERT [dbo].[member] ON

INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1000, N'M', CAST(N'1981-08-05' AS Date), N'Elijah', N'Lambal', N'7727125493', N'5 Kipling Center', NULL, N'West Palm Beach', N'FL', N'33405')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1001, N'F', CAST(N'1960-04-23' AS Date), N'Margita', N'Sporle', N'9418800181', N'56 Texas Hills', NULL, N'Punta Gordan', N'FL', N'33982')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1002, N'M', CAST(N'1999-02-19' AS Date), N'Nickolai', N'Coggon', N'3528909253', N'55110 Comanche Points', NULL, N'Gainesville', N'FL', N'32610')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1003, N'F', CAST(N'1996-03-09' AS Date), N'Julieta', N'Snowsill', N'9547161850', N'68431 Arrowood Way', NULL, N'Fort Lauderdale', N'FL', N'33315')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1004, N'F', CAST(N'1987-04-24' AS Date), N'Lauralee', N'Paz', N'3055286651', N'75 Jackson Parkway', N'Apt 2E', N'Boca Raton', N'FL', N'33487')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1005, N'F', CAST(N'1997-10-13' AS Date), N'Lita', N'Kitchingham', N'2393769904', N'68267 Gerald Crossing', NULL, N'Cape Coral', N'FL', N'33915')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1006, N'F', CAST(N'1972-12-04' AS Date), N'Marnia', N'Marten', N'4076278039', N'482 2nd Way', NULL, N'Orlando', N'FL', N'32868')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1007, N'F', CAST(N'2003-09-01' AS Date), N'Elvina', N'Aimer', N'7271963706', N'03363 Eliot Junction', NULL, N'Saint Petersburg', N'FL', N'33742')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1008, N'F', CAST(N'1989-11-14' AS Date), N'Rosalind', N'Cockill', N'3055769917', N'81812 Trailsway Terrace', NULL, N'Miami', N'FL', N'33142')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1009, N'F', CAST(N'1990-03-20' AS Date), N'Benedicta', N'Sieghart', N'2397374130', N'17 Merchant Park', NULL, N'Naples', N'FL', N'34102')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1010, N'F', CAST(N'1998-03-14' AS Date), N'Lezlie', N'Fayter', N'3057663180', N'3 Mayer Street', N'Unit 8', N'Hollywood', N'FL', N'33023')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1011, N'F', CAST(N'1980-05-07' AS Date), N'Alvera', N'Waghorne', N'7707893750', N'0 Harbort Circle', N'Unit 4', N'Duluth', N'GA', N'30096')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1012, N'M', CAST(N'1967-03-14' AS Date), N'Valentine', N'Cogman', N'3526163537', N'95842 Village Terrace', NULL, N'Ocala', N'FL', N'34474')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1013, N'F', CAST(N'1985-07-11' AS Date), N'Gwennie', N'Koppen', N'4078525106', N'07 Boyd Road', NULL, N'Orlando', N'FL', N'32825')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1014, N'F', CAST(N'1988-09-27' AS Date), N'Starlin', N'Stud', N'4043082352', N'7201 8th Pass', NULL, N'Atlanta', N'GA', N'31196')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1015, N'M', CAST(N'1983-09-23' AS Date), N'Karel', N'Panter', N'2296733675', N'03 Amoth Terrace', NULL, N'Albany', N'GA', N'31704')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1016, N'F', CAST(N'1977-08-26' AS Date), N'Moria', N'Wollrauch', N'7706258797', N'677 Lerdahl Drive', NULL, N'Decatur', N'GA', N'30033')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1017, N'M', CAST(N'1980-01-15' AS Date), N'Putnem', N'Habbijam', N'9048354013', N'14 Moulton Trail', NULL, N'Jacksonville', N'FL', N'32209')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1018, N'F', CAST(N'1983-06-14' AS Date), N'Amandy', N'Hallagan', N'8138250048', N'652 Cambridge Trail', N'Apt 5', N'Tampa', N'FL', N'33633')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1019, N'M', CAST(N'1981-11-14' AS Date), N'Pyotr', N'Munnis', N'7728923886', N'09323 Scott Avenue', NULL, N'Vero Beach', N'FL', N'32969')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1020, N'F', CAST(N'1980-04-05' AS Date), N'Lauralee', N'Paz', N'4071458796', N'15 Harber Way', NULL, N'Orlando', N'FL', N'32868')
INSERT [dbo].[member] ([memberID], [sex], [dateOfBirth], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipCode]) VALUES (1021, N'F', CAST(N'1975-05-03' AS Date), N'Lezlie', N'Fayter', N'3524778975', N'130 Parkland Way', NULL, N'Ocala', N'FL', N'34474')
SET IDENTITY_INSERT [dbo].[member] OFF
GO
INSERT [dbo].[regular_employee] ([employeeID]) VALUES (12)
INSERT [dbo].[regular_employee] ([employeeID]) VALUES (13)
INSERT [dbo].[regular_employee] ([employeeID]) VALUES (14)
INSERT [dbo].[regular_employee] ([employeeID]) VALUES (15)
INSERT [dbo].[regular_employee] ([employeeID]) VALUES (16)
INSERT [dbo].[regular_employee] ([employeeID]) VALUES (17)
GO
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (1, N'f0001', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (1, N'f0003', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (2, N'f0013', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (2, N'f0014', 4)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (3, N'f0011', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (3, N'f0012', 4)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (4, N'f0007', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (4, N'f0008', 2)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (4, N'f0009', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (5, N'f0002', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (5, N'f0017', 2)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (6, N'f0010', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (6, N'f0018', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (6, N'f0020', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (7, N'f0001', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (7, N'f0004', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (8, N'f0011', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (8, N'f0014', 6)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (9, N'f0002', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (9, N'f0004', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (9, N'f0017', 2)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (10, N'f0007', 2)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (10, N'f0008', 4)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (10, N'f0009', 2)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (11, N'f0006', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (11, N'f0016', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (12, N'f0001', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (12, N'f0003', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (12, N'f0017', 2)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (13, N'f0016', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (13, N'f0018', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (13, N'f0019', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (13, N'f0020', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (14, N'f0006', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (15, N'f0015', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (15, N'f0020', 2)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (16, N'f0011', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (16, N'f0012', 6)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (17, N'f0007', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (17, N'f0008', 2)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (17, N'f0009', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (18, N'f0015', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (18, N'f0016', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (19, N'f0001', 1)
INSERT [dbo].[rental_item] ([transactionID], [furnitureID], [quantity]) VALUES (20, N'f0011', 1)
GO
SET IDENTITY_INSERT [dbo].[rental_transaction] ON

INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (1, 1000, 12, CAST(N'2021-12-09T18:21:00.000' AS DateTime), CAST(N'2021-12-19T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (2, 1001, 13, CAST(N'2021-12-12T11:50:00.000' AS DateTime), CAST(N'2021-12-19T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (3, 1002, 13, CAST(N'2021-12-12T15:28:00.000' AS DateTime), CAST(N'2021-12-26T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (4, 1003, 14, CAST(N'2021-12-15T16:32:00.000' AS DateTime), CAST(N'2021-12-27T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (5, 1004, 12, CAST(N'2022-01-12T13:54:00.000' AS DateTime), CAST(N'2022-01-22T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (6, 1005, 15, CAST(N'2022-01-13T08:25:00.000' AS DateTime), CAST(N'2022-01-20T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (7, 1006, 15, CAST(N'2022-01-23T14:30:00.000' AS DateTime), CAST(N'2022-01-30T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (8, 1007, 16, CAST(N'2022-01-25T12:51:00.000' AS DateTime), CAST(N'2022-02-08T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (9, 1008, 16, CAST(N'2022-01-29T16:31:00.000' AS DateTime), CAST(N'2022-02-05T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (10, 1009, 14, CAST(N'2022-02-01T16:56:00.000' AS DateTime), CAST(N'2022-02-11T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (11, 1002, 12, CAST(N'2022-02-03T15:21:00.000' AS DateTime), CAST(N'2022-02-15T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (12, 1014, 13, CAST(N'2022-02-07T13:25:00.000' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (13, 1015, 15, CAST(N'2022-02-10T10:30:00.000' AS DateTime), CAST(N'2022-02-18T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (14, 1018, 14, CAST(N'2022-02-10T14:42:00.000' AS DateTime), CAST(N'2022-02-20T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (15, 1001, 14, CAST(N'2022-02-15T16:10:00.000' AS DateTime), CAST(N'2022-02-27T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (16, 1005, 15, CAST(N'2022-02-22T08:06:00.000' AS DateTime), CAST(N'2022-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (17, 1003, 16, CAST(N'2022-03-06T00:00:00.000' AS DateTime), CAST(N'2022-03-13T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (18, 1010, 13, CAST(N'2022-03-07T14:00:00.000' AS DateTime), CAST(N'2022-03-14T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (19, 1002, 13, CAST(N'2022-03-08T08:30:00.000' AS DateTime), CAST(N'2022-03-22T00:00:00.000' AS DateTime))
INSERT [dbo].[rental_transaction] ([transactionID], [memberID], [employeeID], [rentalDate], [dueDate]) VALUES (20, 1007, 12, CAST(N'2022-03-09T10:51:00.000' AS DateTime), CAST(N'2022-03-25T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[rental_transaction] OFF
GO
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (1, 1, N'f0001', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (1, 1, N'f0003', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (2, 2, N'f0013', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (2, 2, N'f0014', 4)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (3, 3, N'f0011', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (3, 3, N'f0012', 4)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (4, 4, N'f0007', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (4, 4, N'f0008', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (5, 4, N'f0008', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (5, 4, N'f0009', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (6, 6, N'f0010', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (6, 6, N'f0018', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (6, 6, N'f0020', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (7, 5, N'f0002', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (7, 5, N'f0017', 2)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (8, 7, N'f0001', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (8, 7, N'f0004', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (9, 9, N'f0002', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (9, 9, N'f0004', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (9, 9, N'f0017', 2)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (10, 8, N'f0011', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (10, 8, N'f0014', 2)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (11, 8, N'f0014', 4)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (12, 10, N'f0007', 2)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (12, 10, N'f0008', 4)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (12, 10, N'f0009', 2)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (13, 11, N'f0006', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (13, 11, N'f0016', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (14, 12, N'f0001', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (14, 12, N'f0003', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (14, 12, N'f0017', 2)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (15, 13, N'f0016', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (15, 13, N'f0018', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (15, 13, N'f0019', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (15, 13, N'f0020', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (16, 14, N'f0006', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (17, 15, N'f0015', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (17, 15, N'f0020', 2)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (18, 16, N'f0011', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (19, 16, N'f0012', 6)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (20, 17, N'f0007', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (20, 17, N'f0008', 1)
INSERT [dbo].[return_item] ([transactionID], [rentalTransactionID], [furnitureID], [quantity]) VALUES (21, 18, N'f0015', 1)
GO
SET IDENTITY_INSERT [dbo].[return_transaction] ON

INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (1, 1000, 13, CAST(N'2021-12-19T14:31:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (2, 1001, 13, CAST(N'2021-12-19T15:24:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (3, 1002, 15, CAST(N'2021-12-24T10:27:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (4, 1003, 14, CAST(N'2021-12-17T11:52:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (5, 1003, 12, CAST(N'2021-12-28T10:14:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (6, 1005, 16, CAST(N'2022-01-20T14:15:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (7, 1004, 12, CAST(N'2022-01-22T09:47:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (8, 1006, 14, CAST(N'2022-01-30T15:55:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (9, 1008, 13, CAST(N'2022-02-05T13:10:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (10, 1007, 14, CAST(N'2022-02-08T10:15:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (11, 1007, 14, CAST(N'2022-02-08T16:32:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (12, 1009, 15, CAST(N'2022-02-11T17:10:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (13, 1002, 13, CAST(N'2022-02-14T10:10:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (14, 1014, 12, CAST(N'2022-02-16T15:47:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (15, 1015, 13, CAST(N'2022-02-18T13:11:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (16, 1018, 12, CAST(N'2022-02-19T14:25:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (17, 1001, 15, CAST(N'2022-02-27T11:23:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (18, 1005, 16, CAST(N'2022-03-01T09:45:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (19, 1005, 16, CAST(N'2022-03-02T10:43:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (20, 1003, 14, CAST(N'2022-03-12T13:54:00.000' AS DateTime))
INSERT [dbo].[return_transaction] ([transactionID], [memberID], [employeeID], [returnDate]) VALUES (21, 1010, 14, CAST(N'2022-03-13T12:31:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[return_transaction] OFF
GO
INSERT [dbo].[state] ([code], [name]) VALUES (N'AK', N'Alaska')
INSERT [dbo].[state] ([code], [name]) VALUES (N'AL', N'Alabama')
INSERT [dbo].[state] ([code], [name]) VALUES (N'AR', N'Arkansas')
INSERT [dbo].[state] ([code], [name]) VALUES (N'AS', N'American Samoa')
INSERT [dbo].[state] ([code], [name]) VALUES (N'AZ', N'Arizona')
INSERT [dbo].[state] ([code], [name]) VALUES (N'CA', N'California')
INSERT [dbo].[state] ([code], [name]) VALUES (N'CO', N'Colorado')
INSERT [dbo].[state] ([code], [name]) VALUES (N'CT', N'Connecticut')
INSERT [dbo].[state] ([code], [name]) VALUES (N'DC', N'District of Columbia')
INSERT [dbo].[state] ([code], [name]) VALUES (N'DE', N'Delaware')
INSERT [dbo].[state] ([code], [name]) VALUES (N'FL', N'Florida')
INSERT [dbo].[state] ([code], [name]) VALUES (N'FM', N'Federated States of Micronesia')
INSERT [dbo].[state] ([code], [name]) VALUES (N'GA', N'Georgia')
INSERT [dbo].[state] ([code], [name]) VALUES (N'GU', N'Guam')
INSERT [dbo].[state] ([code], [name]) VALUES (N'HI', N'Hawaii')
INSERT [dbo].[state] ([code], [name]) VALUES (N'IA', N'Iowa')
INSERT [dbo].[state] ([code], [name]) VALUES (N'ID', N'Idaho')
INSERT [dbo].[state] ([code], [name]) VALUES (N'IL', N'Illinois')
INSERT [dbo].[state] ([code], [name]) VALUES (N'IN', N'Indiana')
INSERT [dbo].[state] ([code], [name]) VALUES (N'KS', N'Kansas')
INSERT [dbo].[state] ([code], [name]) VALUES (N'KY', N'Kentucky')
INSERT [dbo].[state] ([code], [name]) VALUES (N'LA', N'Louisiana')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MA', N'Massachusetts')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MD', N'Maryland')
INSERT [dbo].[state] ([code], [name]) VALUES (N'ME', N'Maine')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MH', N'Marshall Islands')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MI', N'Michigan')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MN', N'Minnesota')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MO', N'Missouri')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MP', N'Northern Mariana Islands')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MS', N'Mississippi')
INSERT [dbo].[state] ([code], [name]) VALUES (N'MT', N'Montana')
INSERT [dbo].[state] ([code], [name]) VALUES (N'NC', N'North Carolina')
INSERT [dbo].[state] ([code], [name]) VALUES (N'ND', N'North Dakota')
INSERT [dbo].[state] ([code], [name]) VALUES (N'NE', N'Nebraska')
INSERT [dbo].[state] ([code], [name]) VALUES (N'NH', N'New Hampshire')
INSERT [dbo].[state] ([code], [name]) VALUES (N'NJ', N'New Jersey')
INSERT [dbo].[state] ([code], [name]) VALUES (N'NM', N'New Mexico')
INSERT [dbo].[state] ([code], [name]) VALUES (N'NV', N'Nevada')
INSERT [dbo].[state] ([code], [name]) VALUES (N'NY', N'New York')
INSERT [dbo].[state] ([code], [name]) VALUES (N'OH', N'Ohio')
INSERT [dbo].[state] ([code], [name]) VALUES (N'OK', N'Oklahoma')
INSERT [dbo].[state] ([code], [name]) VALUES (N'OR', N'Oregon')
INSERT [dbo].[state] ([code], [name]) VALUES (N'PA', N'Pennsylvania')
INSERT [dbo].[state] ([code], [name]) VALUES (N'PR', N'Puerto Rico')
INSERT [dbo].[state] ([code], [name]) VALUES (N'PW', N'Palau')
INSERT [dbo].[state] ([code], [name]) VALUES (N'RI', N'Rhode Island')
INSERT [dbo].[state] ([code], [name]) VALUES (N'SC', N'South Carolina')
INSERT [dbo].[state] ([code], [name]) VALUES (N'SD', N'South Dakota')
INSERT [dbo].[state] ([code], [name]) VALUES (N'TN', N'Tennessee')
INSERT [dbo].[state] ([code], [name]) VALUES (N'TX', N'Texas')
INSERT [dbo].[state] ([code], [name]) VALUES (N'UT', N'Utah')
INSERT [dbo].[state] ([code], [name]) VALUES (N'VA', N'Virginia')
INSERT [dbo].[state] ([code], [name]) VALUES (N'VI', N'Virgin Islands')
INSERT [dbo].[state] ([code], [name]) VALUES (N'VT', N'Vermont')
INSERT [dbo].[state] ([code], [name]) VALUES (N'WA', N'Washington')
INSERT [dbo].[state] ([code], [name]) VALUES (N'WI', N'Wisconsin')
INSERT [dbo].[state] ([code], [name]) VALUES (N'WV', N'West Virginia')
INSERT [dbo].[state] ([code], [name]) VALUES (N'WY', N'Wyoming')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_member]    Script Date: 4/6/2022 9:53:44 AM ******/
ALTER TABLE [dbo].[member] ADD  CONSTRAINT [UK_member] UNIQUE NONCLUSTERED
(
	[firstName] ASC,
	[lastName] ASC,
	[phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[admin_employee]  WITH CHECK ADD  CONSTRAINT [FK_admin_employee_employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[admin_employee] CHECK CONSTRAINT [FK_admin_employee_employee]
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [FK_employee_state] FOREIGN KEY([state])
REFERENCES [dbo].[state] ([code])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [FK_employee_state]
GO
ALTER TABLE [dbo].[furniture]  WITH CHECK ADD  CONSTRAINT [FK_furniture_furniture_category] FOREIGN KEY([category])
REFERENCES [dbo].[furniture_category] ([categoryName])
GO
ALTER TABLE [dbo].[furniture] CHECK CONSTRAINT [FK_furniture_furniture_category]
GO
ALTER TABLE [dbo].[furniture]  WITH CHECK ADD  CONSTRAINT [FK_furniture_furniture_style] FOREIGN KEY([style])
REFERENCES [dbo].[furniture_style] ([styleName])
GO
ALTER TABLE [dbo].[furniture] CHECK CONSTRAINT [FK_furniture_furniture_style]
GO
ALTER TABLE [dbo].[member]  WITH CHECK ADD  CONSTRAINT [FK_member_state] FOREIGN KEY([state])
REFERENCES [dbo].[state] ([code])
GO
ALTER TABLE [dbo].[member] CHECK CONSTRAINT [FK_member_state]
GO
ALTER TABLE [dbo].[regular_employee]  WITH CHECK ADD  CONSTRAINT [FK_regular_employee_employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[regular_employee] CHECK CONSTRAINT [FK_regular_employee_employee]
GO
ALTER TABLE [dbo].[rental_item]  WITH CHECK ADD  CONSTRAINT [FK_rental_item_furniture] FOREIGN KEY([furnitureID])
REFERENCES [dbo].[furniture] ([furnitureID])
GO
ALTER TABLE [dbo].[rental_item] CHECK CONSTRAINT [FK_rental_item_furniture]
GO
ALTER TABLE [dbo].[rental_item]  WITH CHECK ADD  CONSTRAINT [FK_rental_item_rental_transaction] FOREIGN KEY([transactionID])
REFERENCES [dbo].[rental_transaction] ([transactionID])
GO
ALTER TABLE [dbo].[rental_item] CHECK CONSTRAINT [FK_rental_item_rental_transaction]
GO
ALTER TABLE [dbo].[rental_transaction]  WITH CHECK ADD  CONSTRAINT [FK_rental_transaction_member] FOREIGN KEY([memberID])
REFERENCES [dbo].[member] ([memberID])
GO
ALTER TABLE [dbo].[rental_transaction] CHECK CONSTRAINT [FK_rental_transaction_member]
GO
ALTER TABLE [dbo].[rental_transaction]  WITH CHECK ADD  CONSTRAINT [FK_rental_transaction_regular_employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[regular_employee] ([employeeID])
GO
ALTER TABLE [dbo].[rental_transaction] CHECK CONSTRAINT [FK_rental_transaction_regular_employee]
GO
ALTER TABLE [dbo].[return_item]  WITH CHECK ADD  CONSTRAINT [FK_return_item_rental_item] FOREIGN KEY([rentalTransactionID], [furnitureID])
REFERENCES [dbo].[rental_item] ([transactionID], [furnitureID])
GO
ALTER TABLE [dbo].[return_item] CHECK CONSTRAINT [FK_return_item_rental_item]
GO
ALTER TABLE [dbo].[return_item]  WITH CHECK ADD  CONSTRAINT [FK_return_item_return_transaction] FOREIGN KEY([transactionID])
REFERENCES [dbo].[return_transaction] ([transactionID])
GO
ALTER TABLE [dbo].[return_item] CHECK CONSTRAINT [FK_return_item_return_transaction]
GO
ALTER TABLE [dbo].[return_transaction]  WITH CHECK ADD  CONSTRAINT [FK_return_transaction_member] FOREIGN KEY([memberID])
REFERENCES [dbo].[member] ([memberID])
GO
ALTER TABLE [dbo].[return_transaction] CHECK CONSTRAINT [FK_return_transaction_member]
GO
ALTER TABLE [dbo].[return_transaction]  WITH CHECK ADD  CONSTRAINT [FK_return_transaction_regular_employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[regular_employee] ([employeeID])
GO
ALTER TABLE [dbo].[return_transaction] CHECK CONSTRAINT [FK_return_transaction_regular_employee]
GO
USE [master]
GO
ALTER DATABASE [cs6232-g1] SET  READ_WRITE
GO
