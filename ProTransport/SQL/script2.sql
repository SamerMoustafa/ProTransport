-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.21-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win32
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for transport
CREATE DATABASE IF NOT EXISTS `transport` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `transport`;

-- Dumping structure for table transport.banks
CREATE TABLE IF NOT EXISTS `banks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  `Address` varchar(50) NOT NULL DEFAULT '0',
  `Phone` varchar(50) NOT NULL DEFAULT '0',
  `Mail` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Dumping data for table transport.banks: ~1 rows (approximately)
DELETE FROM `banks`;
/*!40000 ALTER TABLE `banks` DISABLE KEYS */;
INSERT INTO `banks` (`Id`, `Name`, `Address`, `Phone`, `Mail`) VALUES
	(1, 'QNB', 'soltan hesen', '2020222', 'sam.el kady@hotmail.com');
/*!40000 ALTER TABLE `banks` ENABLE KEYS */;

-- Dumping structure for table transport.bank_accounts
CREATE TABLE IF NOT EXISTS `bank_accounts` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `BankId` int(11) DEFAULT NULL,
  `Holder` varchar(50) DEFAULT NULL,
  `Le` varchar(50) DEFAULT NULL,
  `Usd` varchar(50) DEFAULT NULL,
  `Euro` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Dumping data for table transport.bank_accounts: ~1 rows (approximately)
DELETE FROM `bank_accounts`;
/*!40000 ALTER TABLE `bank_accounts` DISABLE KEYS */;
INSERT INTO `bank_accounts` (`Id`, `BankId`, `Holder`, `Le`, `Usd`, `Euro`) VALUES
	(1, 0, 's', '2000015656787', '300002828272827', '300008277254435');
/*!40000 ALTER TABLE `bank_accounts` ENABLE KEYS */;

-- Dumping structure for table transport.clients
CREATE TABLE IF NOT EXISTS `clients` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(256) NOT NULL,
  `CompanyPhone` varchar(50) NOT NULL,
  `CompanyMail` varchar(50) NOT NULL,
  `AccountantPhone` varchar(50) NOT NULL,
  `AccountantMail` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Dumping data for table transport.clients: ~1 rows (approximately)
DELETE FROM `clients`;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` (`Id`, `Name`, `Address`, `CompanyPhone`, `CompanyMail`, `AccountantPhone`, `AccountantMail`) VALUES
	(2, 'dsdsds', 'dsd2e', 'sdsdsdfddsdd', 'sdsd', 'sdsdsd', 'ds');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;

-- Dumping structure for table transport.container_types
CREATE TABLE IF NOT EXISTS `container_types` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table transport.container_types: ~0 rows (approximately)
DELETE FROM `container_types`;
/*!40000 ALTER TABLE `container_types` DISABLE KEYS */;
/*!40000 ALTER TABLE `container_types` ENABLE KEYS */;

-- Dumping structure for table transport.destinations
CREATE TABLE IF NOT EXISTS `destinations` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  `address` varchar(50) NOT NULL DEFAULT '0',
  `Type` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Dumping data for table transport.destinations: ~2 rows (approximately)
DELETE FROM `destinations`;
/*!40000 ALTER TABLE `destinations` DISABLE KEYS */;
INSERT INTO `destinations` (`Id`, `Name`, `address`, `Type`) VALUES
	(2, 'ssss', 'ssss', 'sssss'),
	(3, 'hghghgh', '', '');
/*!40000 ALTER TABLE `destinations` ENABLE KEYS */;

-- Dumping structure for table transport.drivers
CREATE TABLE IF NOT EXISTS `drivers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  `Salary` int(11) NOT NULL DEFAULT '0',
  `Phone` varchar(50) NOT NULL DEFAULT '0',
  `Address` varchar(256) NOT NULL,
  `Locked` int(11) NOT NULL DEFAULT '0',
  `FavouriteCar` int(11) NOT NULL DEFAULT '0',
  `IdNo` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Dumping data for table transport.drivers: ~0 rows (approximately)
DELETE FROM `drivers`;
/*!40000 ALTER TABLE `drivers` DISABLE KEYS */;
INSERT INTO `drivers` (`Id`, `Name`, `Salary`, `Phone`, `Address`, `Locked`, `FavouriteCar`, `IdNo`) VALUES
	(3, '', 0, '121212', '', 2323, 0, 'DFDF');
/*!40000 ALTER TABLE `drivers` ENABLE KEYS */;

-- Dumping structure for table transport.shipping_lines
CREATE TABLE IF NOT EXISTS `shipping_lines` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Phone` varchar(50) NOT NULL,
  `Mail` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Dumping data for table transport.shipping_lines: ~3 rows (approximately)
