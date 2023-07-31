-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 31 Jul 2023 pada 13.34
-- Versi server: 10.4.22-MariaDB
-- Versi PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbapi`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `makanan2`
--

CREATE TABLE `makanan2` (
  `id` int(11) NOT NULL,
  `nokamar` int(12) NOT NULL,
  `jenis_makanan` varchar(50) NOT NULL,
  `nama_makanan` varchar(50) NOT NULL,
  `harga` int(12) NOT NULL,
  `jumlah` int(12) NOT NULL,
  `total_harga` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `makanan2`
--

INSERT INTO `makanan2` (`id`, `nokamar`, `jenis_makanan`, `nama_makanan`, `harga`, `jumlah`, `total_harga`) VALUES
(1, 12, 'Seafood', 'Kepiting', 40000, 1, 40000),
(2, 15, 'Ayam', 'Ayam Bakar', 90000, 2, 180000),
(3, 10, 'Pizza', 'Pizza Pasta', 120000, 1, 120000),
(4, 20, 'Seafood', 'Kerang', 60000, 1, 60000),
(5, 22, 'Ayam', 'Ayam Geprek', 15000, 2, 30000),
(6, 25, 'Pizza', 'Pizza Sicilia', 120000, 1, 120000),
(7, 18, 'Ayam', 'Ayam Goreng', 50000, 2, 100000),
(8, 28, 'Seafood', 'Lobster', 100000, 3, 300000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `makanan2`
--
ALTER TABLE `makanan2`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nokamar` (`nokamar`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `makanan2`
--
ALTER TABLE `makanan2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
