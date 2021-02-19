-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 19, 2021 at 06:05 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `spookify_app`
--

-- --------------------------------------------------------

--
-- Table structure for table `playlists`
--

CREATE TABLE `playlists` (
  `playlist_id` int(11) NOT NULL,
  `name` varchar(128) NOT NULL,
  `no_of_tracks` int(4) NOT NULL DEFAULT 0,
  `user_id` int(11) NOT NULL,
  `collaborator_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `playlists`
--

INSERT INTO `playlists` (`playlist_id`, `name`, `no_of_tracks`, `user_id`, `collaborator_id`) VALUES
(13, 'Pop Music', 1, 7, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tracks`
--

CREATE TABLE `tracks` (
  `track_id` int(11) NOT NULL,
  `name` varchar(128) NOT NULL,
  `artist` varchar(128) NOT NULL,
  `duration` varchar(8) NOT NULL,
  `cover_url` varchar(1024) NOT NULL,
  `url` varchar(1024) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tracks`
--

INSERT INTO `tracks` (`track_id`, `name`, `artist`, `duration`, `cover_url`, `url`) VALUES
(1, 'i hate u, i love u', 'Olivia o\'brien, gnash', '4:28', 'http://greased-clangs.000webhostapp.com/covers/1.jpg', 'http://greased-clangs.000webhostapp.com/tracks/1.wav'),
(2, 'Closer', 'The Chainsmokers, Halsey', '4:06', 'http://greased-clangs.000webhostapp.com/covers/2.jpg', 'http://greased-clangs.000webhostapp.com/tracks/2.wav'),
(3, 'Takeaway', 'The Chainsmokers, Lennon Stella', '3:48', 'http://greased-clangs.000webhostapp.com/covers/3.jpg', 'http://greased-clangs.000webhostapp.com/tracks/3.wav');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `name` varchar(128) NOT NULL,
  `email` varchar(256) NOT NULL,
  `pwd` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `name`, `email`, `pwd`) VALUES
(1, 'Bazila', 'bazila@yahoo.com', '2222'),
(4, 'Sarmad', 'sarmad@gmail.com', '1234'),
(6, 'kay', 'k@x.com', '1234'),
(7, 'Kay', 'kay@gmail.com', '1234'),
(8, 'Sarmad', 'sarmad@123.com', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `user_collections`
--

CREATE TABLE `user_collections` (
  `collection_id` int(11) NOT NULL,
  `playlist_id` int(11) NOT NULL,
  `track_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_collections`
--

INSERT INTO `user_collections` (`collection_id`, `playlist_id`, `track_id`) VALUES
(32, 13, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `playlists`
--
ALTER TABLE `playlists`
  ADD PRIMARY KEY (`playlist_id`),
  ADD KEY `USER FKEY` (`user_id`);

--
-- Indexes for table `tracks`
--
ALTER TABLE `tracks`
  ADD PRIMARY KEY (`track_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `user_collections`
--
ALTER TABLE `user_collections`
  ADD PRIMARY KEY (`collection_id`),
  ADD KEY `PLAYLIST FKEY` (`playlist_id`),
  ADD KEY `TRACK FKEY` (`track_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `playlists`
--
ALTER TABLE `playlists`
  MODIFY `playlist_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tracks`
--
ALTER TABLE `tracks`
  MODIFY `track_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `user_collections`
--
ALTER TABLE `user_collections`
  MODIFY `collection_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `playlists`
--
ALTER TABLE `playlists`
  ADD CONSTRAINT `USER FKEY` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `user_collections`
--
ALTER TABLE `user_collections`
  ADD CONSTRAINT `PLAYLIST FKEY` FOREIGN KEY (`playlist_id`) REFERENCES `playlists` (`playlist_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `TRACK FKEY` FOREIGN KEY (`track_id`) REFERENCES `tracks` (`track_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
