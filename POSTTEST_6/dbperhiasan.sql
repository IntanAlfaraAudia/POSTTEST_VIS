-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Apr 2026 pada 16.48
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbperhiasan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkategori`
--

CREATE TABLE `tbkategori` (
  `id_kategori` int(11) NOT NULL,
  `Kategori` varchar(50) NOT NULL,
  `tingkatKualitas` varchar(50) NOT NULL,
  `asalProduk` varchar(50) NOT NULL,
  `garansi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbkategori`
--

INSERT INTO `tbkategori` (`id_kategori`, `Kategori`, `tingkatKualitas`, `asalProduk`, `garansi`) VALUES
(0, '', 'Premium', 'Lokal', '1 Tahun'),
(1, '', 'Premium', 'Lokal', '1 Tahun');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbperhiasan`
--

CREATE TABLE `tbperhiasan` (
  `kodePerhiasan` varchar(5) NOT NULL,
  `namaPerhiasan` varchar(50) NOT NULL,
  `jenis` varchar(30) NOT NULL,
  `harga` int(11) NOT NULL,
  `id_kategori` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbperhiasan`
--

INSERT INTO `tbperhiasan` (`kodePerhiasan`, `namaPerhiasan`, `jenis`, `harga`, `id_kategori`) VALUES
('P01', 'Kalung', 'Emas', 1500000, 1);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbkategori`
--
ALTER TABLE `tbkategori`
  ADD PRIMARY KEY (`id_kategori`);

--
-- Indeks untuk tabel `tbperhiasan`
--
ALTER TABLE `tbperhiasan`
  ADD PRIMARY KEY (`kodePerhiasan`),
  ADD KEY `id_kategori` (`id_kategori`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbperhiasan`
--
ALTER TABLE `tbperhiasan`
  ADD CONSTRAINT `tbperhiasan_ibfk_1` FOREIGN KEY (`id_kategori`) REFERENCES `tbkategori` (`id_kategori`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbperhiasan_ibfk_2` FOREIGN KEY (`id_kategori`) REFERENCES `tbkategori` (`id_kategori`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
