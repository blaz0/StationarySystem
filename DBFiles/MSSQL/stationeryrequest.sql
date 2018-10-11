USE sepdb
GO

ALTER TABLE dbo.stationeryrequest DROP CONSTRAINT statreqFKuser
GO

ALTER TABLE dbo.stationeryrequest DROP CONSTRAINT statreqFKproduct
GO

/****** Object:  Table [dbo].[stationeryrequest]    Script Date: 3/09/2018 1:51:46 AM ******/
DROP TABLE dbo.stationeryrequest
GO

/****** Object:  Table [dbo].[stationeryrequest]    Script Date: 3/09/2018 1:51:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE dbo.stationeryrequest(
	requestID int IDENTITY NOT NULL,
	userID int NOT NULL,
	productID int NOT NULL,
	requestDate date NOT NULL,
	status varchar(20) NOT NULL,
	quantity int NOT NULL,
	totalPrice int NOT NULL,
	PRIMARY KEY (requestID)
	)
GO

ALTER TABLE dbo.stationeryrequest  WITH CHECK ADD  CONSTRAINT statreqFKproduct FOREIGN KEY(productID)
REFERENCES dbo.product (productID)
GO

ALTER TABLE dbo.stationeryrequest CHECK CONSTRAINT statreqFKproduct
GO

ALTER TABLE dbo.stationeryrequest  WITH CHECK ADD  CONSTRAINT statreqFKuser FOREIGN KEY(userID)
REFERENCES dbo.users (userId)
GO

ALTER TABLE dbo.stationeryrequest CHECK CONSTRAINT statreqFKuser
GO

INSERT INTO stationeryrequest VALUES (1,1,1,'2018-08-27','Submitted'),(2,3,2,'2018-08-27','Submitted'),(3,3,3,'2018-07-22','Approved'),(4,5,4,'2018-06-18','Denied'),(5,2,5,'2018-06-17','Delivered'),(6,4,3,'2018-08-11','Denied'),(7,3,5,'2018-09-24','Denied'),(8,1,1,'2018-04-02','Denied'),(9,4,1,'2018-10-01','Submitted');
GO
