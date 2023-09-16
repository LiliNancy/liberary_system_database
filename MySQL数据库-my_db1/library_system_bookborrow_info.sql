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
-- Table structure for table `bookborrow_info`
--

DROP TABLE IF EXISTS `bookborrow_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bookborrow_info` (
  `borrowid` int NOT NULL AUTO_INCREMENT,
  `borrowTime` date DEFAULT NULL,
  `lastTime` date DEFAULT NULL,
  `againTime` int DEFAULT NULL,
  `Bid` int DEFAULT NULL,
  `Rid` int DEFAULT NULL,
  `Cid` int DEFAULT NULL,
  PRIMARY KEY (`borrowid`),
  KEY `FK5` (`Rid`),
  KEY `FK7` (`Cid`),
  KEY `FK6` (`Bid`),
  CONSTRAINT `FK5` FOREIGN KEY (`Rid`) REFERENCES `reader_info` (`Rid`),
  CONSTRAINT `FK6` FOREIGN KEY (`Bid`) REFERENCES `book_info` (`bid`),
  CONSTRAINT `FK7` FOREIGN KEY (`Cid`) REFERENCES `controller_info` (`Cid`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bookborrow_info`
--

LOCK TABLES `bookborrow_info` WRITE;
/*!40000 ALTER TABLE `bookborrow_info` DISABLE KEYS */;
INSERT INTO `bookborrow_info` VALUES (1,'2021-10-01','2021-12-01',0,1,1,1),(2,'2020-09-09','2020-11-09',0,2,1,1),(3,'2020-09-09','2020-11-09',0,4,2,1),(4,'2020-11-11','2021-02-10',0,1,1,1),(5,'2022-12-14','2022-03-15',1,1,1,1),(6,'2022-12-14','2023-02-12',0,4,3,1),(7,'2022-12-14','2023-02-12',0,5,3,1),(8,'2022-12-14','2023-02-12',0,4,3,1),(9,'2022-12-21','2023-02-19',0,2,3,1),(10,'2022-12-21','2023-03-21',1,2,3,1);
/*!40000 ALTER TABLE `bookborrow_info` ENABLE KEYS */;
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
