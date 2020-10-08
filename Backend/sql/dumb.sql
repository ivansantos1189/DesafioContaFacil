-- MySQL dump 10.13  Distrib 5.6.23, for linux-glibc2.5 (x86_64)
--
-- Host: mysql06-farm76.kinghost.net    Database: letsdale
-- ------------------------------------------------------
-- Server version	5.6.36-log
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `AspNetRoleClaims`
--

DROP TABLE IF EXISTS `AspNetRoleClaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `AspNetRoleClaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4,
  `ClaimValue` longtext CHARACTER SET utf8mb4,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetRoleClaims`
--

LOCK TABLES `AspNetRoleClaims` WRITE;
/*!40000 ALTER TABLE `AspNetRoleClaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetRoleClaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetRoles`
--

DROP TABLE IF EXISTS `AspNetRoles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `AspNetRoles` (
  `Id` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `Name` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedName` varchar(127) CHARACTER SET utf8mb4 DEFAULT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetRoles`
--

LOCK TABLES `AspNetRoles` WRITE;
/*!40000 ALTER TABLE `AspNetRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUserClaims`
--

DROP TABLE IF EXISTS `AspNetUserClaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `AspNetUserClaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4,
  `ClaimValue` longtext CHARACTER SET utf8mb4,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUserClaims`
--

LOCK TABLES `AspNetUserClaims` WRITE;
/*!40000 ALTER TABLE `AspNetUserClaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserClaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUserLogins`
--

DROP TABLE IF EXISTS `AspNetUserLogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `ProviderKey` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `ProviderDisplayName` longtext CHARACTER SET utf8mb4,
  `UserId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUserLogins`
--

LOCK TABLES `AspNetUserLogins` WRITE;
/*!40000 ALTER TABLE `AspNetUserLogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserLogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUserRoles`
--

DROP TABLE IF EXISTS `AspNetUserRoles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `AspNetUserRoles` (
  `UserId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `RoleId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUserRoles`
--

LOCK TABLES `AspNetUserRoles` WRITE;
/*!40000 ALTER TABLE `AspNetUserRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUserTokens`
--

DROP TABLE IF EXISTS `AspNetUserTokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `LoginProvider` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `Name` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUserTokens`
--

LOCK TABLES `AspNetUserTokens` WRITE;
/*!40000 ALTER TABLE `AspNetUserTokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserTokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUsers`
--

DROP TABLE IF EXISTS `AspNetUsers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `AspNetUsers` (
  `Id` varchar(127) CHARACTER SET utf8mb4 NOT NULL,
  `UserName` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Email` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext CHARACTER SET utf8mb4,
  `SecurityStamp` longtext CHARACTER SET utf8mb4,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4,
  `PhoneNumber` longtext CHARACTER SET utf8mb4,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `EmailIndex` (`NormalizedEmail`(191))
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUsers`
--

LOCK TABLES `AspNetUsers` WRITE;
/*!40000 ALTER TABLE `AspNetUsers` DISABLE KEYS */;
INSERT INTO `AspNetUsers` VALUES ('1472d62d-3f72-4016-8f49-5985ca90871d','niag.souza19rtyrt93@hotmail.com','NIAG.SOUZA19RTYRT93@HOTMAIL.COM','niag.souza19rtyrt93@hotmail.com','NIAG.SOUZA19RTYRT93@HOTMAIL.COM',1,'AQAAAAEAACcQAAAAELMiuxTODve8P4hQHDNGl4rzuFKvYzoS1U4iGwvOL+tJ2zqEt/FjRfGR7dk6GBsZ7A==','FQJZ66LIV4A4HLRP2MEMUXWYCIXEYLV4','761cbc87-746a-4d01-9404-c6cfeaf81a73',NULL,0,0,NULL,1,0),('21986d8c-5749-4624-926f-02a86a39a176','niag.souza1993@hotmail.com','NIAG.SOUZA1993@HOTMAIL.COM','niag.souza1993@hotmail.com','NIAG.SOUZA1993@HOTMAIL.COM',1,'AQAAAAEAACcQAAAAEIks936ptcVtfF9hBl5ZWyOWrmCYRgt3DHUlG0G2hK0Ur+/mFQeY41vxMC3jConPVA==','D5SOPUTLB7REHF3Q6K2U27QEYTM4TGSS','2a63accd-fed4-4ddc-bf29-a5db931f44d6',NULL,0,0,NULL,1,0),('70813749-8bc5-4f30-be72-d2e962e1ddcb','ivan.cunha@contafacil.com','IVAN.CUNHA@CONTAFACIL.COM','ivan.cunha@contafacil.com','IVAN.CUNHA@CONTAFACIL.COM',1,'AQAAAAEAACcQAAAAED8iEMclYtwK+GzO3f6tJ00AV6ymHhYKbz+IWsTKqA5XpxwyiaClvziQHa/LZgaSzA==','Q6GNAV32JK4L2RLNEWGBWFTNHEI5WYMV','f76be2da-3e2e-438e-bdfa-8a786e2a5d28',NULL,0,0,NULL,1,0),('77361d81-f5d7-4e30-b441-7c6524741096','ivan_santos1189@hotmail.com','IVAN_SANTOS1189@HOTMAIL.COM','ivan_santos1189@hotmail.com','IVAN_SANTOS1189@HOTMAIL.COM',1,'AQAAAAEAACcQAAAAEGp/qO6vJ9yMvCFXavn81ERH9kWixZaHuA6hxxXvMciYw++3ZRnuKLS/NODBdjMlFw==','IPD2625QPJN22DTKOL5VCXIQ2EFGQ5FA','4eff266b-eaa6-42cb-b779-f41881718fc7',NULL,0,0,'2020-10-05 01:33:36.351200',1,0),('9d13fcf2-09eb-49f7-b373-822ee74999bc','ivan_santos1897897189@hotmail.com','IVAN_SANTOS1897897189@HOTMAIL.COM','ivan_santos1897897189@hotmail.com','IVAN_SANTOS1897897189@HOTMAIL.COM',1,'AQAAAAEAACcQAAAAEEj5rLmHkGO2cZ6e0U54i24Tu2DVXm3K5Dx4vxxAvCQwAwc1LcWY9D6F3D2IjU4+4Q==','XYDOXKVBQAKWTFXCF2FKVXAKSZM6QUNH','2211099e-8de4-4372-a147-be5fc05dc16d',NULL,0,0,NULL,1,0),('a35b9224-2488-48b9-96ba-7fc74e98a833','ivan.cunha@contafacil.com.br','IVAN.CUNHA@CONTAFACIL.COM.BR','ivan.cunha@contafacil.com.br','IVAN.CUNHA@CONTAFACIL.COM.BR',1,'AQAAAAEAACcQAAAAEKDqQEBU0lO1ukRquK1w0NBc0jW6c8Xr9O/gjMwBuTuSbdJS0WilF7YTzKcWw3pcFQ==','47SCAK75GA4NQ4G4AGRJKK2CMDNDA5FJ','9a9410dd-db2c-469a-aeb5-a7e7e1f67b4c',NULL,0,0,NULL,1,0),('c0dd818e-e3fc-45b8-ab48-cb9a0cde964b','niag.souza0991993@hotmail.com','NIAG.SOUZA0991993@HOTMAIL.COM','niag.souza0991993@hotmail.com','NIAG.SOUZA0991993@HOTMAIL.COM',1,'AQAAAAEAACcQAAAAEBX1LhzL9i0L0cREw85s+wr/1AvZz7MH4aIyUZY8xF6O54qojLaVMpi3UHodOelvMQ==','5P3R6F3JQUDINOAMBNNKDQOZ2SDYCZL7','6a7f3728-7cac-4b01-b36d-dbce21e74c3a',NULL,0,0,NULL,1,0),('e0a4b7a1-9ab7-48b4-8359-a1cdaeee7629','ivan.cunha@gmail.com','IVAN.CUNHA@GMAIL.COM','ivan.cunha@gmail.com','IVAN.CUNHA@GMAIL.COM',1,'AQAAAAEAACcQAAAAEI4UNY0T50Xx4xQtv0RIIK6HotDaRCn8efdk7Kf8Mf0tMqcTb6VOMDsH2+8vgu9maw==','LW6TM3JN6QW76LLWZA43SXORS7I3MSSH','6caedf06-2f7a-49f3-8e12-57d13e244001',NULL,0,0,NULL,1,0);
/*!40000 ALTER TABLE `AspNetUsers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `CurrentAccounts`
--

DROP TABLE IF EXISTS `CurrentAccounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `CurrentAccounts` (
  `Id` char(36) NOT NULL,
  `AccountNumber` int(11) NOT NULL,
  `CustomerId` char(36) NOT NULL,
  `CurrentBalance` decimal(65,30) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CurrentAccounts`
--

LOCK TABLES `CurrentAccounts` WRITE;
/*!40000 ALTER TABLE `CurrentAccounts` DISABLE KEYS */;
INSERT INTO `CurrentAccounts` VALUES ('0e3e6bdf-1d8e-4fc5-b074-e69871917c41',981834,'c0dd818e-e3fc-45b8-ab48-cb9a0cde964b',0.000000000000000000000000000000),('1dc3885d-ef1e-4d7b-802d-235330374306',913325,'e0a4b7a1-9ab7-48b4-8359-a1cdaeee7629',0.000000000000000000000000000000),('5793d599-5fc0-4991-8f99-8e78cd7a8802',950887,'a35b9224-2488-48b9-96ba-7fc74e98a833',0.000000000000000000000000000000),('bb9a1638-88e1-4a24-843c-6a03697c6309',911046,'77361d81-f5d7-4e30-b441-7c6524741096',3.000000000000000000000000000000),('d59e1cc5-9665-48aa-aa19-e533b49912fc',934280,'9d13fcf2-09eb-49f7-b373-822ee74999bc',10.000000000000000000000000000000),('d5ff49dc-2da5-45eb-81a6-f2c620367ad6',992338,'77361d81-f5d7-4e30-b441-7c6524741096',283.000000000000000000000000000000),('ed43ffe3-ac51-44f7-a77e-503d15054fe8',995997,'70813749-8bc5-4f30-be72-d2e962e1ddcb',86.000000000000000000000000000000);
/*!40000 ALTER TABLE `CurrentAccounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Transactions`
--

DROP TABLE IF EXISTS `Transactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Transactions` (
  `Id` char(36) NOT NULL,
  `CurrentAccountId` char(36) NOT NULL,
  `TransactionType` int(11) NOT NULL,
  `Amount` decimal(65,30) NOT NULL,
  `TransactionDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Transactions`
--

LOCK TABLES `Transactions` WRITE;
/*!40000 ALTER TABLE `Transactions` DISABLE KEYS */;
INSERT INTO `Transactions` VALUES ('2c5bc60b-951e-41ab-9158-baaaa48a1a57','d5ff49dc-2da5-45eb-81a6-f2c620367ad6',1,58.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('333b33e7-7c0d-42c5-b714-9efa008fd2a6','ed43ffe3-ac51-44f7-a77e-503d15054fe8',1,256.000000000000000000000000000000,'2020-10-07 23:44:39.960888'),('3ec264c7-b851-4935-86b9-97ba1d9e873f','d5ff49dc-2da5-45eb-81a6-f2c620367ad6',1,200.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('6c1193f1-eac3-403c-aac7-deca7b3dee89','ed43ffe3-ac51-44f7-a77e-503d15054fe8',2,50.000000000000000000000000000000,'2020-10-07 23:46:27.307662'),('8bb89d53-bcc3-4b80-9510-1686751c5559','d5ff49dc-2da5-45eb-81a6-f2c620367ad6',1,25.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('8c6e4219-4cbe-4073-a86a-d0bfced39e1a','d59e1cc5-9665-48aa-aa19-e533b49912fc',1,50.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('9109fff7-f8c5-4c33-aa02-697a64538d3d','ed43ffe3-ac51-44f7-a77e-503d15054fe8',3,50.000000000000000000000000000000,'2020-10-07 23:46:34.493085'),('a224c4e9-544f-4689-b433-05e1cc58fee8','ed43ffe3-ac51-44f7-a77e-503d15054fe8',2,50.000000000000000000000000000000,'2020-10-07 23:46:31.490120'),('a593743d-3e9f-4c53-9240-eebcaf213b30','d59e1cc5-9665-48aa-aa19-e533b49912fc',1,10.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('ae4bc513-30fb-43e5-acc4-f71d298b4a25','bb9a1638-88e1-4a24-843c-6a03697c6309',1,21.000000000000000000000000000000,'2020-10-07 23:36:47.374971'),('b5906d0d-5f6b-4d75-91cb-763c82540aa8','ed43ffe3-ac51-44f7-a77e-503d15054fe8',3,50.000000000000000000000000000000,'2020-10-07 23:44:54.142203'),('b6128144-5438-48e9-9677-e958cc47c983','ed43ffe3-ac51-44f7-a77e-503d15054fe8',3,50.000000000000000000000000000000,'2020-10-07 23:44:48.076877'),('bc193bb2-582b-478f-af8a-2175342c1597','d5ff49dc-2da5-45eb-81a6-f2c620367ad6',1,25.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('c387f5d4-4dc2-4716-8288-0bb66760b6d8','d5ff49dc-2da5-45eb-81a6-f2c620367ad6',3,50.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('db0b6dc9-d55b-4ca1-98de-6e5c99bd0f13','ed43ffe3-ac51-44f7-a77e-503d15054fe8',1,50.000000000000000000000000000000,'2020-10-07 23:44:35.458497'),('e19c0096-05b3-4828-ae32-0f1f1b1f5518','ed43ffe3-ac51-44f7-a77e-503d15054fe8',1,30.000000000000000000000000000000,'2020-10-07 23:44:44.095643'),('e48c376c-3b3c-48e9-b412-eb693973c717','d5ff49dc-2da5-45eb-81a6-f2c620367ad6',1,0.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('eabdadd7-9fde-4374-be76-db503d222082','bb9a1638-88e1-4a24-843c-6a03697c6309',1,50.000000000000000000000000000000,'2020-10-07 00:00:00.000000'),('eb7b2b85-c11a-45e2-a7c2-3c8f6770b43a','bb9a1638-88e1-4a24-843c-6a03697c6309',3,68.000000000000000000000000000000,'2020-10-07 23:41:21.025287'),('f139e058-ca9f-403b-b303-a4ebcf2ac031','d5ff49dc-2da5-45eb-81a6-f2c620367ad6',1,25.000000000000000000000000000000,'0001-01-01 00:00:00.000000'),('f368e363-9e3d-49d6-8c1e-7c746228bc42','d59e1cc5-9665-48aa-aa19-e533b49912fc',3,50.000000000000000000000000000000,'0001-01-01 00:00:00.000000');
/*!40000 ALTER TABLE `Transactions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20201002110344_Create Account','3.1.8');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'letsdale'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-07 23:47:34
