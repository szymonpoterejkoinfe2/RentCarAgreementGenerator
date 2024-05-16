-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: carrentaldatabase
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `carbrand`
--

DROP TABLE IF EXISTS `carbrand`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carbrand` (
  `idCarBrand` int NOT NULL AUTO_INCREMENT,
  `CarBrand` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCarBrand`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carbrand`
--

LOCK TABLES `carbrand` WRITE;
/*!40000 ALTER TABLE `carbrand` DISABLE KEYS */;
INSERT INTO `carbrand` VALUES (1,'Toyota'),(2,'Seat'),(3,'Skoda'),(4,'Opel'),(5,'Kia'),(6,'Ford'),(7,'Hyundai'),(8,'Renault'),(9,'Suzuki');
/*!40000 ALTER TABLE `carbrand` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carmodels`
--

DROP TABLE IF EXISTS `carmodels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carmodels` (
  `modelId` int unsigned NOT NULL AUTO_INCREMENT,
  `modelName` varchar(45) NOT NULL,
  `brandId` int NOT NULL,
  PRIMARY KEY (`modelId`),
  UNIQUE KEY `modelid_UNIQUE` (`modelId`),
  UNIQUE KEY `modelName_UNIQUE` (`modelName`),
  KEY `brandid_idx` (`brandId`),
  CONSTRAINT `brandid` FOREIGN KEY (`brandId`) REFERENCES `carbrand` (`idCarBrand`),
  CONSTRAINT `brandIdKey` FOREIGN KEY (`brandId`) REFERENCES `carbrand` (`idCarBrand`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carmodels`
--

LOCK TABLES `carmodels` WRITE;
/*!40000 ALTER TABLE `carmodels` DISABLE KEYS */;
INSERT INTO `carmodels` VALUES (1,'Ibiza',2),(2,'Leon',2),(3,'Aygo',1),(4,'Yaris',1),(5,'Corolla',1),(7,'Fabia',3),(8,'Corsa',4),(9,'Astra',4),(10,'Scala',3),(11,'i30',7),(13,'Ceed',5),(14,'Swift',9),(15,'Arkana',8);
/*!40000 ALTER TABLE `carmodels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cars`
--

DROP TABLE IF EXISTS `cars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cars` (
  `carId` int unsigned NOT NULL AUTO_INCREMENT,
  `brandId` int unsigned NOT NULL,
  `modelId` int unsigned NOT NULL,
  `carRegistration` varchar(45) NOT NULL,
  PRIMARY KEY (`carId`),
  KEY `modelId_idx` (`modelId`),
  CONSTRAINT `modelId` FOREIGN KEY (`modelId`) REFERENCES `carmodels` (`modelId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cars`
--

LOCK TABLES `cars` WRITE;
/*!40000 ALTER TABLE `cars` DISABLE KEYS */;
INSERT INTO `cars` VALUES (5,1,3,'sw 1234f'),(6,2,1,'SK840XU'),(7,2,1,'SK679XV');
/*!40000 ALTER TABLE `cars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservations` (
  `reservationId` int NOT NULL,
  `reservationBeginDate` datetime DEFAULT NULL,
  `reservationEndDate` datetime DEFAULT NULL,
  PRIMARY KEY (`reservationId`),
  UNIQUE KEY `reservationId_UNIQUE` (`reservationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
INSERT INTO `reservations` VALUES (88,'2024-05-16 21:53:37','2024-05-18 21:53:37'),(90,'2024-05-20 21:53:37','2024-05-26 21:53:37'),(77777,'2024-05-16 22:09:42','2024-05-18 22:09:42');
/*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-16 22:23:41
