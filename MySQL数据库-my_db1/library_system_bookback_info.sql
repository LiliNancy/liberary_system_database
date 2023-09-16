-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: library_system
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bookback_info`
--

DROP TABLE IF EXISTS `bookback_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bookback_info` (
  `Backid` int NOT NULL AUTO_INCREMENT,
  `backtime` date DEFAULT NULL,
  `Bid` int DEFAULT NULL,
  `Rid` int DEFAULT NULL,
  `Cid` int DEFAULT NULL,
  PRIMARY KEY (`Backid`),
  KEY `FK9` (`Rid`),
  KEY `FK11` (`Cid`),
  KEY `FK10` (`Bid`),
  CONSTRAINT `FK10` FOREIGN KEY (`Bid`) REFERENCES `book_info` (`bid`),
  CONSTRAINT `FK11` FOREIGN KEY (`Cid`) REFERENCES `controller_info` (`Cid`),
  CONSTRAINT `FK9` FOREIGN KEY (`Rid`) REFERENCES `reader_info` (`Rid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bookback_info`
--

LOCK TABLES `bookback_info` WRITE;
/*!40000 ALTER TABLE `bookback_info` DISABLE KEYS */;
INSERT INTO `bookback_info` VALUES (1,'2022-11-20',1,1,1),(2,'2020-08-08',4,2,1),(4,'2021-02-02',1,1,1),(5,'2022-12-14',4,3,1),(6,'2022-12-14',4,3,1),(7,'2022-12-21',2,3,1),(8,'2022-12-21',2,3,1);
/*!40000 ALTER TABLE `bookback_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-01 10:13:23
