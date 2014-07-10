-- phpMyAdmin SQL Dump
-- version 3.2.3
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 08, 2010 at 09:06 PM
-- Server version: 5.1.38
-- PHP Version: 5.2.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Table structure for table `main_topics`
--

CREATE TABLE IF NOT EXISTS `main_topics` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `topic_name` varchar(150) NOT NULL,
  `datestamp` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `main_topics`
--

INSERT INTO `main_topics` (`id`, `topic_name`, `datestamp`) VALUES
(1, 'First Topic', '2009-01-01'),
(2, 'Second Topic', '2009-01-02'),
(3, 'Third topic', '2010-03-08');

-- --------------------------------------------------------

--
-- Table structure for table `topic_entries`
--

CREATE TABLE IF NOT EXISTS `topic_entries` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `main_topic_id` int(11) NOT NULL,
  `message` mediumtext NOT NULL,
  `datestamp` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=24 ;

--
-- Dumping data for table `topic_entries`
--

INSERT INTO `topic_entries` (`id`, `main_topic_id`, `message`, `datestamp`) VALUES
(1, 1, 'This is the first entry in the first topic.', '2009-01-01'),
(2, 1, 'This is the second entry in the first topic', '2009-01-02'),
(3, 2, 'First entry in the second topic', '2009-01-02'),
(23, 3, 'New comment imputed from project web page', '2010-03-08');
