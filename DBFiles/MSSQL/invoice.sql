USE [sepdb]
GO

/****** Object:  Table [dbo].[invoice]    Script Date: 3/09/2018 1:40:16 AM ******/
DROP TABLE [dbo].[invoice]
GO

/****** Object:  Table [dbo].[invoice]    Script Date: 3/09/2018 1:40:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[invoice](
	[invoiceID] [int] NOT NULL,
	[supplierID] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[totalAmount] [decimal](10, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[invoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO invoice VALUES (1,1,'2018-07-22 00:00:00',100),(2,1,'2018-07-01 00:00:00',20),(3,1,'2018-06-25 00:00:00',50),(4,1,'2018-06-22 00:00:00',45),(5,1,'2018-05-30 00:00:00',16);
GO
