-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 20, 2021 at 10:22 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `finalscript`
--

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `DeptID` int(11) NOT NULL,
  `DeptName` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`DeptID`, `DeptName`) VALUES
(9, 'Finance'),
(10, 'Marketing'),
(12, 'Logistics'),
(13, 'HR'),
(15, 'Customer Care');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `ID` int(11) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `birthDate` date NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `DepartmentName` varchar(50) NOT NULL,
  `HireDate` date NOT NULL,
  `EndDate` date DEFAULT NULL,
  `Salary` int(100) NOT NULL,
  `Adress` varchar(100) NOT NULL,
  `Role` varchar(50) NOT NULL,
  `MorningPreference` tinyint(1) NOT NULL,
  `AfternoonPreference` tinyint(1) NOT NULL,
  `EveningPreference` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`ID`, `FirstName`, `LastName`, `birthDate`, `Gender`, `DepartmentName`, `HireDate`, `EndDate`, `Salary`, `Adress`, `Role`, `MorningPreference`, `AfternoonPreference`, `EveningPreference`) VALUES
(1, 'MARY', 'JOSEPH', '2018-06-13', 'Male', 'Customer Care', '2020-09-30', NULL, 5200, 'XSE', 'Admin', 1, 1, 0),
(2, 'DAVID', 'JOSEPH', '2018-06-13', 'Male', 'Logistics', '2020-08-10', NULL, 5200, 'XDE', 'Employee', 0, 0, 0),
(7, 'DAV', 'CATE', '2018-06-13', 'Male', 'Customer Care', '2020-08-10', NULL, 5000, 'XTR', 'Employee', 0, 0, 0),
(10, 'DAVEWW', 'cater', '2018-06-13', ' Male', 'Logistics', '2020-08-10', NULL, 5000, 'XTRRWE', 'Manager', 0, 0, 0),
(11, 'NewLogintest', 'ggwp', '2018-06-13', 'Male', 'Marketing', '2020-10-02', NULL, 2000, 'Home', 'Admin', 0, 0, 0),
(12, 'LoginCredtest', 'IDC', '2018-06-13', 'Male', 'Logistics', '2020-10-02', NULL, 2, 'home', 'Admin', 0, 0, 0),
(13, 'Test', 'Test', '2018-06-13', 'Test', 'Logistics', '2020-10-05', NULL, 20, 'Test', 'Employee', 0, 0, 0),
(18, 'Lola', 'Perez', '2017-06-01', 'Female', 'Marketing', '2020-10-03', NULL, 9000, 'Capucijn 98', 'Employee', 1, 1, 0),
(19, 'Martin', 'Lopez', '2018-06-13', 'Male', 'Marketing', '2020-10-03', NULL, 3000, 'Concordia 45', 'Employee', 0, 0, 0),
(69, 'John', 'Kennedy', '2018-06-13', 'Male', 'Marketing', '2020-10-08', NULL, 60000, 'Washington Av 98', 'Admin', 0, 0, 0),
(200, 'john', 'greg', '2018-06-13', 'Male', 'Marketing', '2020-10-05', NULL, 200, 'Eindhoven', 'Manager', 0, 0, 0),
(1962, 'Sebastian', 'Grandez', '2018-06-13', 'Male', 'Marketing', '2020-10-03', NULL, 10000, 'Rosee 98', 'Admin', 0, 0, 0),
(1963, 'CATE', 'WARU', '2018-06-13', 'Female', 'Finance', '2020-09-30', '2020-11-13', 23444, 'FGR', 'Employee', 0, 0, 0),
(1964, 'Mike', 'Pence', '2018-06-13', 'Male', 'Customer Care', '2020-10-07', NULL, 3455, 'STATE', 'Employee', 0, 0, 0),
(1965, 'Yuri', 'Wolf', '2018-06-13', 'Male', 'Finance', '2020-10-08', NULL, 60000, 'SunnyAvenue 54', 'Manager', 0, 0, 0),
(1966, 'Ronald', 'McDonald', '2018-06-13', 'Male', 'Marketing', '2020-10-08', NULL, 100000, 'Mcdonald45', 'Employee', 0, 0, 0),
(1967, 'Larry', 'King', '2018-06-13', 'Male', 'Marketing', '2020-10-08', NULL, 50000, 'SaveStreet6', 'Manager', 0, 0, 0),
(1968, 'Casey', 'Neistat', '2018-06-13', 'Male', 'Engineering', '2020-10-08', NULL, 100000, 'California1', 'Manager', 0, 0, 0),
(1969, 'gfes', 'gersg', '2000-01-23', 'Male', 'Finance', '2020-10-08', NULL, 1243, 'saef', 'Employee', 0, 0, 0),
(1970, 'hugebruhmoment', 'awd', '2018-06-13', 'Female', 'Customer Care', '2020-10-08', NULL, 123, 'wad', 'Employee', 0, 0, 0),
(1971, 'yeah', 'yeah', '2018-06-13', 'Male', 'Finance', '2020-10-08', NULL, 20, 'home', 'Manager', 0, 0, 0),
(1972, 'LoginMoment', 'yeah', '2018-06-13', 'Male', 'Logistics', '2020-10-08', NULL, 217843, 'home', 'Manager', 0, 0, 0),
(1973, 'pleasework', 'please', '2000-01-23', 'Male', 'Logistics', '2020-10-08', NULL, 1203, 'i beg....', 'Admin', 0, 0, 0),
(1974, 'DAVID', 'CATE', '2018-06-13', 'Male', 'Engineering', '2020-08-10', NULL, 5000, 'XTR', 'Employee', 0, 0, 0),
(1975, 'CATE', 'WARU', '2018-06-13', 'Female', 'Finance', '2020-09-30', NULL, 23444, 'FGR', 'Employee', 0, 0, 0),
(1977, 'pleasework', 'nice.', '2000-01-23', 'Male', 'Logistics', '2020-10-08', NULL, 1203, 'i beg....', 'Admin', 0, 0, 0),
(1978, 'yeahe', 'yeahewq', '2018-06-13', 'Female', 'Logistics', '2020-10-09', NULL, 2, 'for real', 'Employee', 0, 0, 0),
(1979, 'Demo', 'Jack', '2018-06-13', 'Male', 'Logistics', '2020-10-09', NULL, 200, 'Home', 'Employee', 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `empId` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `newUser` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`empId`, `username`, `password`, `newUser`) VALUES
(10, 'davewww', '1610838743CC90E3E4FDDA748282D9B8', 0),
(1, 'maryjo', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(1, 'maryjo', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(11, 'LoginCredtest1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(12, 'LoginCredtest1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(18, 'Lola1', 'E0AA021E21DDDBD6D8CECEC71E9CF564', 0),
(1962, 'Sebastian1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(19, 'Martin1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(13, 'Test1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(200, 'john1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(7, 'usernamebruh', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(1973, 'pleasework1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(1974, 'DAVID1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(1975, 'CATE1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(1977, 'pleasework1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(1978, 'yeahe1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(1979, 'Demo1', '0DAAFEE45FC7A606186954810D8EE59D', 0),
(1963, 'cate123', '0DAAFEE45FC7A606186954810D8EE59D', 0);

-- --------------------------------------------------------

--
-- Table structure for table `request`
--

CREATE TABLE `request` (
  `RequestID` int(11) NOT NULL,
  `Request` varchar(255) NOT NULL,
  `RequestStatus` varchar(10) DEFAULT NULL,
  `prodName` varchar(50) NOT NULL,
  `EmployeeID` int(11) DEFAULT NULL,
  `DepartmentID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `request`
--

INSERT INTO `request` (`RequestID`, `Request`, `RequestStatus`, `prodName`, `EmployeeID`, `DepartmentID`) VALUES
(24, 'Restock', 'Done', 'Razor Mouses', NULL, NULL),
(25, 'Restock', 'Done', 'Asus', NULL, NULL),
(26, 'Restock', 'Done', 'Asus', NULL, NULL),
(27, 'Restock', 'Done', 'Lenovo300', NULL, NULL),
(28, 'Restock', NULL, 'zoom', NULL, NULL),
(29, 'Restock', 'Done', 'zoom', NULL, NULL),
(30, 'Restock', 'Done', 'zoom', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `EmployeeID` int(11) NOT NULL,
  `TimeOfDay` varchar(10) NOT NULL,
  `Day` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) NOT NULL,
  `ProductPrice` int(10) NOT NULL,
  `Brand` varchar(100) NOT NULL,
  `Quantity` int(5) NOT NULL,
  `MinimumQuantity` int(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`ProductID`, `ProductName`, `ProductPrice`, `Brand`, `Quantity`, `MinimumQuantity`) VALUES
(11, 'Lenovo30', 600, 'Lenovo', 100, 23),
(100, 'Razor9000', 500, 'ASUS', 20, 100),
(103, 'Asus wireless', 15, 'ASUS', 100, 99),
(120, 'what', 200, 'Minu', 243, 0),
(130, 'Juatt', 200, 'Lein', 40, 0),
(131, 'whattt', 200, 'Lein', 40, 0),
(132, 'Sup', 400, 'Juat', 50, 0),
(133, 'Sup', 400, 'Juat', 20, 0),
(134, 'Tu', 34, 'TYU', 45, 0),
(135, 'What', 500, 'STY', 45, 0),
(206, 'Razor200', 400, 'Acer', 5, 100);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`DeptID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD KEY `empId` (`empId`);

--
-- Indexes for table `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`RequestID`),
  ADD KEY `EmployeeID` (`EmployeeID`),
  ADD KEY `DepartmentID` (`DepartmentID`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD KEY `EmployeeID` (`EmployeeID`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`ProductID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `departments`
--
ALTER TABLE `departments`
  MODIFY `DeptID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2000;

--
-- AUTO_INCREMENT for table `request`
--
ALTER TABLE `request`
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=210;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `login_ibfk_1` FOREIGN KEY (`empId`) REFERENCES `employee` (`ID`);

--
-- Constraints for table `request`
--
ALTER TABLE `request`
  ADD CONSTRAINT `request_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`ID`),
  ADD CONSTRAINT `request_ibfk_2` FOREIGN KEY (`DepartmentID`) REFERENCES `departments` (`DeptID`);

--
-- Constraints for table `schedule`
--
ALTER TABLE `schedule`
  ADD CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
