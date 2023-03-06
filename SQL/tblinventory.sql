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
-- Table structure for table `tblinventory`
--

CREATE TABLE `tblinventory` (
  `PRODUCTID` varchar(50) NOT NULL,
  `ITEMNUMBER` varchar(50) NOT NULL,
  `ITEMNAME` varchar(50) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `DATEADDED` varchar(50) NOT NULL,
  `DESCRIPTION` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblinventory`
--

INSERT INTO `tblinventory` (`PRODUCTID`, `ITEMNUMBER`, `ITEMNAME`, `QUANTITY`, `DATEADDED`, `DESCRIPTION`) VALUES
('adsads', 'qweeqwa', 'asd', 1, '11/07/2022', 'dasdasc'),
('dfsdsfs', 'sdsf', 'sdf', 2, '11/07/2022', 'wefef'),
('rewrew', 'werwer', '3242r23re', 43, '11/09/2000', 'rvewcwerwec'),
('asd', 'asdaad', 'ad', 1, '01/11/2023', 'sdasd');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
