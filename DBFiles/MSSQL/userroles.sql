USE sepdb
GO

DROP TABLE dbo.userroles
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE userroles (
  userID int NOT NULL,
  role varchar(20) NOT NULL,
  PRIMARY KEY (userID,role),
  CONSTRAINT userRolesFKuser FOREIGN KEY (userID) REFERENCES users (userID)
)
GO

INSERT INTO userroles VALUES (1,'Stationery Manager'),(2,'User'),(3,'User'),(4,'System Admin'),(5,'User');
GO
