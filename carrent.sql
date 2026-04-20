-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Ápr 20. 10:10
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `care`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `autok`
--

CREATE TABLE `autok` (
  `rendszam` varchar(10) NOT NULL,
  `marka` varchar(30) NOT NULL,
  `tipus` varchar(30) NOT NULL,
  `ar` int(11) NOT NULL,
  `evjarat` year(4) DEFAULT NULL,
  `valto` varchar(30) DEFAULT NULL,
  `kapacitas` int(11) DEFAULT NULL,
  `teljesitmeny` int(11) DEFAULT NULL,
  `kilometerallas` int(11) NOT NULL,
  `auto_fajta_id` int(11) DEFAULT NULL,
  `helyszin_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `autok`
--

INSERT INTO `autok` (`rendszam`, `marka`, `tipus`, `ar`, `evjarat`, `valto`, `kapacitas`, `teljesitmeny`, `kilometerallas`, `auto_fajta_id`, `helyszin_id`) VALUES
('ABC-123', 'Toyota', 'Corolla', 8500, '2020', 'Automata', 5, 132, 45000, 1, 1),
('BCD-111', 'BMW', 'Series 3', 14500, '2022', 'Automata', 5, 184, 22000, 1, 6),
('BMW-333', 'BMW', 'M3 E92', 150000, '2009', 'Automata', 4, 490, 123525, 8, 10),
('BMWM-333', 'BMW', 'M3 Touring', 240000, '2024', 'Automata', 5, 510, 120, 4, 9),
('CDE-222', 'Audi', 'A4', 15200, '2023', 'Félautomata', 4, 190, 12000, 1, 6),
('DEAK-03', 'Renault', 'Megane RS', 78000, '2017', 'Manuális', 5, 315, 34000, 3, 8),
('DEF-456', 'Volkswagen', 'Golf', 7800, '2019', 'Manuális', 5, 130, 68000, 3, 2),
('EFG-333', 'Mercedes', 'C-Class', 16800, '2023', 'Automata', 4, 204, 8900, 1, 7),
('ENCI-02', 'Abarth', '595 Competizione', 42000, '2016', 'Manuális', 2, 184, 69500, 3, 5),
('FGH-444', 'Renault', 'Clio', 6500, '2019', 'Manuális', 2, 90, 78000, 3, 7),
('GGG-456', 'Mercedes', 'G65 AMG', 500000, '2014', 'Automata', 5, 650, 84400, 2, 1),
('GHI-321', 'Skoda', 'Octavia', 9200, '2022', 'Automata', 5, 150, 18000, 4, 2),
('GLFR-777', 'Volkswagen', 'Golf 7r', 187500, '2017', 'Automata', 4, 350, 13400, 3, 1),
('JIJ096', 'Fordi', 'Fusion', 20000, '2004', 'Manuális', 5, 116, 200000, 3, 1),
('KAPOR-01', 'Suzuki', 'Swift', 6700, '2002', 'Manuális', 5, 67, 340000, 3, 6),
('KISSB-1', 'Fiat', '500', 19000, '2024', 'Automata', 2, 115, 14000, 3, 6),
('KLM-777', 'Seat', 'Leon', 8200, '2021', 'Manuális', 5, 130, 41000, 3, 9),
('LMN-888', 'Volvo', 'XC60', 18900, '2023', 'Automata', 5, 197, 6200, 2, 9),
('NISSTX-1', 'Nissan', 'Titan', 76000, '2015', 'Automata', 5, 340, 95000, 9, 4),
('OPE-131', 'Suzuki', 'SX-Cross', 45000, '2018', 'Manuális', 5, 123, 140500, 5, 4),
('OPQ-101', 'Tesla', 'Model 3', 22500, '2024', 'Automata', 5, 283, 3500, 10, 10),
('PEF-002', 'Dodge', 'Charger', 320500, '2018', 'Automata', 4, 492, 23400, 8, 9),
('PEZ-345', 'Ford', 'F150 Raptor-R', 240000, '2024', 'Automata', 5, 720, 12300, 9, 7),
('RSRS-666', 'Audi', 'RS6', 350000, '2025', 'Automata', 5, 670, 43000, 4, 1),
('SMASH-1', 'Aston Martin', 'Vanquish', 250000, '2022', 'Automata', 2, 650, 1200, 8, 1),
('SSS-888', 'Audi', 'S8', 230000, '2018', 'Automata', 4, 670, 54500, 1, 2),
('TSLA-333', 'Tesla', 'Model 3 Performance', 76000, '2023', 'Automata', 5, 515, 2100, 10, 6),
('XYZ-789', 'Suzuki', 'Vitara', 9500, '2021', 'Manuális', 5, 129, 32000, 2, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `auto_fajta`
--

CREATE TABLE `auto_fajta` (
  `auto_fajta_id` int(11) NOT NULL,
  `fajta` varchar(30) NOT NULL,
  `leiras` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `auto_fajta`
--

INSERT INTO `auto_fajta` (`auto_fajta_id`, `fajta`, `leiras`) VALUES
(1, 'Sedan', 'Négyajtós családi autó'),
(2, 'SUV', 'Sport Utility Vehicle'),
(3, 'Hatchback', 'Kompakt városi autó'),
(4, 'Kombi', 'Tágas csomagtér'),
(5, 'Crossover', 'Városi terepjáró'),
(6, 'Kabrió', 'Nyitható tetős autó'),
(7, 'Minivan', 'Nagy családi autó'),
(8, 'Coupe', 'Kétajtós sportos autó'),
(9, 'Pickup', 'Teherautó személyautó kialakítással'),
(10, 'Elektromos', 'Akkumulátoros meghajtás');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `berles`
--

CREATE TABLE `berles` (
  `berles_id` int(11) NOT NULL,
  `berles_kezdete` date NOT NULL,
  `berles_vege` date NOT NULL,
  `felvetel_ido` time NOT NULL,
  `leadas_ido` time NOT NULL,
  `vegosszeg` int(11) NOT NULL,
  `autok_rendszam` varchar(10) DEFAULT NULL,
  `felhasznalo_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `berles`
--

INSERT INTO `berles` (`berles_id`, `berles_kezdete`, `berles_vege`, `felvetel_ido`, `leadas_ido`, `vegosszeg`, `autok_rendszam`, `felhasznalo_id`) VALUES
(1, '2026-03-04', '2026-03-19', '15:59:00', '08:59:00', 3000000, 'GLFR-777', 11),
(2, '2026-03-12', '2026-03-27', '14:03:00', '04:59:00', 147200, 'GHI-321', 11),
(3, '2026-03-05', '2026-03-19', '12:30:00', '14:50:00', 7500000, 'GGG-456', 11),
(4, '2026-03-05', '2026-03-20', '11:11:00', '11:11:00', 720000, 'OPE-131', 11),
(5, '2026-03-05', '2026-03-27', '12:50:00', '14:59:00', 5750000, 'SMASH-1', 16),
(6, '2026-03-12', '2026-03-27', '12:30:00', '13:30:00', 5600000, 'RSRS-666', 11),
(7, '2026-04-15', '2026-04-24', '11:30:00', '12:30:00', 2300000, 'SSS-888', 17),
(8, '2026-04-03', '2026-04-17', '11:11:00', '11:11:00', 1170000, 'DEAK-03', 17),
(9, '2026-04-13', '2026-04-15', '10:55:00', '18:45:00', 25500, 'ABC-123', 18),
(10, '2026-04-20', '2026-04-30', '11:30:00', '11:30:00', 462000, 'ENCI-02', 11);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cache`
--

CREATE TABLE `cache` (
  `key` varchar(255) NOT NULL,
  `value` mediumtext NOT NULL,
  `expiration` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cache_locks`
--

CREATE TABLE `cache_locks` (
  `key` varchar(255) NOT NULL,
  `owner` varchar(255) NOT NULL,
  `expiration` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ertekeles`
--

CREATE TABLE `ertekeles` (
  `ertekeles_datum` datetime DEFAULT NULL,
  `ertekeles_leiras` varchar(50) DEFAULT NULL,
  `ertekeles` int(11) DEFAULT NULL,
  `felhasznalo_id` int(11) DEFAULT NULL,
  `autok_rendszam` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `ertekeles`
--

INSERT INTO `ertekeles` (`ertekeles_datum`, `ertekeles_leiras`, `ertekeles`, `felhasznalo_id`, `autok_rendszam`) VALUES
(NULL, 'dsgsdgs', 4, 1, 'CDE-222'),
(NULL, 'Nagyon hangos és gyors!', 5, 2, 'GLFR-777'),
(NULL, 'megvoltam vele elégedve!', 4, 3, 'OPQ-101'),
('2026-04-12 17:31:45', 'Nagyon jó!', 4, 17, 'SSS-888'),
('2026-04-12 17:34:36', 'Szuper', 3, 17, 'SSS-888'),
('2026-04-12 17:35:46', 'Deake tehat szar!', 1, 17, 'DEAK-03'),
(NULL, 'dsgsdgs', 4, 1, 'CDE-222'),
(NULL, 'Nagyon hangos és gyors!', 5, 2, 'GLFR-777'),
(NULL, 'megvoltam vele elégedve!', 4, 3, 'OPQ-101'),
('2026-04-12 17:31:45', 'Nagyon jó!', 4, 17, 'SSS-888'),
('2026-04-12 17:34:36', 'Szuper', 3, 17, 'SSS-888'),
('2026-04-12 17:35:46', 'Deake tehat szar!', 1, 17, 'DEAK-03'),
('2026-04-13 07:45:58', 'jo', 1, 18, 'ABC-123'),
('2026-04-20 08:07:10', 'Jo', 3, 11, 'ENCI-02');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `failed_jobs`
--

CREATE TABLE `failed_jobs` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `uuid` varchar(255) NOT NULL,
  `connection` text NOT NULL,
  `queue` text NOT NULL,
  `payload` longtext NOT NULL,
  `exception` longtext NOT NULL,
  `failed_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhasznalo`
--

CREATE TABLE `felhasznalo` (
  `felhasznalo_id` int(11) NOT NULL,
  `veznev` varchar(30) NOT NULL,
  `kernev` varchar(30) NOT NULL,
  `jogositvany_szam` varchar(9) NOT NULL,
  `telefonszam` varchar(12) NOT NULL,
  `szuletesi_datum` date NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `felhasznalo`
--

INSERT INTO `felhasznalo` (`felhasznalo_id`, `veznev`, `kernev`, `jogositvany_szam`, `telefonszam`, `szuletesi_datum`, `user_id`) VALUES
(1, 'Kovács', 'János', '123456789', '+36201234567', '2002-02-04', 2),
(2, 'Nagy', 'Éva', '234567890', '+36302345678', '2000-09-06', 3),
(3, 'Tóth', 'Péter', '345678901', '+36703456789', '1998-09-12', 4),
(5, 'Kaporrr', 'Márk', 'HI031040', '+36144121412', '2008-09-06', 6),
(6, 'Maja', 'Jazmin', 'LIBRI242', '+36703454546', '2002-09-06', 9),
(7, 'Gál', 'Gergő', 'UI142424', '+36207858585', '2006-09-06', 10),
(8, 'Helga', 'Szabó', 'SZH56565', '+36203456778', '2002-02-13', 11),
(10, 'Kaporos', 'markos', 'HEHEHEEH', '+36202424242', '1998-02-03', 15),
(11, 'Admin', 'Főadminn', 'AD248247', '+36708979797', '1998-02-02', 16),
(12, 'hEHEHE', 'eHEEFEJ', 'EUE77347', '+36202424242', '2002-02-02', 17),
(13, 'MajaLibri', 'hello', 'MA200022', '+36207323232', '2002-02-02', 18),
(14, 'Pakai', 'Attila', 'HU838383', '+06701234123', '1983-01-01', 19),
(15, 'Deák', 'Márk', 'DM232323', '+36201234556', '2006-09-06', 20),
(16, 'Engertt', 'Dániel', 'ZE242424', '+36203456776', '2006-06-19', 21),
(17, 'Fábián', 'Jázmin Enikő', 'UE353434', '+36832525252', '1999-02-02', 22),
(18, 'Gizi', 'néni', '54354355', '+06701234567', '2008-04-13', 24);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `helyszin`
--

CREATE TABLE `helyszin` (
  `helyszin_id` int(11) NOT NULL,
  `varos` varchar(30) NOT NULL,
  `kerulet` varchar(30) DEFAULT NULL,
  `cim` varchar(50) DEFAULT NULL,
  `helyszin_tel` varchar(50) NOT NULL,
  `helyszin_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `helyszin`
--

INSERT INTO `helyszin` (`helyszin_id`, `varos`, `kerulet`, `cim`, `helyszin_tel`, `helyszin_email`) VALUES
(1, 'Budapest', '13. kerület', 'Váci út 120.', '06-1-450-1234', 'budapest@autoberles.hu'),
(2, 'Debrecen', NULL, 'Piac utca 45.', '06-52-411-222', 'debrecen@autoberles.hu'),
(3, 'Szeged', NULL, 'Tisza Lajos körút 12.', '06-62-420-333', 'szeged@autoberles.hu'),
(4, 'Győr', NULL, 'Baross Gábor út 8.', '06-96-510-444', 'gyor@autoberles.hu'),
(5, 'Pécs', NULL, 'Rákóczi út 34.', '06-72-511-555', 'pecs@autoberles.hu'),
(6, 'Miskolc', NULL, 'Széchenyi utca 67.', '06-46-520-666', 'miskolc@autoberles.hu'),
(7, 'Kecskemét', NULL, 'Nagykőrösi út 22.', '06-76-480-777', 'kecskemet@autoberles.hu'),
(8, 'Nyíregyháza', NULL, 'Bethlen Gábor utca 15.', '06-42-411-888', 'nyiregyhaza@autoberles.hu'),
(9, 'Székesfehérvár', NULL, 'Munkácsy Mihály utca 9.', '06-22-340-999', 'szekesfehervar@autoberles.hu'),
(10, 'Sopron', NULL, 'Várkerület 88.', '06-99-312-1010', 'sopron@autoberles.hu');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jobs`
--

CREATE TABLE `jobs` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `queue` varchar(255) NOT NULL,
  `payload` longtext NOT NULL,
  `attempts` tinyint(3) UNSIGNED NOT NULL,
  `reserved_at` int(10) UNSIGNED DEFAULT NULL,
  `available_at` int(10) UNSIGNED NOT NULL,
  `created_at` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `job_batches`
--

CREATE TABLE `job_batches` (
  `id` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `total_jobs` int(11) NOT NULL,
  `pending_jobs` int(11) NOT NULL,
  `failed_jobs` int(11) NOT NULL,
  `failed_job_ids` longtext NOT NULL,
  `options` mediumtext DEFAULT NULL,
  `cancelled_at` int(11) DEFAULT NULL,
  `created_at` int(11) NOT NULL,
  `finished_at` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kategoria`
--

CREATE TABLE `kategoria` (
  `kategoria_id` int(11) NOT NULL,
  `nev` varchar(50) NOT NULL,
  `leiras` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `kategoria`
--

INSERT INTO `kategoria` (`kategoria_id`, `nev`, `leiras`) VALUES
(1, 'Navigáció & GPS', 'GPS eszközök és navigációs rendszerek'),
(2, 'Gyermekülés', 'Biztonsági gyermekülések minden korosztálynak'),
(3, 'Extra Biztosítás', 'Kiegészítő biztosítási csomagok'),
(4, 'Téli Felszerelés', 'Síléc tartók és téli kiegészítők');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- A tábla adatainak kiíratása `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '0001_01_01_000000_create_users_table', 1),
(2, '0001_01_01_000001_create_cache_table', 1),
(3, '0001_01_01_000002_create_jobs_table', 1),
(4, '2026_02_22_170602_add_email_verified_at_to_user_table', 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `password_reset_tokens`
--

CREATE TABLE `password_reset_tokens` (
  `email` varchar(255) NOT NULL,
  `token` varchar(255) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- A tábla adatainak kiíratása `password_reset_tokens`
--

INSERT INTO `password_reset_tokens` (`email`, `token`, `created_at`) VALUES
('admin@gmail.com', '$2y$12$xt2i5YJtSfsCQPubStCUBe5wN4/Etu3fUtdmiISv5rQdRZGYLnSuu', '2026-03-30 04:44:02'),
('deakm@gmail.com', '$2y$12$lFSixlfoMckWmnJNyIJ5N.GFYxMdPbUS3efXzyqer5BCGEWzA/xCC', '2026-03-26 09:04:50'),
('galgergo00@gmail.com', '$2y$12$poXe4XORR2uOy2ObIJBkCOcK4KWx/KGLNU8d64OWotoQGAIzXoD/6', '2026-03-26 09:06:58'),
('horvath.attila@verebelyszki.hu', '$2y$12$hG4G36E4ZEC/zAvJn89FVe4oVLmncINuU.BZS45H5tdam3EkXVa9K', '2026-03-26 10:30:15'),
('kafwqfwf@gmail.com', '$2y$12$iLpjh65C13lxE8fH71YXm.OWLNjja1cd7qboL5VHdBcSqjmd0gZV2', '2026-03-26 09:48:52');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendeles`
--

CREATE TABLE `rendeles` (
  `rendeles_id` int(11) NOT NULL,
  `rendeles_datum` datetime DEFAULT current_timestamp(),
  `vegosszeg` int(11) NOT NULL,
  `statusz` varchar(30) DEFAULT 'folyamatban',
  `user_id` int(11) NOT NULL,
  `berles_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `rendeles`
--

INSERT INTO `rendeles` (`rendeles_id`, `rendeles_datum`, `vegosszeg`, `statusz`, `user_id`, `berles_id`) VALUES
(1, '2026-04-09 22:20:23', 8200, 'Feldolgozás alatt', 1, NULL),
(2, '2026-04-09 22:29:02', 8200, 'Feldolgozás alatt', 1, NULL),
(3, '2026-04-09 22:29:05', 8200, 'Feldolgozás alatt', 1, NULL),
(4, '2026-04-09 22:29:27', 8200, 'Feldolgozás alatt', 1, NULL),
(5, '2026-04-09 22:32:40', 5000, 'Feldolgozás alatt', 1, NULL),
(6, '2026-04-09 22:33:24', 8200, 'Feldolgozás alatt', 1, NULL),
(7, '2026-04-09 22:36:37', 7900, 'Feldolgozás alatt', 1, NULL),
(8, '2026-04-09 22:36:50', 8500, 'Feldolgozás alatt', 1, NULL),
(9, '2026-04-09 22:40:19', 4700, 'Feldolgozás alatt', 1, NULL),
(10, '2026-04-09 22:44:07', 4700, 'Feldolgozás alatt', 1, NULL),
(11, '2026-04-09 22:53:18', 8500, 'Feldolgozás alatt', 1, NULL),
(12, '2026-04-09 22:53:34', 4000, 'Feldolgozás alatt', 1, NULL),
(13, '2026-04-09 22:53:47', 6500, 'Feldolgozás alatt', 1, NULL),
(14, '2026-04-09 22:57:54', 5000, 'Feldolgozás alatt', 1, NULL),
(15, '2026-04-10 12:04:20', 5000, 'Feldolgozás alatt', 1, NULL),
(16, '2026-04-13 08:53:53', 25000, 'Feldolgozás alatt', 24, NULL),
(17, '2026-04-13 08:55:06', 16000, 'Feldolgozás alatt', 24, NULL),
(18, '2026-04-13 08:55:56', 8500, 'Feldolgozás alatt', 24, NULL),
(19, '2026-04-20 08:08:37', 5000, 'Feldolgozás alatt', 16, NULL);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendeles_tetel`
--

CREATE TABLE `rendeles_tetel` (
  `rendeles_tetel_id` int(11) NOT NULL,
  `mennyiseg` int(11) NOT NULL,
  `egysegar` int(11) NOT NULL,
  `rendeles_id` int(11) NOT NULL,
  `tartozek_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `rendeles_tetel`
--

INSERT INTO `rendeles_tetel` (`rendeles_tetel_id`, `mennyiseg`, `egysegar`, `rendeles_id`, `tartozek_id`) VALUES
(1, 1, 3200, 4, 2),
(2, 1, 3500, 4, 3),
(3, 1, 3500, 5, 3),
(4, 1, 3500, 6, 1),
(5, 1, 3200, 6, 2),
(6, 2, 3200, 7, 2),
(7, 2, 3500, 8, 1),
(8, 1, 3200, 9, 2),
(9, 1, 3200, 10, 2),
(10, 2, 3500, 11, 1),
(11, 1, 2500, 12, 5),
(12, 2, 2500, 13, 5),
(13, 1, 3500, 14, 1),
(14, 1, 3500, 15, 1),
(15, 5, 5000, 16, 7),
(16, 5, 3200, 17, 2),
(17, 2, 3500, 18, 1),
(18, 1, 3500, 19, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `sessions`
--

CREATE TABLE `sessions` (
  `id` varchar(255) NOT NULL,
  `user_id` bigint(20) UNSIGNED DEFAULT NULL,
  `ip_address` varchar(45) DEFAULT NULL,
  `user_agent` text DEFAULT NULL,
  `payload` longtext NOT NULL,
  `last_activity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tartozek`
--

CREATE TABLE `tartozek` (
  `tartozek_id` int(11) NOT NULL,
  `nev` varchar(50) NOT NULL,
  `leiras` varchar(150) DEFAULT NULL,
  `ar` int(11) NOT NULL,
  `keszlet` int(11) NOT NULL DEFAULT 0,
  `kategoria_id` int(11) DEFAULT NULL,
  `aktiv` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `tartozek`
--

INSERT INTO `tartozek` (`tartozek_id`, `nev`, `leiras`, `ar`, `keszlet`, `kategoria_id`, `aktiv`) VALUES
(1, 'Garmin Drive GPS Navigáció', 'Professzionális GPS navigációs rendszer nagy kijelzővel és valós idejű forgalmi információkkal', 3500, 7, 1, 1),
(2, 'TomTom GO Navigator', 'Prémiun navigáció élettartam térképfrissítéssel', 3200, 0, 1, 1),
(3, 'Garmin Drive 52', '5 colos kijelző, teljes Európa térképpel.', 3500, 15, 1, 1),
(4, 'TomTom GO Professional', 'Kifejezetten nagy autókhoz tervezett navigáció.', 4200, 8, 1, 1),
(5, 'Britax Römer Dualfix', '360 fokban forgatható, ISOFIX rendszerű ülés.', 2500, 12, 2, 1),
(6, 'Cybex Solution S-Fix', 'Magas háttámlás ülés 3-12 éves korig.', 1800, 20, 2, 1),
(7, 'Teljes Körű Casco', 'Lopás és töréskár esetén 0 Ft önrész.', 5000, 994, 3, 1),
(8, 'Üvegkár Biztosítás', 'Kavicsfelverődés és szélvédőcsere fedezet.', 1500, 0, 3, 1),
(9, 'Thule Síléctartó', 'Akár 6 pár léc biztonságos szállítására.', 2200, 10, 4, 1),
(10, 'Hólánc Készlet', 'Prémium acél hólánc minden kerékmérethez.', 1000, 30, 4, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(255) NOT NULL,
  `rang` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `user`
--

INSERT INTO `user` (`user_id`, `email`, `email_verified_at`, `username`, `password`, `rang`) VALUES
(1, 'admin@autoberles.hu', NULL, 'admin', '$2a$11$XjKV5H5s9qJ5K8pN1jX0k.YxZJYQP5gH5qh5K5H5s9qJ5K8pN1jX0O', 2),
(2, 'kovacs.janos@email.hu', NULL, 'kovacs_janos', '$2a$11$XjKV5H5s9qJ5K8pN1jX0k.YxZJYQP5gH5qh5K5H5s9qJ5K8pN1jX0P', 1),
(3, 'nagy.eva@email.hu', NULL, 'nagy_eva', '$2a$11$XjKV5H5s9qJ5K8pN1jX0k.YxZJYQP5gH5qh5K5H5s9qJ5K8pN1jX0P', 1),
(4, 'toth.peter@email.hu', NULL, 'toth_peter', '$2a$11$XjKV5H5s9qJ5K8pN1jX0k.YxZJYQP5gH5qh5K5H5s9qJ5K8pN1jX0P', 1),
(6, 'kapor@gmail.com', NULL, 'KaporMark', '$2y$12$iaXab5EK0XK0V65v10YFEOhDQeV.h2KPYi7V4P55tlHRRWuOxMODe', 1),
(8, 'majajazminkalibri@gmail.com', NULL, 'MajaJazmin2', '$2y$12$KQag9.G9skvh2/.vH8Sz0u51t3nudGkbUES6oDzPgoJXz/pqVWV.G', 1),
(9, '2rwfmaja@gmail.com', NULL, 'MajacsKaahgaa', '$2y$12$KK3JGC5UXHRflCiYDfXzR.AZWIUzRj1hQkWKVX0O0jFy0lDkrG906', 1),
(10, 'gerzzrz@gmail.com', NULL, 'GergooooKe', '$2y$12$2//H8rTN8cwNHN3qW9ga1egWPDRZtB8ls/G4FThOUsc8G3ei4QFCC', 1),
(11, 'szabohelga@gmail.com', '2026-02-22 16:38:07', 'SzaboHelgi', '$2y$12$XESZwid7DrTv6mZBILE31uVlFJSDcmLbUJ4gD6NqySPkbqv4EAKNa', 1),
(12, 'galgergo00@gmail.com', NULL, 'GeriiiVok', '$2y$12$LP0Qc1n.dhBesDLpjmW/qOle2idzEt7oylN7gtjUuLAIjqCIkm7/m', 1),
(15, 'kafwqfwf@gmail.com', '2026-02-22 16:58:50', 'GkArerereEre', '$2y$12$J8eHcLg1lpaVYOO7jZDnJu4iPcHzoEu4HgH1MuFqDQFZTDhkFoslS', 1),
(16, 'admin@gmail.com', '2026-02-25 09:49:39', 'HelloKaNyaloka', '$2y$12$t2q//O0cLn039gnFx3XJXeSPTIfTkMckyTCyfAHaMARe7iUgyv2qK', 1),
(17, 'hellfofaf@gmail.com', NULL, 'HelloFaszNh', '$2y$12$6SwhQDAE3ROutlpepZACfOIIRP51uapMRqTHI3GEV7SZJSGBvIUly', 1),
(18, 'majacskagf@gmail.com', '2026-03-05 09:02:27', 'MajacskaGgewfw', '$2y$12$TK0uyCemQlG90q1/CDaDT.jS6s6tRUO5Nvua6ZW6Y429YX8eCXu3G', 1),
(19, 'horvath.attila@verebelyszki.hu', '2026-03-06 10:57:36', 'horvathat', '$2y$12$5enemUvfuoZcqQQnaI25SOWDJAeIYB6vaUGYxUbZn.8H1KUSXBxfC', 1),
(20, 'deakm@gmail.com', '2026-03-07 10:12:58', 'DeakMark', '$2y$12$eEW3At1KSN./RyIfais9AOS86o5LxLzKGTPgz7ueqU5SpvUeIqRg.', 1),
(21, 'engertdani@gmail.com', '2026-03-26 09:50:59', 'EngertDanika', '$2y$12$wgtI2MqyszmA2wKShr/wcuuPBSookcmD6/M3lFuDb/loolGt1qOKW', 1),
(22, 'fabian.jazmin@gmail.com', '2026-04-12 14:16:01', 'FabianJasmin', '$2y$12$GalR.CKuWwGzreKtLjruSu.j3AFcxsvVYi07yE2NHY588vsTNkL/e', 1),
(23, 'asd@asd.com', NULL, 'asd', '$2a$12$rEhCg9/O0C/lK5vEadqTdOlQJDaYQbmFlO6NibVYxIAylEzKxchLe', 2),
(24, 'gizi@gizi.hu', '2026-04-13 05:40:13', 'gizinéni', '$2y$12$1GrxgUbtooY.AVd7KYydPO.mvZXdQs3hvDr/rpnW3iMpdt4lP/XRK', 1),
(25, 'er@gh.hu', NULL, 'eroika', '$2a$11$oLhSLiCqIOAaUcE0gSDMjuuDkYuL7ABdv2aZLK75fl3OQZnfrjLNm', 2);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `remember_token` varchar(100) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `autok`
--
ALTER TABLE `autok`
  ADD PRIMARY KEY (`rendszam`),
  ADD KEY `auto_fajta_id` (`auto_fajta_id`),
  ADD KEY `helyszin_id` (`helyszin_id`);

--
-- A tábla indexei `auto_fajta`
--
ALTER TABLE `auto_fajta`
  ADD PRIMARY KEY (`auto_fajta_id`);

--
-- A tábla indexei `berles`
--
ALTER TABLE `berles`
  ADD PRIMARY KEY (`berles_id`),
  ADD KEY `autok_rendszam` (`autok_rendszam`),
  ADD KEY `felhasznalo_id` (`felhasznalo_id`);

--
-- A tábla indexei `cache`
--
ALTER TABLE `cache`
  ADD PRIMARY KEY (`key`),
  ADD KEY `cache_expiration_index` (`expiration`);

--
-- A tábla indexei `cache_locks`
--
ALTER TABLE `cache_locks`
  ADD PRIMARY KEY (`key`),
  ADD KEY `cache_locks_expiration_index` (`expiration`);

--
-- A tábla indexei `ertekeles`
--
ALTER TABLE `ertekeles`
  ADD KEY `felhasznalo_id` (`felhasznalo_id`),
  ADD KEY `autok_rendszam` (`autok_rendszam`);

--
-- A tábla indexei `failed_jobs`
--
ALTER TABLE `failed_jobs`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `failed_jobs_uuid_unique` (`uuid`);

--
-- A tábla indexei `felhasznalo`
--
ALTER TABLE `felhasznalo`
  ADD PRIMARY KEY (`felhasznalo_id`),
  ADD UNIQUE KEY `jogositvany_szam` (`jogositvany_szam`),
  ADD UNIQUE KEY `user_id` (`user_id`);

--
-- A tábla indexei `helyszin`
--
ALTER TABLE `helyszin`
  ADD PRIMARY KEY (`helyszin_id`);

--
-- A tábla indexei `jobs`
--
ALTER TABLE `jobs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `jobs_queue_index` (`queue`);

--
-- A tábla indexei `job_batches`
--
ALTER TABLE `job_batches`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kategoria`
--
ALTER TABLE `kategoria`
  ADD PRIMARY KEY (`kategoria_id`);

--
-- A tábla indexei `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `password_reset_tokens`
--
ALTER TABLE `password_reset_tokens`
  ADD PRIMARY KEY (`email`);

--
-- A tábla indexei `rendeles`
--
ALTER TABLE `rendeles`
  ADD PRIMARY KEY (`rendeles_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `berles_id` (`berles_id`);

--
-- A tábla indexei `rendeles_tetel`
--
ALTER TABLE `rendeles_tetel`
  ADD PRIMARY KEY (`rendeles_tetel_id`),
  ADD KEY `rendeles_id` (`rendeles_id`),
  ADD KEY `tartozek_id` (`tartozek_id`);

--
-- A tábla indexei `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `sessions_user_id_index` (`user_id`),
  ADD KEY `sessions_last_activity_index` (`last_activity`);

--
-- A tábla indexei `tartozek`
--
ALTER TABLE `tartozek`
  ADD PRIMARY KEY (`tartozek_id`),
  ADD KEY `kategoria_id` (`kategoria_id`);

--
-- A tábla indexei `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `username` (`username`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `auto_fajta`
--
ALTER TABLE `auto_fajta`
  MODIFY `auto_fajta_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `berles`
--
ALTER TABLE `berles`
  MODIFY `berles_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `failed_jobs`
--
ALTER TABLE `failed_jobs`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `felhasznalo`
--
ALTER TABLE `felhasznalo`
  MODIFY `felhasznalo_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT a táblához `helyszin`
--
ALTER TABLE `helyszin`
  MODIFY `helyszin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `jobs`
--
ALTER TABLE `jobs`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `kategoria`
--
ALTER TABLE `kategoria`
  MODIFY `kategoria_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `rendeles`
--
ALTER TABLE `rendeles`
  MODIFY `rendeles_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT a táblához `rendeles_tetel`
--
ALTER TABLE `rendeles_tetel`
  MODIFY `rendeles_tetel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT a táblához `tartozek`
--
ALTER TABLE `tartozek`
  MODIFY `tartozek_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `autok`
--
ALTER TABLE `autok`
  ADD CONSTRAINT `autok_ibfk_1` FOREIGN KEY (`auto_fajta_id`) REFERENCES `auto_fajta` (`auto_fajta_id`),
  ADD CONSTRAINT `autok_ibfk_2` FOREIGN KEY (`helyszin_id`) REFERENCES `helyszin` (`helyszin_id`);

--
-- Megkötések a táblához `berles`
--
ALTER TABLE `berles`
  ADD CONSTRAINT `berles_ibfk_1` FOREIGN KEY (`autok_rendszam`) REFERENCES `autok` (`rendszam`),
  ADD CONSTRAINT `berles_ibfk_2` FOREIGN KEY (`felhasznalo_id`) REFERENCES `felhasznalo` (`felhasznalo_id`);

--
-- Megkötések a táblához `ertekeles`
--
ALTER TABLE `ertekeles`
  ADD CONSTRAINT `ertekeles_ibfk_1` FOREIGN KEY (`felhasznalo_id`) REFERENCES `felhasznalo` (`felhasznalo_id`),
  ADD CONSTRAINT `ertekeles_ibfk_2` FOREIGN KEY (`autok_rendszam`) REFERENCES `autok` (`rendszam`);

--
-- Megkötések a táblához `felhasznalo`
--
ALTER TABLE `felhasznalo`
  ADD CONSTRAINT `felhasznalo_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`);

--
-- Megkötések a táblához `rendeles`
--
ALTER TABLE `rendeles`
  ADD CONSTRAINT `rendeles_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `rendeles_ibfk_2` FOREIGN KEY (`berles_id`) REFERENCES `berles` (`berles_id`) ON DELETE SET NULL;

--
-- Megkötések a táblához `rendeles_tetel`
--
ALTER TABLE `rendeles_tetel`
  ADD CONSTRAINT `rendeles_tetel_ibfk_1` FOREIGN KEY (`rendeles_id`) REFERENCES `rendeles` (`rendeles_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `rendeles_tetel_ibfk_2` FOREIGN KEY (`tartozek_id`) REFERENCES `tartozek` (`tartozek_id`) ON DELETE CASCADE;

--
-- Megkötések a táblához `tartozek`
--
ALTER TABLE `tartozek`
  ADD CONSTRAINT `tartozek_ibfk_1` FOREIGN KEY (`kategoria_id`) REFERENCES `kategoria` (`kategoria_id`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
