-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 06, 2024 at 10:29 AM
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
-- Database: `db_crud`
--

-- --------------------------------------------------------

--
-- Table structure for table `dokter`
--

CREATE TABLE `dokter` (
  `ID` varchar(20) NOT NULL,
  `NAMA` varchar(50) NOT NULL,
  `ALAMAT` varchar(50) NOT NULL,
  `TELP` varchar(20) NOT NULL,
  `SPESIALIS` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dokter`
--

INSERT INTO `dokter` (`ID`, `NAMA`, `ALAMAT`, `TELP`, `SPESIALIS`) VALUES
('001', 'Rasya Radja ', 'Jl. Birmingham', '08120820890', 'Neurologist'),
('002', 'Luslec', 'Jl. Liverpool', '5555555', 'Orthopedic'),
('003', 'Traumerei', 'Jl. Sunderland', '6666666', 'Cardiologist'),
('004', 'Viole', 'Jl. Cypress', '444444', 'Dermatologist'),
('005', 'Aegon', 'Jl. Grove', '777777', 'Radiologist');

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `ID` varchar(20) NOT NULL,
  `NAMA` varchar(50) NOT NULL,
  `ALAMAT` varchar(50) NOT NULL,
  `TELP` varchar(20) NOT NULL,
  `EMAIL` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`ID`, `NAMA`, `ALAMAT`, `TELP`, `EMAIL`) VALUES
('0001', 'Arush', 'Jl. La Fuerta', '111333', 'arush@gmail.com'),
('0002', 'Harry', 'Jl. Grove', '222222', 'harry@gmail.com'),
('0003', 'Vito Corleone', 'Jl. Vinewood', '333333', 'vito@gmail.com'),
('0004', 'Jack Ketteman', 'Jl. Zancudo', '444444', 'jack@gmail.com'),
('0005', 'Jose', 'Jl. Sandy', '555555', 'jose@gmail.com'),
('0006', 'Trevor', 'Jl. Senora', '77777', 'trevor@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_users`
--

CREATE TABLE `tbl_users` (
  `userid` varchar(20) NOT NULL,
  `username` varchar(50) NOT NULL,
  `userpwd` varchar(50) NOT NULL,
  `userlevel` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`userid`, `username`, `userpwd`, `userlevel`) VALUES
('ADMIN', 'ADMIN', 'ADMIN', 'ADMIN'),
('USER', 'USER', 'USER', 'USER');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dokter`
--
ALTER TABLE `dokter`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_users`
--
ALTER TABLE `tbl_users`
  ADD PRIMARY KEY (`userid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
