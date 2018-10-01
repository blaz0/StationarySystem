USE sepdb
GO

ALTER TABLE dbo.requestedstationery DROP CONSTRAINT reqstatFKstationeryrequest
GO

ALTER TABLE dbo.requestedstationery DROP CONSTRAINT reqstatFKproduct
GO

/****** Object:  Table [dbo].[requestedstationery]    Script Date: 3/09/2018 1:53:20 AM ******/
DROP TABLE dbo.requestedstationery
GO

/****** Object:  Table [dbo].[requestedstationery]    Script Date: 3/09/2018 1:53:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE dbo.requestedstationery(
	requestID int NOT NULL,
	productID int NOT NULL,
	quantity int NOT NULL,
PRIMARY KEY CLUSTERED 
(requestID ASC, productID ASC)) ON PRIMARY
GO

ALTER TABLE dbo.requestedstationery  WITH CHECK ADD  CONSTRAINT reqstatFKproduct FOREIGN KEY(productID)
REFERENCES dbo.product (productID)
GO

ALTER TABLE dbo.requestedstationery CHECK CONSTRAINT reqstatFKproduct
GO

ALTER TABLE dbo.requestedstationery  WITH CHECK ADD  CONSTRAINT reqstatFKstationeryrequest FOREIGN KEY(requestID)
REFERENCES dbo.stationeryrequest (requestID)
GO

ALTER TABLE dbo.requestedstationery CHECK CONSTRAINT reqstatFKstationeryrequest
GO

INSERT INTO requestedstationery VALUES (1,3,10),(2,4,23),(3,5,16);
GO
