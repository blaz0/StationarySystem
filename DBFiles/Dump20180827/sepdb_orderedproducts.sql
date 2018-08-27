CREATE DATABASE  IF NOT EXISTS `sepdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `sepdb`;
-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: sepdb
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `orderedproducts`
--

DROP TABLE IF EXISTS `orderedproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `orderedproducts` (
  `orderID` int(8) NOT NULL,
  `productID` int(8) NOT NULL,
  `quantity` int(3) NOT NULL,
  `totalPrice` decimal(10,0) NOT NULL,
  PRIMARY KEY (`orderID`,`productID`),
  KEY `ordproductFKproduct_idx` (`productID`),
  CONSTRAINT `ordproductFKorder` FOREIGN KEY (`orderID`) REFERENCES `supplierorder` (`orderid`),
  CONSTRAINT `ordproductFKproduct` FOREIGN KEY (`productID`) REFERENCES `product` (`productid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='list of the ordered products';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderedproducts`
--

LOCK TABLES `orderedproducts` WRITE;
/*!40000 ALTER TABLE `orderedproducts` DISABLE KEYS */;
INSERT INTO `orderedproducts` VALUES (1,1,5,15),(1,3,10,50),(2,1,10,30),(3,3,20,100),(4,2,10,30),(5,2,10,30);
/*!40000 ALTER TABLE `orderedproducts` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-27 15:22:54
