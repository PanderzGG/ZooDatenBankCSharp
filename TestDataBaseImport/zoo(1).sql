-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 19. Dez 2024 um 11:58
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `zoo`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fuetterung`
--

CREATE TABLE `fuetterung` (
  `FutterID` int(11) NOT NULL,
  `TierID` int(11) NOT NULL,
  `Uhrzeit` time NOT NULL,
  `Menge` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `fuetterung`
--

INSERT INTO `fuetterung` (`FutterID`, `TierID`, `Uhrzeit`, `Menge`) VALUES
(1, 1, '08:30:00', 5),
(1, 2, '08:45:00', 6),
(1, 3, '09:00:00', 7),
(1, 4, '09:15:00', 6),
(2, 5, '07:30:00', 20),
(2, 6, '07:45:00', 25),
(3, 7, '08:00:00', 15),
(4, 8, '09:30:00', 8),
(5, 9, '10:00:00', 10),
(6, 10, '06:30:00', 4),
(7, 11, '10:15:00', 12),
(8, 12, '11:00:00', 5),
(9, 13, '11:30:00', 3),
(9, 14, '12:00:00', 4),
(10, 15, '12:30:00', 2),
(11, 16, '13:00:00', 3),
(12, 17, '13:30:00', 50),
(13, 18, '14:00:00', 20),
(14, 19, '14:30:00', 30),
(15, 20, '15:00:00', 10),
(16, 21, '15:30:00', 12),
(17, 22, '16:00:00', 8),
(17, 23, '16:15:00', 10),
(18, 24, '16:30:00', 15),
(19, 25, '17:00:00', 2),
(19, 26, '17:15:00', 3),
(20, 27, '17:30:00', 6),
(20, 28, '18:00:00', 8),
(21, 29, '18:15:00', 12),
(1, 30, '18:30:00', 5),
(22, 31, '19:00:00', 10),
(23, 32, '19:15:00', 20),
(24, 33, '19:30:00', 6),
(25, 34, '20:00:00', 8),
(26, 35, '20:15:00', 5),
(27, 36, '20:30:00', 2),
(28, 37, '21:00:00', 3),
(28, 38, '21:15:00', 2),
(29, 39, '21:30:00', 1),
(30, 40, '22:00:00', 1),
(31, 41, '22:30:00', 15),
(31, 42, '22:45:00', 16),
(32, 43, '23:00:00', 3),
(1, 44, '23:15:00', 6),
(33, 45, '23:30:00', 1),
(1, 46, '23:45:00', 7),
(14, 47, '07:15:00', 25),
(34, 48, '07:45:00', 10),
(35, 49, '08:15:00', 50),
(36, 50, '08:30:00', 40),
(28, 51, '09:00:00', 15),
(37, 52, '09:30:00', 5);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `futter`
--

CREATE TABLE `futter` (
  `FutterID` int(11) NOT NULL,
  `FutterBezeichnung` varchar(255) NOT NULL,
  `FutterEinheit` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `futter`
--

INSERT INTO `futter` (`FutterID`, `FutterBezeichnung`, `FutterEinheit`) VALUES
(1, 'Rindfleisch', 'kg'),
(2, 'Huhn', 'kg'),
(3, 'Fisch', 'kg'),
(4, 'Karotten', 'kg'),
(5, 'Äpfel', 'kg'),
(6, 'Bananen', 'kg'),
(7, 'Eukalyptusblätter', 'kg'),
(8, 'Gras', 'kg'),
(9, 'Heu', 'kg'),
(10, 'Pellets', 'kg'),
(11, 'Körner', 'kg'),
(12, 'Insekten', 'kg'),
(13, 'Mehlwürmer', 'kg'),
(14, 'Blätter', 'kg'),
(15, 'Eier', 'Stück'),
(16, 'Milch', 'Liter'),
(17, 'Wasser', 'Liter'),
(18, 'Früchte-Mix', 'kg'),
(19, 'Nüsse', 'kg'),
(20, 'Honig', 'Glas'),
(21, 'Gemüse-Mix', 'kg'),
(22, 'Zuckerrohr', 'kg'),
(23, 'Kräuter', 'kg'),
(24, 'Samen', 'g'),
(25, 'Trockenfutter', 'kg'),
(26, 'Spezialfutter', 'Beutel'),
(27, 'Pflanzenreste', 'kg'),
(28, 'Algen', 'kg'),
(29, 'Blüten', 'g'),
(30, 'Futterkalk', 'g'),
(31, 'Futtermischung', 'Eimer'),
(32, 'Getreide', 'kg'),
(33, 'Spezialgetränk', 'Becher'),
(34, 'Knollen', 'kg'),
(35, 'Trockengras', 'kg'),
(36, 'Gefrorener Fisch', 'kg'),
(37, 'Mais', 'kg'),
(38, 'Rüben', 'kg'),
(39, 'Salat', 'kg'),
(40, 'Birnen', 'kg'),
(41, 'Schokolade', 'g');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `gehege`
--

CREATE TABLE `gehege` (
  `GehegeID` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `ThemenbereichID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `gehege`
