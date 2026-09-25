-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2024 at 01:12 AM
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
-- Database: `htauto`
--

-- --------------------------------------------------------

--
-- Table structure for table `produit`
--

CREATE TABLE `produit` (
  `id` int(11) NOT NULL,
  `description` text NOT NULL,
  `prix` decimal(10,2) NOT NULL,
  `image` varchar(255) DEFAULT NULL,
  `modele` varchar(255) DEFAULT NULL,
  `marque` varchar(255) DEFAULT NULL,
  `numImm` varchar(255) DEFAULT NULL,
  `annee` int(11) DEFAULT NULL,
  `couleur` varchar(255) DEFAULT NULL,
  `puissance` varchar(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `produit`
--

INSERT INTO `produit` (`id`, `description`, `prix`, `image`, `modele`, `marque`, `numImm`, `annee`, `couleur`, `puissance`) VALUES
(16, 'Renault Clio 2020', 15000.00, 'uti/images/RenaultClio2020.jpeg', 'Clio', 'Renault', 'AH-FH', 2020, 'rouge', '90'),
(17, 'Peugeot 208 2021', 16000.00, 'uti/images/Peugeot2082021.jpeg', '208', 'Peugeot', 'BJ-KL', 2021, 'bleu', '100'),
(18, 'Citroën C3 2022', 15500.00, 'uti/images/CitroenC32022.jpeg', 'C3', 'Citroën', 'CM-MN', 2022, 'blanc', '110'),
(19, 'Renault Megane 2023', 22000.00, 'uti/images/RenaultMegane2023.jpeg', 'Megane', 'Renault', 'DK-OP', 2023, 'gris', '140'),
(20, 'Peugeot 308 2024', 25000.00, 'uti/images/Peugeot3082024.jpeg', '308', 'Peugeot', 'EL-QT', 2024, 'noir', '130'),
(21, 'Citroën C4 2021', 21000.00, 'uti/images/CitroenC42021.jpeg', 'C4', 'Citroën', 'FP-RU', 2021, 'vert', '130'),
(22, 'Renault Captur 2022', 23000.00, 'uti/images/RenaultCaptur2022.jpeg', 'Captur', 'Renault', 'GS-VX', 2022, 'orange', '130'),
(23, 'Peugeot 3008 2023', 30000.00, 'uti/images/Peugeot30082023.jpeg', '3008', 'Peugeot', 'HT-YZ', 2023, 'marron', '150'),
(24, 'Citroën C5 2024', 27000.00, 'uti/images/CitroenC52024.jpeg', 'C5', 'Citroën', 'IU-AB', 2024, 'jaune', '130'),
(25, 'Renault Zoe 2020', 18000.00, 'uti/images/RenaultZoe2020.jpeg', 'Zoe', 'Renault', 'JV-CD', 2020, 'bleu', '108');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `Lastname` varchar(255) NOT NULL,
  `Firstname` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userid`, `Lastname`, `Firstname`, `Email`, `password`) VALUES
(1, 'Smith', 'John', 'john.smith@example.com', 'pwd1'),
(2, 'Doe', 'Jane', 'jane.doe@example.com', 'pwd2'),
(3, 'Brown', 'Mike', 'mike.brown@example.com', 'pwd3'),
(4, 'Wilson', 'Anna', 'anna.wilson@example.com', 'pwd4'),
(5, 'Taylor', 'Chris', 'chris.taylor@example.com', 'pwd5');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `produit`
--
ALTER TABLE `produit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
