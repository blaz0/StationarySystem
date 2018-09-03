USE sepdb
GO

DROP TABLE dbo.supplierorder
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE supplierorder (
  orderID int NOT NULL,
  userID int NOT NULL,
  orderDate date NOT NULL,
  status varchar(15) NOT NULL,
  PRIMARY KEY (orderID),
  CONSTRAINT suporderFKuser FOREIGN KEY (userID) REFERENCES users (userID)
)
GO

CREATE UNIQUE NONCLUSTERED INDEX UKsupplierorder_orderID ON dbo.supplierorder (orderID ASC)
GO

CREATE INDEX suporderFKuser_idx ON dbo.supplierorder (userID)
GO

INSERT INTO supplierorder VALUES (1,4,'2018-08-24','Pending'),(2,4,'2018-08-17','Pending'),(3,4,'2018-08-10','Delivered'),(4,4,'2018-08-03','Delivered'),(5,4,'2018-07-27','Delivered');
GO
