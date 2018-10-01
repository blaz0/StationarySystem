USE [sepdb]
GO

/****** Object:  Table [dbo].[invoice]    Script Date: 3/09/2018 1:40:16 AM ******/
DROP TABLE dbo.invoice
GO

/****** Object:  Table [dbo].[invoice]    Script Date: 3/09/2018 1:40:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE dbo.invoice(
	invoiceID int NOT NULL,
	supplierID int NOT NULL,
	date datetime NOT NULL,
	totalAmount decimal(10, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(invoiceID ASC)
GO

INSERT INTO invoice VALUES (1,1,'2018-07-22 00:00:00',100),(2,2,'2018-07-01 00:00:00',20),(3,1,'2018-06-25 00:00:00',50),(4,1,'2018-06-22 00:00:00',45),(5,3,'2018-05-30 00:00:00',16),(6,3,'2018-07-12 00:00:00',9),(7,2,'2018-09-04 00:00:00',22);
GO
