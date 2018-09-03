USE [sepdb]
GO

ALTER TABLE [dbo].[product] DROP CONSTRAINT [productFKsupplier]
GO

/****** Object:  Table [dbo].[product]    Script Date: 3/09/2018 1:46:14 AM ******/
DROP TABLE [dbo].[product]
GO

/****** Object:  Table [dbo].[product]    Script Date: 3/09/2018 1:46:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[product](
	[productID] [int] NOT NULL,
	[supplierID] [int] NOT NULL,
	[name] [varchar](20) NOT NULL,
	[description] [varchar](100) NOT NULL,
	[stock] [int] NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [productFKsupplier] FOREIGN KEY([supplierID])
REFERENCES [dbo].[supplier] ([supplierID])
GO

ALTER TABLE [dbo].[product] CHECK CONSTRAINT [productFKsupplier]
GO




INSERT INTO product VALUES (1,1,'blue pen','blue ballpoint pen',50,3),(2,1,'black pen','black ballpoint pen',50,3),(3,2,'butchers paper','A3 butchers paper',50,5),(4,1,'whiteboard marker','black whiteboard marker',50,4),(5,3,'ruler','clear plastic 30cm ruler',50,3);
GO