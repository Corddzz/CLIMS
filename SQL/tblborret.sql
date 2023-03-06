-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 18, 2023 at 04:57 PM
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
  `GRADECOURSE` varchar(150) NOT NULL,
  `YEARSECTION` varchar(150) NOT NULL,
  `DEPARTMENT` varchar(150) NOT NULL,
  `SCHOOLYEAR` varchar(150) NOT NULL,
  `SEMESTER` varchar(150) NOT NULL,
  `DATE` varchar(15) NOT NULL,
  `TIME` varchar(15) NOT NULL,
  `TYPE` varchar(150) NOT NULL,
  `ITEMNAME` varchar(150) NOT NULL,
  `CONDITIONOFITEM` varchar(150) NOT NULL,
  `SERIALNUMBER` varchar(150) NOT NULL,
  `DESCRIPTION` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblborret`
--

INSERT INTO `tblborret` (`CONTROLNUMBER`, `FIRSTNAME`, `LASTNAME`, `GRADECOURSE`, `YEARSECTION`, `DEPARTMENT`, `SCHOOLYEAR`, `SEMESTER`, `DATE`, `TIME`, `TYPE`, `ITEMNAME`, `CONDITIONOFITEM`, `SERIALNUMBER`, `DESCRIPTION`) VALUES
('1000', 'weewr', 'dsdsds', 'Grade 11', '2nd Year', 'Senior High School', '2022-2023', 'First', '01/16/2023', '03:07:21 PM', 'Borrow', 'adadsads', 'Good', 'dfsfds212', 'dfgsdfgsdfgsdfgsdfgs'),
('1000', 'saddsa', 'adsdas', 'Grade 9', '3rd Year', 'Senior High School', '64545', 'Second', '01/16/2023', '03:07:53 PM', 'Return', 'efr4wft', 'Like New', 'wf3', 'fsddsdfs'),
('1000', 'sdsa', 'dsad', 'Grade 9', '4th Year', 'High School', '21212', 'Second', '01/16/2023', '03:14:27 PM', 'Borrow', 'eqweqw', 'Good', 'ras32', 'ad22221'),
('CAT001', 'Juan ', 'Dela Cruz', 'Grade 2', '2nd Year', 'Faculty & Staff', '2021-2022', 'Second', '01/17/2023', '12:34:18 PM', 'Return', 'Codes', 'Like New', 'fffff3', 'aaaaa'),
('CAT002', 'wewe', 'q', 'Grade 4', '2nd Year', 'High School', 'e22', 'Second', '01/17/2023', '12:34:41 PM', 'Return', 'wefwef', 'Fair', 'efwef', 'fefe33'),
('ID003', '', '', '', '', '', '', '', '01/17/2023', '12:45:55 PM', '', '', '', '', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
