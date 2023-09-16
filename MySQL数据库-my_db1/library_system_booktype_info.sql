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
-- Table structure for table `booktype_info`
--

DROP TABLE IF EXISTS `booktype_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booktype_info` (
  `ISBN` varchar(20) NOT NULL,
  `wid` int DEFAULT NULL,
  `bname` varchar(30) DEFAULT NULL,
  `price` int DEFAULT NULL,
  `kind` varchar(10) DEFAULT NULL,
  `publishTime` date DEFAULT NULL,
  `edition` varchar(10) DEFAULT NULL,
  `pid` int DEFAULT NULL,
  PRIMARY KEY (`ISBN`),
  KEY `FK2` (`wid`),
  KEY `FK3` (`pid`),
  CONSTRAINT `FK2` FOREIGN KEY (`wid`) REFERENCES `writer_info` (`wid`),
  CONSTRAINT `FK3` FOREIGN KEY (`pid`) REFERENCES `press_info` (`pid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booktype_info`
--

LOCK TABLES `booktype_info` WRITE;
/*!40000 ALTER TABLE `booktype_info` DISABLE KEYS */;
INSERT INTO `booktype_info` VALUES ('134-987-098',3,'算法',80,'','2022-12-04','',3),('978-7-111-68181-6',1,'数据库系统概念',149,'计算机/数据库','2020-11-11','第七版',1);
/*!40000 ALTER TABLE `booktype_info` ENABLE KEYS */;
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