DELETE FROM `shipping_lines`;
/*!40000 ALTER TABLE `shipping_lines` DISABLE KEYS */;
INSERT INTO `shipping_lines` (`Id`, `Name`, `Address`, `Phone`, `Mail`) VALUES
	(1, 'sam', 'sddff', '11222', 'sam.ss2@gmail.com'),
	(2, 'sdasd', 'sdad', 'sdsd', 'ddf');
/*!40000 ALTER TABLE `shipping_lines` ENABLE KEYS */;

-- Dumping structure for table transport.tours
CREATE TABLE IF NOT EXISTS `tours` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ClientId` int(11) NOT NULL,
  `DriverId` int(11) NOT NULL DEFAULT '0',
  `CarId` int(11) NOT NULL DEFAULT '0',
  `ContainersCount` int(11) NOT NULL DEFAULT '0',
  `ContainersType` varchar(50) NOT NULL DEFAULT '0',
  `ShippingLine` int(11) NOT NULL DEFAULT '0',
  `BillNo` varchar(50) NOT NULL DEFAULT '0',
  `BookingNo` varchar(50) NOT NULL DEFAULT '0',
  `DeliverNo` varchar(50) NOT NULL DEFAULT '0',
  `LeavingDate` varchar(50) NOT NULL DEFAULT '0',
  `ArriveDate` varchar(50) NOT NULL DEFAULT '0',
  `State` varchar(50) NOT NULL DEFAULT '0',
  `Branched` int(11) NOT NULL DEFAULT '0',
  `Housing` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table transport.tours: ~0 rows (approximately)
DELETE FROM `tours`;
/*!40000 ALTER TABLE `tours` DISABLE KEYS */;
/*!40000 ALTER TABLE `tours` ENABLE KEYS */;

-- Dumping structure for table transport.tours_lines
CREATE TABLE IF NOT EXISTS `tours_lines` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `From` int(11) DEFAULT '0',
  `to` int(11) DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table transport.tours_lines: ~0 rows (approximately)
DELETE FROM `tours_lines`;
/*!40000 ALTER TABLE `tours_lines` DISABLE KEYS */;
/*!40000 ALTER TABLE `tours_lines` ENABLE KEYS */;

-- Dumping structure for table transport.tours_lines_prices
CREATE TABLE IF NOT EXISTS `tours_lines_prices` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TourLine` int(11) NOT NULL DEFAULT '0',
  `Type` varchar(50) NOT NULL DEFAULT '0',
  `Price` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table transport.tours_lines_prices: ~0 rows (approximately)
DELETE FROM `tours_lines_prices`;
/*!40000 ALTER TABLE `tours_lines_prices` DISABLE KEYS */;
/*!40000 ALTER TABLE `tours_lines_prices` ENABLE KEYS */;

-- Dumping structure for table transport.users
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  `Usename` varchar(50) NOT NULL DEFAULT '0',
  `Paasword` varchar(50) NOT NULL DEFAULT '0',
  `Role` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Dumping data for table transport.users: ~1 rows (approximately)
DELETE FROM `users`;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`Id`, `Name`, `Usename`, `Paasword`, `Role`) VALUES
	(2, 'ss', 'ssss', 'ssss', '');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

-- Dumping structure for table transport.veichles
CREATE TABLE IF NOT EXISTS `veichles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Brand` varchar(50) NOT NULL DEFAULT '0',
  `Type` varchar(50) NOT NULL DEFAULT '0',
  `ChaceeId` varchar(50) NOT NULL DEFAULT '0',
  `PlateId` varchar(50) DEFAULT NULL,
  `GPS_Serial` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Dumping data for table transport.veichles: ~3 rows (approximately)
DELETE FROM `veichles`;
/*!40000 ALTER TABLE `veichles` DISABLE KEYS */;
INSERT INTO `veichles` (`Id`, `Brand`, `Type`, `ChaceeId`, `PlateId`, `GPS_Serial`) VALUES
	(1, 'BMW', 'CAR', '234234', 'o123 dgdh', '123467'),
	(2, 'Chevrolet', 'Car', '232', '5555', '12345654321'),
	(4, 'sdsdsd', 'sdsdsd', '111', '23232', '1212121');
/*!40000 ALTER TABLE `veichles` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
