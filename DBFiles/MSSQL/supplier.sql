USE sepdb
GO

DROP TABLE dbo.supplier
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE supplier (
  supplierID int NOT NULL,
  name varchar(40) NOT NULL,
  streetAddress varchar(80) NOT NULL,
  phoneNo varchar(10) NOT NULL,
  website varchar(50) NOT NULL,
  PRIMARY KEY (supplierID)
)
GO

CREATE UNIQUE NONCLUSTERED INDEX UKsupplier_supplierID ON dbo.supplier(supplierID)
GO
CREATE UNIQUE NONCLUSTERED INDEX UKsupplier_name ON dbo.supplier(name)
GO
CREATE UNIQUE NONCLUSTERED INDEX UKsupplier_streetAddress ON dbo.supplier(streetAddress)
GO
CREATE UNIQUE NONCLUSTERED INDEX UKsupplier_phoneNo ON dbo.supplier(phoneNo)
GO
CREATE UNIQUE NONCLUSTERED INDEX UKsupplier_website ON dbo.supplier(website)
GO

INSERT INTO supplier VALUES (1,'Pens, Paper and Rulers','12 Market St, Sydney','97235585','www.penspaperandrulers.com.au'),(2,'Whiteboard and Co.','4 Clarence St, Sydney','69385011','www.whiteboards.co.com'),(3,'Rulers\R\Us','876 Steven Ave, Sydney','28791003','www.rulersrus.com.au');
GO
