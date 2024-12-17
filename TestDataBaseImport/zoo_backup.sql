-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: zoo
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `gehege`
--

DROP TABLE IF EXISTS `gehege`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gehege` (
  `GehegeID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `ThemenbereichID` int(11) DEFAULT NULL,
  PRIMARY KEY (`GehegeID`),
  KEY `ThemenbereichID` (`ThemenbereichID`),
  CONSTRAINT `gehege_ibfk_1` FOREIGN KEY (`ThemenbereichID`) REFERENCES `themenbereich` (`ThemenbereichID`)
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gehege`
--

LOCK TABLES `gehege` WRITE;
/*!40000 ALTER TABLE `gehege` DISABLE KEYS */;
INSERT INTO `gehege` VALUES (1,'Löwengehege',16),(2,'Tigeranlage',16),(3,'Elefantenhaus',1),(4,'Giraffen-Savanne',10),(5,'Känguru-Gehege',18),(6,'Pinguin-Paradies',7),(7,'Eisbären-Gehege',7),(8,'Regenwald-Voliere',8),(9,'Schlangenhaus',3),(10,'Krokodil-Teich',3),(11,'Papageien-Voliere',2),(12,'Falken-Flugshow',2),(13,'Fisch-Aquarium',13),(14,'Hai-Becken',13),(15,'Nashorn-Gehege',1),(16,'Affenhaus',15),(17,'Schimpansen-Insel',15),(18,'Fledermaushöhle',14),(19,'Koala-Haus',18),(20,'Wüstentier-Gehege',9),(21,'Kamelfarm',9),(22,'Bisons-Gehege',11),(23,'Alpensteinbock-Gehege',11),(24,'Flusspferd-Gehege',12),(25,'Otter-Gehege',12),(26,'Bauernhoftiere-Gehege',17),(27,'Ziegenstall',17),(28,'Wolf-Gehege',16),(29,'Eulen-Gehege',14),(30,'Insektenpavillon',6),(31,'Schmetterlingshaus',6),(32,'Känguru-Wiese',18),(33,'Antarktis-Station',7),(34,'Tropisches Froschhaus',4),(35,'Schildkröten-Insel',3),(36,'Reh-Gehege',10),(37,'Bärenwald',1),(38,'Nachttierhaus',14),(39,'Tundra-Gehege',19),(40,'Yak-Gehege',19),(41,'Karpfen-Teich',5),(42,'Korallenriff-Becken',13),(43,'Kamelreitstation',9),(44,'Mythologische Tiere-Ausstellung',20),(45,'Drachen-Exhibit',20),(46,'Präriehund-Gehege',1),(47,'Flamingo-Voliere',2),(48,'Ara-Gehege',2),(49,'Nilpferd-Anlage',12);
/*!40000 ALTER TABLE `gehege` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `themenbereich`
--

DROP TABLE IF EXISTS `themenbereich`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `themenbereich` (
  `ThemenbereichID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ThemenbereichID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `themenbereich`
--

