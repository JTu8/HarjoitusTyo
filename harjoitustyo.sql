-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 22.12.2017 klo 15:28
-- Palvelimen versio: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `harjoitustyo`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `henkilotiedot`
--

CREATE TABLE `henkilotiedot` (
  `ID` bigint(50) NOT NULL,
  `etunimi` varchar(50) NOT NULL,
  `sukunimi` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `puhnumero` varchar(50) NOT NULL,
  `osoite` varchar(50) NOT NULL,
  `postinumero` varchar(5) NOT NULL,
  `postitoimipaikka` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `henkilotiedot`
--

INSERT INTO `henkilotiedot` (`ID`, `etunimi`, `sukunimi`, `email`, `puhnumero`, `osoite`, `postinumero`, `postitoimipaikka`) VALUES
(1, 'Jere', 'Tuppurainen', 'joku@mail.com', '25345345', 'Tuokatu 6', '70700', 'Kuopio');

-- --------------------------------------------------------

--
-- Rakenne taululle `projektihenkilot`
--

CREATE TABLE `projektihenkilot` (
  `ID` bigint(50) NOT NULL,
  `henkilo_id` bigint(50) NOT NULL,
  `projekti_id` bigint(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `projektihenkilot`
--

INSERT INTO `projektihenkilot` (`ID`, `henkilo_id`, `projekti_id`) VALUES
(1, 1, 1);

-- --------------------------------------------------------

--
-- Rakenne taululle `projektitehtavat`
--

CREATE TABLE `projektitehtavat` (
  `ID` bigint(50) NOT NULL,
  `projekti_id` bigint(50) NOT NULL,
  `tehtava_id` bigint(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `projektitehtavat`
--

INSERT INTO `projektitehtavat` (`ID`, `projekti_id`, `tehtava_id`) VALUES
(1, 1, 2);

-- --------------------------------------------------------

--
-- Rakenne taululle `projektitiedot`
--

CREATE TABLE `projektitiedot` (
  `ID` bigint(50) NOT NULL,
  `projekti_nimi` varchar(50) DEFAULT NULL,
  `aloituspvm` date DEFAULT NULL,
  `lopetuspvm` date DEFAULT NULL,
  `kuvaus` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `projektitiedot`
--

INSERT INTO `projektitiedot` (`ID`, `projekti_nimi`, `aloituspvm`, `lopetuspvm`, `kuvaus`) VALUES
(1, 'Testi', '2018-01-08', NULL, 'Tietotekniikkaprojekti');

-- --------------------------------------------------------

--
-- Rakenne taululle `tehtavat`
--

CREATE TABLE `tehtavat` (
  `ID` bigint(50) NOT NULL,
  `tehtava_nimi` varchar(50) DEFAULT NULL,
  `tehtava_kuvaus` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `tehtavat`
--

INSERT INTO `tehtavat` (`ID`, `tehtava_nimi`, `tehtava_kuvaus`) VALUES
(1, 'Testi', 'Testi'),
(2, 'Piällysmies', 'Päällikkö johtaa projektia');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `henkilotiedot`
--
ALTER TABLE `henkilotiedot`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `projektihenkilot`
--
ALTER TABLE `projektihenkilot`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `projektitehtavat`
--
ALTER TABLE `projektitehtavat`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `projektitiedot`
--
ALTER TABLE `projektitiedot`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tehtavat`
--
ALTER TABLE `tehtavat`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `henkilotiedot`
--
ALTER TABLE `henkilotiedot`
  MODIFY `ID` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `projektihenkilot`
--
ALTER TABLE `projektihenkilot`
  MODIFY `ID` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `projektitehtavat`
--
ALTER TABLE `projektitehtavat`
  MODIFY `ID` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `projektitiedot`
--
ALTER TABLE `projektitiedot`
  MODIFY `ID` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tehtavat`
--
ALTER TABLE `tehtavat`
  MODIFY `ID` bigint(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
