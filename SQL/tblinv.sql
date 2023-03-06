-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 18, 2023 at 04:59 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventorydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblinv`
--

CREATE TABLE `tblinv` (
  `NAME` varchar(255) NOT NULL,
  `ITEMTYPE` varchar(255) NOT NULL,
  `CONTROLNUMBER` varchar(255) NOT NULL,
  `LOCATION` varchar(255) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblinv`
--

INSERT INTO `tblinv` (`NAME`, `ITEMTYPE`, `CONTROLNUMBER`, `LOCATION`, `QUANTITY`, `DESCRIPTION`) VALUES
('asas', 'Tools', '0001', 'Genyo Lab', 344, 'fddf'),
('re', 'Equipment', '0001', 'Computer Lab 3', 0, 'df4'),
('a', 'Tools', '0001', 'Genyo Lab', 2, 'ewrda'),
('ada', 'Equipment', 'ID002', 'Genyo Lab', 23, '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
