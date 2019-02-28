/*  Modify here...   */
USE [DB_A444B6_blazinaj]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 1/25/2019 12:07:02 PM ******/
DROP TABLE [dbo].[Customer]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 1/25/2019 12:07:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[CustNumber] [varchar](50) NOT NULL,
	[Company] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Street] [varchar](50) NULL,
	[City] [nchar](10) NULL,
	[State] [nchar](2) NULL,
	[Zip] [nchar](10) NULL,
	[Contact] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Inventory]    Script Date: 1/25/2019 12:09:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Inventory](
	[ItemNumber] [varchar](50) NOT NULL,
	[QOH] [smallint] NULL,
	[UnitPrice] [money] NULL,
	[UnitWeight] [float] NULL,
	[Description] [varchar](100) NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[ItemNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Invoice]    Script Date: 1/25/2019 12:10:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice](
	[InvoiceNumber] [varchar](50) NOT NULL,
	[CustNumber] [varchar](50) NULL,
	[OrderDate] [date] NULL,
	[ShipDate] [date] NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[LineItem]    Script Date: 1/25/2019 12:24:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LineItem](
	[InvoiceNumber] [varchar](50) NOT NULL,
	[LineNumber] [smallint] NOT NULL,
	[ItemNumber] [varchar](50) NULL,
	[Quantity] [smallint] NULL,
 CONSTRAINT [PK_LineItem] PRIMARY KEY CLUSTERED 
(
	[InvoiceNumber] ASC,
	[LineNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Supplier]    Script Date: 1/25/2019 12:37:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Supplier](
	[SupplierNumber] [varchar](50) NOT NULL,
	[SupplierCompany] [varchar](50) NULL,
	[SupplierPhone] [nchar](10) NULL,
	[SupplierContact] [varchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




