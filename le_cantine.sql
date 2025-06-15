-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 04 mars 2025 à 11:03
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `le_cantine`
--

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `Id_Commande` int NOT NULL AUTO_INCREMENT,
  `Date_Commande` datetime DEFAULT NULL,
  `Prix_Total` varchar(50) DEFAULT NULL,
  `Id_Utilisateur` varchar(50) NOT NULL,
  `Id_Table` varchar(50) NOT NULL,
  PRIMARY KEY (`Id_Commande`),
  KEY `Id_Utilisateur` (`Id_Utilisateur`),
  KEY `Id_Table` (`Id_Table`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`Id_Commande`, `Date_Commande`, `Prix_Total`, `Id_Utilisateur`, `Id_Table`) VALUES
(1, '2004-07-27 00:00:00', '500', '2', '2');

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

DROP TABLE IF EXISTS `contenir`;
CREATE TABLE IF NOT EXISTS `contenir` (
  `Id_Commande` varchar(50) NOT NULL,
  `Id_Produit` varchar(50) NOT NULL,
  `quantite` int DEFAULT NULL,
  PRIMARY KEY (`Id_Commande`,`Id_Produit`),
  KEY `Id_Produit` (`Id_Produit`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `Id_Produit` varchar(50) NOT NULL,
  `Type_Produit` varchar(50) DEFAULT NULL,
  `Nom_Produit` varchar(50) DEFAULT NULL,
  `Prix_Produit` varchar(50) DEFAULT NULL,
  `Stock_Dispo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Produit`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `Id_Reservation` varchar(50) NOT NULL,
  `Nom_Client` varchar(50) DEFAULT NULL,
  `Contact_Client` varchar(50) DEFAULT NULL,
  `Date_Reservation` datetime DEFAULT NULL,
  `Id_Table` varchar(50) NOT NULL,
  PRIMARY KEY (`Id_Reservation`),
  KEY `Id_Table` (`Id_Table`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `tables`
--

DROP TABLE IF EXISTS `tables`;
CREATE TABLE IF NOT EXISTS `tables` (
  `Id_Table` int NOT NULL AUTO_INCREMENT,
  `Numero` varchar(50) DEFAULT NULL,
  `Capapcite` varchar(50) DEFAULT NULL,
  `Statut` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Table`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `tables`
--

INSERT INTO `tables` (`Id_Table`, `Numero`, `Capapcite`, `Statut`) VALUES
(5, '4', '4', 'Libre'),
(4, '1', '4', 'Libre');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `Id_Utilisateur` int NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `MotDePasse` varchar(50) DEFAULT NULL,
  `Role` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Utilisateur`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`Id_Utilisateur`, `Nom`, `Email`, `MotDePasse`, `Role`) VALUES
(15, 'user', 'user@gmail.com', 'user', 'User'),
(14, 'admin', 'admin@gmail.com', 'admin', 'Admin');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
