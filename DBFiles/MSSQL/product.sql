USE sepdb
GO

/****** Object:  Table [dbo].[product]    Script Date: 3/09/2018 1:46:14 AM ******/
DROP TABLE dbo.product
GO

/****** Object:  Table [dbo].[product]    Script Date: 3/09/2018 1:46:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE dbo.product(
	productID [int NOT NULL,
	supplierID [int NOT NULL,
	name varchar(20) NOT NULL,
	description [varchar](100) NOT NULL,
	stock int NOT NULL,
	price decimal(18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(productID ASC)) 
GO

ALTER TABLE dbo.product  WITH CHECK ADD  CONSTRAINT productFKsupplier FOREIGN KEY(supplierID)
REFERENCES dbo.supplier (supplierID)
GO

ALTER TABLE dbo.product CHECK CONSTRAINT productFKsupplier
GO

INSERT INTO product VALUES (1,1,'blue pen','A blue ballpoint pen that glides along the paper',50,3),(2,1,'black pen','A black ballpoint pen that is perfect for examinations',50,3),(3,2,'butchers paper','A pack of three A3 butchers paper sheets',0,5),(4,1,'whiteboard marker','A black whiteboard marker that has a thick point and does not stain',50,4),(5,3,'ruler','A clear plastic 30cm ruler accepted by examinors worldwide',50,3);
GO
