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
-- Table structure for table `reader_info`
--

DROP TABLE IF EXISTS `reader_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reader_info` (
  `Rid` int NOT NULL AUTO_INCREMENT,
  `Rname` varchar(30) DEFAULT NULL,
  `age` int DEFAULT NULL,
  `sex` int DEFAULT NULL,
  `borrowNum` int DEFAULT NULL,
  `againstTime` int DEFAULT NULL,
  `telephone` varchar(12) DEFAULT NULL,
  `islost` int DEFAULT NULL,
  `text` text,
  `lastTime` date DEFAULT NULL,
  `Time` date DEFAULT NULL,
  `Typeid` int DEFAULT NULL,
  PRIMARY KEY (`Rid`),
  UNIQUE KEY `Unix2` (`Rid`),
  KEY `Unix3` (`Typeid`),
  KEY `Unix1` (`Rname`,`telephone`),
  CONSTRAINT `FK1` FOREIGN KEY (`Typeid`) REFERENCES `readertype_info` (`Typeid`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reader_info`
--

LOCK TABLES `reader_info` WRITE;
/*!40000 ALTER TABLE `reader_info` DISABLE KEYS */;
INSERT INTO `reader_info` VALUES (1,'张三',22,1,10,2,'13042345678',0,NULL,NULL,'2022-12-21',2),(2,'李四',21,1,0,4,'13042567889',1,NULL,NULL,'2004-11-20',1),(3,'王五',33,1,0,1,'12053344551',0,NULL,NULL,'2005-09-09',1),(4,'李克',60,0,0,0,'1903344559',0,NULL,NULL,'2011-07-16',2),(5,'沈静',19,0,0,0,'13041122334',0,NULL,NULL,NULL,2),(9,'诸葛一',23,1,0,0,'12340898978',0,NULL,NULL,'2022-12-21',1),(13,'李丽',22,1,0,0,'13032255774',0,NULL,NULL,'2022-12-14',2);
/*!40000 ALTER TABLE `reader_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-01 10:13:24
