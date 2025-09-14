-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 14, 2025 at 06:17 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `atm_simulation`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblaccountbalance`
--

CREATE TABLE `tblaccountbalance` (
  `AccountNumber` varchar(20) NOT NULL,
  `BalanceAmount` decimal(12,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblaccountbalance`
--

INSERT INTO `tblaccountbalance` (`AccountNumber`, `BalanceAmount`) VALUES
('111', 1172821.00),
('123', 31417.00),
('12345', 26233.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaction_history`
--

CREATE TABLE `tbltransaction_history` (
  `transaction_number` int(11) NOT NULL,
  `sender_AccountNumber` int(11) NOT NULL,
  `receiver_AccountNumber` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbluserinfo`
--

CREATE TABLE `tbluserinfo` (
  `AccountNumber` int(11) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `MiddleName` varchar(255) NOT NULL,
  `EmailAddress` varchar(255) NOT NULL,
  `ContactNumber` int(11) NOT NULL,
  `PIN` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluserinfo`
--

INSERT INTO `tbluserinfo` (`AccountNumber`, `FirstName`, `LastName`, `MiddleName`, `EmailAddress`, `ContactNumber`, `PIN`) VALUES
(111, 'Shoyou', 'Lasin', 'Shish', 'sho@gmail.com', 909090909, 111),
(123, 'Jb', 'Lobrico', 'hehe', 'jb@gmail.com', 99999992, 123),
(12345, 'Sean', 'Dope', 'Ty', 'SeanTyDope@gmail.com', 99999992, 123456);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblaccountbalance`
--
ALTER TABLE `tblaccountbalance`
  ADD PRIMARY KEY (`AccountNumber`);

--
-- Indexes for table `tbltransaction_history`
--
ALTER TABLE `tbltransaction_history`
  ADD PRIMARY KEY (`transaction_number`);

--
-- Indexes for table `tbluserinfo`
--
ALTER TABLE `tbluserinfo`
  ADD PRIMARY KEY (`AccountNumber`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
