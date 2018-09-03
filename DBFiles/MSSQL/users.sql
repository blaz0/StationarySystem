USE sepdb
GO

DROP TABLE dbo.users
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE dbo.users(
  userId int NOT NULL,
  firstName varchar(20) NOT NULL,
  lastName varchar(20) NOT NULL,
  username varchar(20) NOT NULL,
  password varchar(45) NOT NULL,
  emailAddress varchar(50) NOT NULL,
  phoneNumber varchar(15) NOT NULL,
  costCentre varchar(30) NOT NULL,
  CONSTRAINT PK_users PRIMARY KEY CLUSTERED (userId ASC)
)
GO

CREATE UNIQUE NONCLUSTERED INDEX UKusers_username ON dbo.users (username ASC)
GO


INSERT INTO dbo.users VALUES (1,'Julia','Manning','12875795','julia','JManning@gmail.com','0459628156','FEIT1001'),(2,'Connie','Zhang','12875023','connie','CZhang@uts.edu.au','0419581232','FMED1002'),(3,'Bela','Hipolito','12918304','bela','BelaHipolito@yahoo.com','0422869939','FEIT1001'),(4,'Maxine','Koh','12870567','maxine','MaxineK@bigpond.net.au','0404559672','FDAB1004'),(5,'Clarrisa','Lim','12879032','clarissa','Clarissa98@hotmail.com','0466837561','FBUS1003');
go

SELECT * FROM dbo.users
go
