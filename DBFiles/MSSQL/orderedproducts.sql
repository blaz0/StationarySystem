USE [sepdb]
GO

/****** Object:  Table [dbo].[orderedproducts]    Script Date: 3/09/2018 1:47:59 AM ******/
DROP TABLE [dbo].[orderedproducts]
GO

/****** Object:  Table [dbo].[orderedproducts]    Script Date: 3/09/2018 1:47:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[orderedproducts](
	[orderID] [int] NOT NULL,
	[productID] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[totalPrice] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_orderedproducts] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC,
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO orderedproducts VALUES (1,1,5,15),(1,3,10,50),(2,1,10,30),(3,3,20,100),(4,2,10,30),(5,2,10,30);
GO