LOCK TABLES `themenbereich` WRITE;
/*!40000 ALTER TABLE `themenbereich` DISABLE KEYS */;
INSERT INTO `themenbereich` VALUES (1,'Säugetiere'),(2,'Vögel'),(3,'Reptilien'),(4,'Amphibien'),(5,'Fische'),(6,'Insekten und Spinnen'),(7,'Arktische Tiere'),(8,'Tropische Regenwaldtiere'),(9,'Wüstentiere'),(10,'Savannentiere'),(11,'Bergtiere'),(12,'Tiere der Flusslandschaften'),(13,'Meerestiere und Korallenriffe'),(14,'Nachtaktive Tiere'),(15,'Primaten'),(16,'Raubtiere und Großkatzen'),(17,'Haus- und Nutztiere'),(18,'Australische Tiere (Outback)'),(19,'Tiere der Tundra'),(20,'Mythen und symbolische Tiere');
/*!40000 ALTER TABLE `themenbereich` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tier`
--

DROP TABLE IF EXISTS `tier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tier` (
  `TierID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `GehegeID` int(11) DEFAULT NULL,
  `TierartID` int(11) DEFAULT NULL,
  PRIMARY KEY (`TierID`),
  KEY `GehegeID` (`GehegeID`),
  KEY `TierartID` (`TierartID`),
  CONSTRAINT `tier_ibfk_1` FOREIGN KEY (`GehegeID`) REFERENCES `gehege` (`GehegeID`),
  CONSTRAINT `tier_ibfk_2` FOREIGN KEY (`TierartID`) REFERENCES `tierart` (`TierartID`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tier`
--

LOCK TABLES `tier` WRITE;
/*!40000 ALTER TABLE `tier` DISABLE KEYS */;
INSERT INTO `tier` VALUES (1,'Simba',1,1),(2,'Nala',1,1),(3,'Shere Khan',2,2),(4,'Rajah',2,2),(5,'Dumbo',3,3),(6,'Babar',3,4),(7,'Melman',4,5),(8,'Skippy',5,6),(9,'Matilda',5,7),(10,'Happy Feet',6,8),(11,'Knut',6,9),(12,'Rango',7,10),(13,'Kaa',7,11),(14,'Snappy',7,12),(15,'Rio',8,13),(16,'Falco',8,14),(17,'Willy',9,15),(18,'Bruce',9,16),(19,'Hugo',10,17),(20,'Castor',10,18),(21,'Baloo',3,19),(22,'Cheeta',11,20),(23,'Harambe',11,21),(24,'Po',3,22),(25,'Dracula',12,23),(26,'Hedwig',12,24),(27,'Dolly',13,25),(28,'Shaun',13,26),(29,'Yakkity',14,27),(30,'Ghost',6,28),(31,'Alpenhorn',15,29),(32,'Benny',15,30),(33,'Pinky',8,31),(34,'Seal',6,32),(35,'Varan',7,33),(36,'Jumpy',16,34),(37,'Koi',17,35),(38,'Nemo',18,36),(39,'Flutter',19,37),(40,'Charlotte',19,38),(41,'Sandy',20,39),(42,'Dusty',20,40),(43,'Buddy',4,41),(44,'Lynxie',1,42),(45,'SeaBreeze',9,43),(46,'Spot',15,44),(47,'Rocky',4,45),(48,'Straußie',4,46),(49,'Smaug',16,47),(50,'Phoenix',16,48),(51,'Manta',9,49),(52,'Aquila',8,50),(53,'Ottie',10,51),(54,'Gavialo',10,52);
/*!40000 ALTER TABLE `tier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tierart`
--

DROP TABLE IF EXISTS `tierart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tierart` (
  `TierartID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`TierartID`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tierart`
--

LOCK TABLES `tierart` WRITE;
/*!40000 ALTER TABLE `tierart` DISABLE KEYS */;
INSERT INTO `tierart` VALUES (1,'Afrikanischer Löwe'),(2,'Sibirischer Tiger'),(3,'Asiatischer Elefant'),(4,'Afrikanischer Elefant'),(5,'Giraffe'),(6,'Känguru'),(7,'Koala'),(8,'Kaiser-Pinguin'),(9,'Eisbär'),(10,'Grüner Leguan'),(11,'Königspython'),(12,'Nilkrokodil'),(13,'Papagei Ara'),(14,'Falkenartige'),(15,'Blauwal'),(16,'Weißer Hai'),(17,'Flusspferd'),(18,'Nordamerikanischer Biber'),(19,'Braunbär'),(20,'Schimpanse'),(21,'Gorilla'),(22,'Großer Panda'),(23,'Fledermaus'),(24,'Eule'),(25,'Hausziege'),(26,'Schaf'),(27,'Yak'),(28,'Arktischer Wolf'),(29,'Alpensteinbock'),(30,'Bison'),(31,'Flamingo'),(32,'Antarktischer Seelöwe'),(33,'Komodowaran'),(34,'Tropischer Frosch'),(35,'Karpfen'),(36,'Clownfisch'),(37,'Schmetterling'),(38,'Vogelspinne'),(39,'Kameldromedar'),(40,'Dromedar'),(41,'Präriehund'),(42,'Rotluchs'),(43,'Seepferdchen'),(44,'Schneeleopard'),(45,'Nashorn'),(46,'Strauß'),(47,'Mythologischer Drache'),(48,'Phönix'),(49,'Mantarochen'),(50,'Steinadler'),(51,'Meeresotter'),(52,'Gangesgavial');
/*!40000 ALTER TABLE `tierart` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-17 16:35:41
