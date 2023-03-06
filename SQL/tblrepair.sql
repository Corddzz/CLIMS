-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 18, 2023 at 05:00 PM
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
-- Table structure for table `tblrepair`
--

CREATE TABLE `tblrepair` (
  `CONTROLNUMBER` int(11) NOT NULL,
  `NAME` varchar(255) NOT NULL,
  `DEPARTMENT` varchar(255) NOT NULL,
  `DATEFILED` varchar(255) NOT NULL,
  `DESCRIPTION` varchar(200) NOT NULL,
  `PRIORITYCLASS` varchar(255) NOT NULL,
  `CONFIRMEDDATE` varchar(255) NOT NULL,
  `REMARKS` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblrepair`
--

INSERT INTO `tblrepair` (`CONTROLNUMBER`, `NAME`, `DEPARTMENT`, `DATEFILED`, `DESCRIPTION`, `PRIORITYCLASS`, `CONFIRMEDDATE`, `REMARKS`) VALUES
(1, 'Juan', 'sss', '2023-01-17', 'ewefefe', 'Urgent', '2023-01-17', 'sdfdsfds'),
(0, 'fasdfsdaf', 'dsghhrtrt', '01/17/2023', 'sdfsdf3', 'For Approval & Schedule', '01/17/2023', 'eheeha');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