--

INSERT INTO `gehege` (`GehegeID`, `Name`, `ThemenbereichID`) VALUES
(1, 'Löwengehege', 16),
(2, 'Tigeranlage', 16),
(3, 'Elefantenhaus', 1),
(4, 'Giraffen-Savanne', 10),
(5, 'Känguru-Gehege', 18),
(6, 'Pinguin-Paradies', 7),
(7, 'Eisbären-Gehege', 7),
(8, 'Regenwald-Voliere', 8),
(9, 'Schlangenhaus', 3),
(10, 'Krokodil-Teich', 3),
(11, 'Papageien-Voliere', 2),
(12, 'Falken-Flugshow', 2),
(13, 'Fisch-Aquarium', 13),
(14, 'Hai-Becken', 13),
(15, 'Nashorn-Gehege', 1),
(16, 'Affenhaus', 15),
(17, 'Schimpansen-Insel', 15),
(18, 'Fledermaushöhle', 14),
(19, 'Koala-Haus', 18),
(20, 'Wüstentier-Gehege', 9),
(21, 'Kamelfarm', 9),
(22, 'Bisons-Gehege', 11),
(23, 'Alpensteinbock-Gehege', 11),
(24, 'Flusspferd-Gehege', 12),
(25, 'Otter-Gehege', 12),
(26, 'Bauernhoftiere-Gehege', 17),
(27, 'Ziegenstall', 17),
(28, 'Wolf-Gehege', 16),
(29, 'Eulen-Gehege', 14),
(30, 'Insektenpavillon', 6),
(31, 'Schmetterlingshaus', 6),
(32, 'Känguru-Wiese', 18),
(33, 'Antarktis-Station', 7),
(34, 'Tropisches Froschhaus', 4),
(35, 'Schildkröten-Insel', 3),
(36, 'Reh-Gehege', 10),
(37, 'Bärenwald', 1),
(38, 'Nachttierhaus', 14),
(39, 'Tundra-Gehege', 19),
(40, 'Yak-Gehege', 19),
(41, 'Karpfen-Teich', 5),
(42, 'Korallenriff-Becken', 13),
(43, 'Kamelreitstation', 9),
(44, 'Mythologische Tiere-Ausstellung', 20),
(45, 'Drachen-Exhibit', 20),
(46, 'Präriehund-Gehege', 1),
(47, 'Flamingo-Voliere', 2),
(48, 'Ara-Gehege', 2),
(49, 'Nilpferd-Anlage', 12);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `personal`
--

