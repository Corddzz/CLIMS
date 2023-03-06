-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 28, 2023 at 03:35 AM
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
-- Table structure for table `tblborret`
--

CREATE TABLE `tblborret` (
  `CONTROLNUMBER` varchar(255) NOT NULL,
  `FIRSTNAME` varchar(150) NOT NULL,
  `LASTNAME` varchar(150) NOT NULL,
  `DEPARTMENT` varchar(150) NOT NULL,
  `SCHOOLYEAR` varchar(150) NOT NULL,
  `DATE` text NOT NULL,
  `TYPE` varchar(150) NOT NULL,
  `CONDITIONOFITEM` varchar(150) NOT NULL,
  `DESCRIPTION` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblborret`
--

INSERT INTO `tblborret` (`CONTROLNUMBER`, `FIRSTNAME`, `LASTNAME`, `DEPARTMENT`, `SCHOOLYEAR`, `DATE`, `TYPE`, `CONDITIONOFITEM`, `DESCRIPTION`) VALUES
('ID1004', 'Juan', 'Dela Cruz', 'College', '2022-2023', '20/2/2023', 'Borrow', 'Good', 'N/A'),
('ID005', '', '', '', '', '02/20/2023', '', '', ''),
('ID005', '', '', '', '', '02/21/2023', '', '', ''),
('ID005', '', '', '', '', '02/21/2023', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblrepair`
--

CREATE TABLE `tblrepair` (
  `CONTROLNUMBER` varchar(255) NOT NULL,
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
('ID001', 'Leonheil Cordero', 'College', '2-19-2023', 'N/A', 'N/A', 'N/A', 'N/A'),
('#', 'Juan Dela Cruz', 'High School', '02/19/2023', 'Screen no Display', 'Urgent', '02/19/2023', 'NA');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
