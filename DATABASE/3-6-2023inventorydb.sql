-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 06, 2023 at 08:28 AM
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
-- Table structure for table `tblborret_details`
--

CREATE TABLE `tblborret_details` (
  `ID` int(11) NOT NULL,
  `ITEMID` int(11) NOT NULL,
  `NAME` text NOT NULL,
  `ITEMTYPE` varchar(50) NOT NULL,
  `LOCATION` varchar(50) NOT NULL,
  `QUANTITY` varchar(50) NOT NULL,
  `REMARKS` varchar(50) NOT NULL,
  `STATUS` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblborrow`
--

CREATE TABLE `tblborrow` (
  `ITEM` varchar(255) NOT NULL,
  `ID` varchar(255) NOT NULL,
  `QUANTITY` varchar(255) NOT NULL,
  `LOCATION` varchar(255) NOT NULL,
  `CLIENT` varchar(255) NOT NULL,
  `FIRSTNAME` varchar(255) NOT NULL,
  `LASTNAME` varchar(255) NOT NULL,
  `DEPARTMENT` varchar(255) NOT NULL,
  `DATE` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblborrow`
--

INSERT INTO `tblborrow` (`ITEM`, `ID`, `QUANTITY`, `LOCATION`, `CLIENT`, `FIRSTNAME`, `LASTNAME`, `DEPARTMENT`, `DATE`) VALUES
('Mouse', 'ID001', '50', 'Tech Office', 'Student', 'Juan', 'Dela Cruz', 'Senior High School', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblcominv`
--

CREATE TABLE `tblcominv` (
  `ID` int(11) NOT NULL,
  `COMPUTERNAME` varchar(50) NOT NULL,
  `DATEADDED` varchar(50) NOT NULL,
  `OPERATINGSYSTEM` varchar(50) NOT NULL,
  `RAM` varchar(50) NOT NULL,
  `PROCESSOR` varchar(50) NOT NULL,
  `LOCATION` varchar(50) NOT NULL,
  `STATUS` varchar(50) NOT NULL,
  `DESCRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblcominv`
--

INSERT INTO `tblcominv` (`ID`, `COMPUTERNAME`, `DATEADDED`, `OPERATINGSYSTEM`, `RAM`, `PROCESSOR`, `LOCATION`, `STATUS`, `DESCRIPTION`) VALUES
(0, 'ComLab1PC1', '2/23/2023', 'Windows 11', '8GB', 'IntelCorei3', 'Computer Laboratory 1', 'In Use', 'N/A'),
(0, 'ComLab2PC1', '2/23/2023', 'Windows 11', '8GB', 'IntelCorei3', 'Computer Laboratory 2', 'Good', 'NA'),
(0, 'ComLab3PC1', '02/23/2023', 'Windows 10', '4GB', 'IntelCorei3', 'Computer Lab 3', 'In Use', 'N/A'),
(0, 'Tech Office', '02/23/2023', 'Windows 11', '8GB', 'IntelCorei5', 'Tech Office', 'In Use', 'N/A');

-- --------------------------------------------------------

--
-- Table structure for table `tbldetails`
--

CREATE TABLE `tbldetails` (
  `ID` varchar(255) NOT NULL,
  `ITEM` varchar(255) NOT NULL,
  `QUANTITY` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbldetails`
--

INSERT INTO `tbldetails` (`ID`, `ITEM`, `QUANTITY`) VALUES
('ID001', 'Keyboard', '50'),
('ID002', 'Crimper', '20');

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
  `DATE` varchar(255) NOT NULL,
  `DESCRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblinv`
--

INSERT INTO `tblinv` (`NAME`, `ITEMTYPE`, `CONTROLNUMBER`, `LOCATION`, `QUANTITY`, `DATE`, `DESCRIPTION`) VALUES
('Monitor', 'Equipment', 'ID001', 'Computer Lab 1', 0, '02/01/2023', 'Acer 18in'),
('Keybaord', 'Equipment', 'ID002', 'Computer Lab 2', 40, '02/20/2023', 'N/A'),
('Mouse', 'Equipment', 'ID003', 'Computer Lab 2', 40, '02/20/2023', 'Generic Mouse'),
('Router', 'Equipment', 'ID004', 'Tech Office', 15, '02/20/2023', 'Tplink'),
('Crimper', 'Tools', 'ID005', 'Tech Office', 10, '02/20/2023', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblinventory`
--

CREATE TABLE `tblinventory` (
  `ID` int(11) NOT NULL,
  `CONTROLNUMBER` varchar(50) NOT NULL,
  `ITEM` varchar(50) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  `DATE` varchar(30) NOT NULL,
  `QUANTITY` int(11) NOT NULL,
  `CONDITIONOFITEM` varchar(50) NOT NULL,
  `LOCATION` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblinventory`
--

INSERT INTO `tblinventory` (`ID`, `CONTROLNUMBER`, `ITEM`, `DESCRIPTION`, `DATE`, `QUANTITY`, `CONDITIONOFITEM`, `LOCATION`) VALUES
(3, 'ID1001', 'Computer', 'Dell Alienware Corei7, 32Gb RAM, 1Tb SSD, ', '3/2/2023', 5, 'Good', 'Computer Laboratory 1'),
(4, '', 'PC1', 'Gigabyte A320, 8GB RAM, 512GB SSD', '03/06/2023', 1, 'Good', 'Computer Lab 2');

-- --------------------------------------------------------

--
-- Table structure for table `tblitems`
--

CREATE TABLE `tblitems` (
  `ID` int(11) NOT NULL,
  `NAME` varchar(255) NOT NULL,
  `ITEMTYPE` varchar(255) NOT NULL,
  `CONTROLNUMBER` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblitems`
--

INSERT INTO `tblitems` (`ID`, `NAME`, `ITEMTYPE`, `CONTROLNUMBER`) VALUES
(1000332, 'Crimper', 'Tools', '12220');

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

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `ID` int(11) NOT NULL,
  `FIRSTNAME` varchar(255) NOT NULL,
  `LASTNAME` varchar(255) NOT NULL,
  `USERNAME` varchar(255) NOT NULL,
  `PASSWORD` varchar(255) NOT NULL,
  `ROLE` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`ID`, `FIRSTNAME`, `LASTNAME`, `USERNAME`, `PASSWORD`, `ROLE`) VALUES
(1, 'Leonheil', 'Cordero', 'Admin', '123', 'Administrator'),
(2, 'Juan', 'Dela Cruz', 'Guest', '123', 'Student'),
(3, 'BEA', 'ULGASAN', 'tachien', '123', 'Teacher');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblinventory`
--
ALTER TABLE `tblinventory`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblitems`
--
ALTER TABLE `tblitems`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblinventory`
--
ALTER TABLE `tblinventory`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblitems`
--
ALTER TABLE `tblitems`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1000333;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
