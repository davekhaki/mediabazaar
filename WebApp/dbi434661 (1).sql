-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 06, 2021 at 04:59 PM
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
-- Database: `dbi434661`
--

-- --------------------------------------------------------

--
-- Table structure for table `credentials`
--

CREATE TABLE `credentials` (
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `usertype` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `credentials`
--

INSERT INTO `credentials` (`username`, `password`, `usertype`) VALUES
('admin', 'admin', 'admin'),
('manager', 'manager', 'manager'),
('employee', 'employee', 'employee');

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
(14, 'Customer Care');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `ID` int(11) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Age` int(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `DepartmentName` varchar(50) NOT NULL,
  `HireDate` date NOT NULL,
  `EndDate` date DEFAULT NULL,
  `Salary` int(100) NOT NULL,
  `Adress` varchar(100) NOT NULL,
  `Role` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`ID`, `FirstName`, `LastName`, `Age`, `Gender`, `DepartmentName`, `HireDate`, `EndDate`, `Salary`, `Adress`, `Role`) VALUES
(1, 'MARY', 'JOSEPH', 63, 'Female', 'Logistics', '2020-09-30', '2020-10-02', 5200, 'XSE', 'Admin'),
(2, 'DAVID', 'JOSEPH', 63, 'Male', 'Logistics', '2020-08-10', '2020-10-02', 5200, 'XDE', 'Employee'),
(3, 'Musee', 'Paul', 321, 'Male', '', '2020-03-21', '2020-10-09', 7000, 'DeeUsel', 'Employee'),
(5, 'DAVID', 'CATE', 60, 'Male', 'Engineering', '2020-08-10', '2020-10-02', 5000, 'XTR', 'Employee'),
(7, 'DAV', 'CATE', 60, 'Male', 'Customer Care', '2020-08-10', '2020-10-02', 5000, 'XTR', 'Employee'),
(8, 'DAVE', 'CATER', 60, 'Male', 'Customer Care', '2020-08-10', '2020-10-02', 5000, 'XTRR', 'Employee'),
(9, 'DAVE', 'CATER', 60, 'Male', 'Customer Care', '2020-08-10', '2020-10-02', 5000, 'XTRR', 'Employee'),
(10, 'Dave', 'Manuel', 43, 'Male', 'Logistics', '2020-08-10', '2020-08-05', 5000, 'Something', 'Manager'),
(11, 'NewLogintest', 'ggwp', 12, 'Male', 'Marketing', '2020-10-02', '2020-10-02', 2000, 'Home', 'Admin'),
(12, 'LoginCredtest', 'IDC', 12, 'Male', 'Logistics', '2020-10-02', '2020-10-02', 2, 'home', 'Admin'),
(13, 'Test', 'Test', 56, 'Test', 'Logistics', '2020-10-05', '2020-10-05', 20, 'Test', 'Employee'),
(14, 'QWERTY', 'OIUY', 35, 'MALE', '', '2020-09-15', NULL, 2555, 'CVB', 'Employee'),
(18, 'Lola', 'Perez', 19, 'Male', 'Marketing', '2020-10-03', '2020-10-03', 9000, 'Capucijn 98', 'Employee'),
(19, 'Martin', 'Lopez', 39, 'Male', 'Marketing', '2020-10-03', '2020-10-03', 3000, 'Concordia 45', 'Employee'),
(50, 'Dylan', 'Dennis', 50, 'Male', '', '2020-09-27', NULL, 5000, 'WED', 'Employee'),
(56, 'DSE', 'WERT', 32, 'FEMALE', '', '2020-09-08', NULL, 234, 'RTE', 'Employee'),
(69, 'John', 'Kennedy', 47, 'Male', 'Marketing', '2020-10-08', NULL, 60000, 'Washington Av 98', 'Admin'),
(200, 'john', 'greg', 43, 'Male', 'Marketing', '2020-10-05', '2020-10-05', 200, 'Eindhoven', 'Manager'),
(1962, 'Sebastian', 'Grandez', 39, 'Male', 'Marketing', '2020-10-03', '2020-10-03', 10000, 'Rosee 99', 'Admin'),
(1963, 'CATE', 'WARU', 25, 'Female', 'Finance', '2020-09-30', '2020-10-07', 23444, 'FGR', 'Employee'),
(1964, 'Mike', 'Pence', 89, 'Male', 'Customer Care', '2020-10-07', '2020-10-07', 3455, 'STATE', 'Employee'),
(1965, 'Yuri', 'Wolf', 43, 'Male', 'Finance', '2020-10-08', '2020-10-08', 60000, 'SunnyAvenue 54', 'Manager'),
(1966, 'Ronald', 'McDonald', 68, 'Male', 'Marketing', '2020-10-08', '2020-10-08', 100000, 'Mcdonald45', 'Employee'),
(1967, 'Larry', 'King', 71, 'Male', 'Marketing', '2020-10-08', '2020-10-08', 50000, 'SaveStreet6', 'Manager'),
(1968, 'Casey', 'Neistat', 49, 'Male', 'Engineering', '2020-10-08', '2020-10-08', 100000, 'California1', 'Manager'),
(1969, 'gfes', 'gersg', 123, 'Male', 'Finance', '2020-10-08', '2020-10-08', 1243, 'saef', 'Employee'),
(1970, 'hugebruhmoment', 'awd', 12, 'Female', 'Customer Care', '2020-10-08', '2020-10-08', 123, 'wad', 'Employee'),
(1971, 'yeah', 'yeah', 20, 'Male', 'Finance', '2020-10-08', '2020-10-08', 20, 'home', 'Manager'),
(1972, 'LoginMoment', 'yeah', 999, 'Male', 'Logistics', '2020-10-08', '2020-10-08', 217843, 'home', 'Manager'),
(1973, 'pleasework', 'please', 123, 'Male', 'Logistics', '2020-10-08', '2020-10-08', 1203, 'i beg....', 'Admin'),
(1974, 'DAVID', 'CATE', 60, 'Male', 'Engineering', '2020-08-10', '2020-10-08', 5000, 'XTR', 'Employee'),
(1975, 'CATE', 'WARU', 25, 'Female', 'Finance', '2020-09-30', '2020-10-08', 23444, 'FGR', 'Employee'),
(1976, 'DSE', 'WERT', 32, 'Female', '', '2020-09-08', '2020-10-08', 234, 'RTE', 'Employee'),
(1977, 'pleasework', 'nice.', 123, 'Male', 'Logistics', '2020-10-08', '2020-10-09', 1203, 'i beg....', 'Admin'),
(1978, 'yeahe', 'yeahewq', 20, 'Female', 'Logistics', '2020-10-09', '2020-10-09', 2, 'for real', 'Employee'),
(1979, 'Max', 'Well', 65, 'Female', 'marketing', '2020-11-11', '2020-11-11', 455555, 'Capu 23', 'employee'),
(1980, 'Fran', 'Grande', 45, 'Female', 'logistic', '2020-11-11', '2020-11-11', 60000, 'Somewhere', 'manager'),
(1982, 'Something', 'Something', 54, 'Female', 'marketing', '2020-11-12', '2020-11-12', 6700, 'Something', 'employee'),
(1984, 'Cher', 'Lloyd', 32, 'Female', 'Marketing', '2020-11-28', NULL, 14000, 'Somewhere', 'Manager'),
(1985, 'Toma', 'Lloyd', 0, 'Male', 'Marketing', '2020-11-28', NULL, 14002, 'What', 'Manager'),
(1990, 'Super', 'Super', 43, 'Male', 'Marketing', '2020-11-28', NULL, 60000, 'Pablo Picassostraat 230', 'Employee'),
(1991, 'Super', 'Super', 43, 'Male', 'Marketing', '2020-11-28', NULL, 60000, 'Pablo Picassostraat 230', 'Employee'),
(1992, 'Super', 'Super', 43, 'Male', 'Marketing', '2020-11-28', NULL, 60000, 'Pablo Picassostraat 230', 'Employee'),
(1995, 'Andre', 'Bokkestijn', 56, 'Male', 'Engineering', '2020-11-28', NULL, 56000, 'Pic', 'Admin'),
(1996, 'Dumb', 'Dumber', 34, 'Male', 'Finance', '2020-11-28', NULL, 60000, 'dedeede', 'Employee'),
(1997, 'DIDI', 'IDK', 43, 'Female', 'Marketing', '2020-11-28', NULL, 455555, 'Soemthing', 'Manager'),
(1998, 'Carmen', 'Lis', 54, 'Female', 'Engineering', '2020-11-28', NULL, 56000, 'Somewhere', 'Manager'),
(1999, 'Friorela', 'Soemthing', 43, 'Female', 'Marketing', '2020-11-28', NULL, 56000, 'Somewhere', 'Employee'),
(2000, 'Men', 'Men', 34, 'Male', 'Marketing', '2020-12-11', NULL, 60000, 'Something', 'Employee'),
(2001, 'Rita', 'Rita', 34, 'Female', 'Marketing', '2020-12-11', NULL, 60000, 'Something', 'Manager'),
(2002, 'yenne', 'yenne', 34, 'Female', 'Marketing', '2020-12-15', NULL, 455555, 'ded2ed2', 'Employee'),
(2003, 'yuu', 'yuu', 43, 'Male', 'Logistic', '0000-00-00', NULL, 60000, '3rfvdcc', 'Employee'),
(2004, 'Rwanda', 'Rwanda', 45, 'Male', 'Marketing', '2020-12-28', NULL, 60000, 'Rwanda', 'Employee'),
(2005, 'Rwanda', 'Rwanda', 45, 'Male', 'Marketing', '2020-12-28', NULL, 60000, 'Rwanda', 'Employee'),
(2006, 'Rwanda', 'Rwanda', 45, 'Male', 'Marketing', '2020-12-28', NULL, 60000, 'Rwanda', 'Employee');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `empId` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`empId`, `username`, `password`) VALUES
(10, 'davewww', 'dave'),
(1, 'maryjo', 'maryjo'),
(1, 'maryjo', 'maryjo'),
(11, 'LoginCredtest1', 'DgAiSJLU'),
(12, 'LoginCredtest1', 'IwKEWPWk'),
(18, 'Lola1', 'wwqENbVK'),
(1962, 'Sebastian1', 'KCLMuIwN'),
(19, 'Martin1', 'tNtOIZZQ'),
(13, 'Test1', 'DKHUQgux'),
(200, 'john1', 'DWqhdNco'),
(7, 'usernamebruh', 'passwordbruh'),
(1973, 'pleasework1', 'vWcmWynj'),
(1974, 'DAVID1', 'VkYNXhJp'),
(1975, 'CATE1', 'bBBWCLqo'),
(1976, 'DSE1', 'RKYWgevy'),
(1977, 'pleasework1', 'phhMYgvP'),
(1978, 'yeahe1', 'YTmhQwtt'),
(1990, 'Super1', 'WaU4aSyt'),
(1990, 'Super1', '35ZeBFju'),
(1995, 'Andre1', 'YIn9elDe'),
(1996, 'Dumb1', 'iNjZOEz7'),
(1997, 'DIDI1', '1AxEcfuA'),
(1998, 'Carmen1', 'Y5O1VOim'),
(1999, 'Friorela1', 'EscalyNk'),
(2000, 'Men1', 'wguIwWr2'),
(2001, 'Rita1', 'CNSiJrSJ'),
(2002, 'yenne1', '$2y$10$N3wbmHOciyWNncCWIfA/b.D5MLBkb41wlODowbMhFp/nRORnh1K0S'),
(2003, 'yuu1', '$2y$10$7SAZ0MWTE6clA.MQvvA.p.CHr8xtk.p1qvcp1v3uVp0MyMAq/o1bW'),
(2004, 'Rwanda1', 'YWJj');

-- --------------------------------------------------------

--
-- Table structure for table `request`
--

CREATE TABLE `request` (
  `RequestID` int(11) NOT NULL,
  `ProductName` varchar(100) NOT NULL,
  `RequestStatus` varchar(50) DEFAULT NULL,
  `EmployeeID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `EmployeeID` int(11) NOT NULL,
  `TimeOfDay` varchar(10) NOT NULL,
  `Day` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`EmployeeID`, `TimeOfDay`, `Day`) VALUES