CREATE TABLE `personal` (
  `PersonalID` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `personal`
--

INSERT INTO `personal` (`PersonalID`, `Name`) VALUES
(1, 'Tony Stark'),
(2, 'Clark Kent'),
(3, 'Ellen Ripley'),
(4, 'Bruce Wayne'),
(5, 'Sarah Connor'),
(6, 'Lara Croft'),
(7, 'Michael Corleone'),
(8, 'Walter White'),
(9, 'Jesse Pinkman'),
(10, 'Arthur Morgan'),
(11, 'Geralt von Riva'),
(12, 'Nathan Drake'),
(13, 'Kratos'),
(14, 'Joel Miller'),
(15, 'Ellie Williams'),
(16, 'Peter Parker'),
(17, 'Darth Vader'),
(18, 'Luke Skywalker'),
(19, 'Leia Organa'),
(20, 'Obi-Wan Kenobi'),
(21, 'John Wick'),
(22, 'Neo Anderson'),
(23, 'Trinity'),
(24, 'Marty McFly'),
(25, 'Doc Brown'),
(26, 'Homer Simpson'),
(27, 'Marge Simpson'),
(28, 'Bart Simpson'),
(29, 'Lisa Simpson'),
(30, 'Rick Sanchez'),
(31, 'Morty Smith'),
(32, 'Ciri'),
(33, 'Yennefer von Vengerberg'),
(34, 'Shepard'),
(35, 'Gordon Freeman'),
(36, 'Tommy Vercetti'),
(37, 'CJ Johnson'),
(38, 'Trevor Phillips'),
(39, 'Michael De Santa'),
(40, 'Franklin Clinton');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `personaleinteilung`
--

CREATE TABLE `personaleinteilung` (
  `EinteilungsID` int(11) NOT NULL,
  `Hauptpfleger` tinyint(1) DEFAULT NULL,
  `Normalpfleger` tinyint(1) DEFAULT NULL,
  `GehegeID` int(11) DEFAULT NULL,
  `PersonalID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `personaleinteilung`
--

INSERT INTO `personaleinteilung` (`EinteilungsID`, `Hauptpfleger`, `Normalpfleger`, `GehegeID`, `PersonalID`) VALUES
(1, 1, 0, 1, 1),
(2, 0, 1, 1, 2),
(3, 1, 0, 2, 3),
(4, 0, 1, 2, 4),
(5, 1, 0, 3, 5),
(6, 0, 1, 3, 6),
(7, 1, 0, 4, 7),
(8, 0, 1, 4, 8),
(9, 1, 0, 5, 9),
(10, 0, 1, 5, 10),
(11, 1, 0, 6, 11),
(12, 0, 1, 6, 12),
(13, 1, 0, 7, 13),
(14, 0, 1, 7, 14),
(15, 1, 0, 8, 15),
(16, 0, 1, 8, 16),
(17, 1, 0, 9, 17),
(18, 0, 1, 9, 18),
(19, 1, 0, 10, 19),
(20, 0, 1, 10, 20),
(21, 1, 0, 9, 20),
(22, 0, 1, 12, 20),
(23, 0, 1, 18, 20),
(24, 0, 1, 7, 20);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `themenbereich`
--

CREATE TABLE `themenbereich` (
  `ThemenbereichID` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `themenbereich`
--

INSERT INTO `themenbereich` (`ThemenbereichID`, `Name`) VALUES
(1, 'Säugetiere'),
(2, 'Vögel'),
(3, 'Reptilien'),
(4, 'Amphibien'),
(5, 'Fische'),
(6, 'Insekten und Spinnen'),
(7, 'Arktische Tiere'),
(8, 'Tropische Regenwaldtiere'),
(9, 'Wüstentiere'),
(10, 'Savannentiere'),
(11, 'Bergtiere'),
(12, 'Tiere der Flusslandschaften'),
(13, 'Meerestiere und Korallenriffe'),
(14, 'Nachtaktive Tiere'),
(15, 'Primaten'),
(16, 'Raubtiere und Großkatzen'),
(17, 'Haus- und Nutztiere'),
(18, 'Australische Tiere (Outback)'),
(19, 'Tiere der Tundra'),
(20, 'Mythen und symbolische Tiere');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tier`
--

CREATE TABLE `tier` (
  `TierID` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `GehegeID` int(11) DEFAULT NULL,
  `TierartID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `tier`
--

INSERT INTO `tier` (`TierID`, `Name`, `GehegeID`, `TierartID`) VALUES
(1, 'Simba', 1, 1),
(2, 'Nala', 1, 1),
(3, 'Shere Khan', 2, 2),
(4, 'Rajah', 2, 2),
(5, 'Dumbo', 3, 3),
(6, 'Babar', 3, 4),
(7, 'Melman', 4, 5),
(8, 'Skippy', 5, 6),
(9, 'Matilda', 5, 7),
(10, 'Happy Feet', 6, 8),
(11, 'Knut', 6, 9),
(12, 'Rango', 7, 10),
(13, 'Kaa', 7, 11),
(14, 'Snappy', 7, 12),
(15, 'Rio', 8, 13),
(16, 'Falco', 8, 14),
(17, 'Willy', 9, 15),
(18, 'Bruce', 9, 16),
(19, 'Hugo', 10, 17),
(20, 'Castor', 10, 18),
(21, 'Baloo', 3, 19),
(22, 'Cheeta', 11, 20),
(23, 'Harambe', 11, 21),
(24, 'Po', 3, 22),
(25, 'Dracula', 12, 23),
(26, 'Hedwig', 12, 24),
(27, 'Dolly', 13, 25),
(28, 'Shaun', 13, 26),
(29, 'Yakkity', 14, 27),
(30, 'Ghost', 6, 28),
(31, 'Alpenhorn', 15, 29),
(32, 'Benny', 15, 30),
(33, 'Pinky', 8, 31),
(34, 'Seal', 6, 32),
(35, 'Varan', 7, 33),
(36, 'Jumpy', 16, 34),
(37, 'Koi', 17, 35),
(38, 'Nemo', 18, 36),
(39, 'Flutter', 19, 37),
(40, 'Charlotte', 19, 38),
(41, 'Sandy', 20, 39),
(42, 'Dusty', 20, 40),
(43, 'Buddy', 4, 41),
(44, 'Lynxie', 1, 42),
(45, 'SeaBreeze', 9, 43),
(46, 'Spot', 15, 44),
(47, 'Rocky', 4, 45),
(48, 'Straußie', 4, 46),
(49, 'Smaug', 16, 47),
(50, 'Phoenix', 16, 48),
(51, 'Manta', 9, 49),
(52, 'Aquila', 8, 50),
(53, 'Ottie', 10, 51),
(54, 'Gavialo', 10, 52);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tierart`
--

CREATE TABLE `tierart` (
  `TierartID` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `tierart`
--

INSERT INTO `tierart` (`TierartID`, `Name`) VALUES
(1, 'Afrikanischer Löwe'),
(2, 'Sibirischer Tiger'),
(3, 'Asiatischer Elefant'),
(4, 'Afrikanischer Elefant'),
(5, 'Giraffe'),
(6, 'Känguru'),
(7, 'Koala'),
(8, 'Kaiser-Pinguin'),
(9, 'Eisbär'),
(10, 'Grüner Leguan'),
(11, 'Königspython'),
(12, 'Nilkrokodil'),
(13, 'Papagei Ara'),
(14, 'Falkenartige'),
(15, 'Blauwal'),
(16, 'Weißer Hai'),
(17, 'Flusspferd'),
(18, 'Nordamerikanischer Biber'),
(19, 'Braunbär'),
(20, 'Schimpanse'),
(21, 'Gorilla'),
(22, 'Großer Panda'),
(23, 'Fledermaus'),
(24, 'Eule'),
(25, 'Hausziege'),
(26, 'Schaf'),
(27, 'Yak'),
(28, 'Arktischer Wolf'),
(29, 'Alpensteinbock'),
(30, 'Bison'),
(31, 'Flamingo'),
(32, 'Antarktischer Seelöwe'),
(33, 'Komodowaran'),
(34, 'Tropischer Frosch'),
(35, 'Karpfen'),
(36, 'Clownfisch'),
(37, 'Schmetterling'),
(38, 'Vogelspinne'),
(39, 'Kameldromedar'),
(40, 'Dromedar'),
(41, 'Präriehund'),
(42, 'Rotluchs'),
(43, 'Seepferdchen'),
(44, 'Schneeleopard'),
(45, 'Nashorn'),
(46, 'Strauß'),
(47, 'Mythologischer Drache'),
(48, 'Phönix'),
(49, 'Mantarochen'),
(50, 'Steinadler'),
(51, 'Meeresotter'),
(52, 'Gangesgavial');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `fuetterung`
--
ALTER TABLE `fuetterung`
  ADD KEY `FutterID` (`FutterID`),
  ADD KEY `TierID` (`TierID`);

--
-- Indizes für die Tabelle `futter`
--
ALTER TABLE `futter`
  ADD PRIMARY KEY (`FutterID`);

--
-- Indizes für die Tabelle `gehege`
--
ALTER TABLE `gehege`
  ADD PRIMARY KEY (`GehegeID`),
  ADD KEY `ThemenbereichID` (`ThemenbereichID`);

--
-- Indizes für die Tabelle `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`PersonalID`);

--
-- Indizes für die Tabelle `personaleinteilung`
--
ALTER TABLE `personaleinteilung`
  ADD PRIMARY KEY (`EinteilungsID`),
  ADD KEY `GehegeID` (`GehegeID`),
  ADD KEY `PersonalID` (`PersonalID`);

--
-- Indizes für die Tabelle `themenbereich`
--
ALTER TABLE `themenbereich`
  ADD PRIMARY KEY (`ThemenbereichID`);

--
-- Indizes für die Tabelle `tier`
--
ALTER TABLE `tier`
  ADD PRIMARY KEY (`TierID`),
  ADD KEY `GehegeID` (`GehegeID`),
  ADD KEY `TierartID` (`TierartID`);

--
-- Indizes für die Tabelle `tierart`
--
ALTER TABLE `tierart`
  ADD PRIMARY KEY (`TierartID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `futter`
--
ALTER TABLE `futter`
  MODIFY `FutterID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT für Tabelle `gehege`
--
ALTER TABLE `gehege`
  MODIFY `GehegeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT für Tabelle `personal`
--
ALTER TABLE `personal`
  MODIFY `PersonalID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT für Tabelle `personaleinteilung`
--
ALTER TABLE `personaleinteilung`
  MODIFY `EinteilungsID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT für Tabelle `themenbereich`
--
ALTER TABLE `themenbereich`
  MODIFY `ThemenbereichID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT für Tabelle `tier`
--
ALTER TABLE `tier`
  MODIFY `TierID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT für Tabelle `tierart`
--
ALTER TABLE `tierart`
  MODIFY `TierartID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `fuetterung`
--
ALTER TABLE `fuetterung`
  ADD CONSTRAINT `fuetterung_ibfk_1` FOREIGN KEY (`FutterID`) REFERENCES `futter` (`FutterID`),
  ADD CONSTRAINT `fuetterung_ibfk_2` FOREIGN KEY (`TierID`) REFERENCES `tier` (`TierID`);

--
-- Constraints der Tabelle `gehege`
--
ALTER TABLE `gehege`
  ADD CONSTRAINT `gehege_ibfk_1` FOREIGN KEY (`ThemenbereichID`) REFERENCES `themenbereich` (`ThemenbereichID`);

--
-- Constraints der Tabelle `personaleinteilung`
--
ALTER TABLE `personaleinteilung`
  ADD CONSTRAINT `personaleinteilung_ibfk_1` FOREIGN KEY (`GehegeID`) REFERENCES `gehege` (`GehegeID`),
  ADD CONSTRAINT `personaleinteilung_ibfk_2` FOREIGN KEY (`PersonalID`) REFERENCES `personal` (`PersonalID`);

--
-- Constraints der Tabelle `tier`
--
ALTER TABLE `tier`
  ADD CONSTRAINT `tier_ibfk_1` FOREIGN KEY (`GehegeID`) REFERENCES `gehege` (`GehegeID`),
  ADD CONSTRAINT `tier_ibfk_2` FOREIGN KEY (`TierartID`) REFERENCES `tierart` (`TierartID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