(3, 'Morning', '2020-09-30'),
(3, 'Morning', '2020-09-30'),
(3, 'Afternoon', '2020-09-30'),
(3, 'Evening', '2020-09-30'),
(3, 'Morning', '2020-10-09'),
(3, 'Afternoon', '2020-10-09'),
(3, 'Evening', '2020-10-09'),
(3, 'Morning', '2020-09-30'),
(50, 'Afternoon', '2020-10-08'),
(50, 'Morning', '2020-10-08'),
(50, 'Evening', '2020-10-08'),
(14, 'Morning', '2020-09-30'),
(14, 'Afternoon', '2020-09-30'),
(14, 'Evening', '2020-09-30'),
(14, 'Morning', '2020-10-30'),
(14, 'Evening', '2020-10-30'),
(56, 'Morning', '2020-11-28'),
(14, 'Morning', '2020-11-22'),
(14, 'Morning', '2020-09-04'),
(14, 'Morning', '2020-09-04'),
(14, 'Morning', '2020-09-04'),
(14, 'Morning', '2020-10-03'),
(14, 'Morning', '2020-10-03'),
(14, 'Afternoon', '2020-10-03'),
(14, 'Evening', '2020-10-03'),
(14, 'Afternoon', '2020-10-04'),
(14, 'Morning', '2020-10-04'),
(14, 'Morning', '2020-10-04'),
(14, 'Evening', '2020-10-02'),
(14, 'Evening', '2020-10-03'),
(14, 'Evening', '2020-10-05'),
(14, 'Afternoon', '2020-10-07'),
(18, 'Morning', '2020-10-01'),
(18, 'Afternoon', '2020-09-30'),
(18, 'Evening', '2020-10-02'),
(18, 'Afternoon', '2020-10-07'),
(18, 'Evening', '2020-10-08'),
(200, 'Morning', '2020-09-30'),
(18, 'Morning', '2020-10-01'),
(18, 'Morning', '2020-10-08'),
(18, 'Morning', '2020-10-07'),
(18, 'Morning', '2020-10-06'),
(18, 'Morning', '2020-10-04'),
(18, 'Morning', '2020-10-08'),
(12, 'Morning', '2020-09-30'),
(18, 'Afternoon', '2020-10-09'),
(12, 'Morning', '2020-10-01'),
(12, 'Morning', '2020-10-02'),
(1, 'Afternoon', '2020-10-09'),
(1, 'Evening', '2020-10-09'),
(1968, 'Morning', '2020-10-10'),
(1968, 'Afternoon', '2020-10-10'),
(1968, 'Evening', '2020-10-10'),
(1978, 'Morning', '2020-09-30');

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
(11, 'Lenovo300', 600, 'Lenovo', 50, NULL),
(100, 'Razor300', 500, 'ASUS', 20, 100),
(103, 'Asus wire mouse', 60, 'ASUS', 99, 99),
(120, 'what', 200, 'Minu', 10, 0),
(130, 'Juatt', 200, 'Lein', 40, 0),
(131, 'whattt', 200, 'Lein', 40, 0),
(132, 'Sup', 400, 'Juat', 50, 0),
(133, 'Sup', 400, 'Juat', 50, 0),
(134, 'Tu', 34, 'TYU', 45, 0),
(135, 'What', 500, 'STY', 45, 0),
(200, 'zoom', 200, 'zoom', 200, 0),
(201, 'What200', 900, 'Keyless', 70, 20),
(202, 'WHat', 600, 'Novo', 60, 100),
(203, 'Torial', 650, 'Lenovo', 60, 10),
(204, 'Test', 100, 'Lego', 40, 0),
(205, 'MacBook', 1200, 'Apple', 100, 30),
(206, 'Razor200', 400, 'Acer', 200, 100),
(207, 'Terminator', 12, 'Terminator', 13, NULL);

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
  ADD KEY `ProductName` (`ProductName`);

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
  MODIFY `DeptID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2007;

--
-- AUTO_INCREMENT for table `request`
--
ALTER TABLE `request`
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=208;

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
  ADD CONSTRAINT `request_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`ID`);

--
-- Constraints for table `schedule`
--
ALTER TABLE `schedule`
  ADD CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
