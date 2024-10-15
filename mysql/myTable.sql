-- Host: localhost:3306
-- Generation Time: Sep 25, 2016 at 10:48 PM
-- Server version: 5.6.33
-- PHP Version: 5.6.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

CREATE TABLE IF NOT EXISTS `reviews` (
    `id` int(10) NOT NULL AUTO_INCREMENT,
    `first_name` varchar(50) NOT NULL,
    `last_name` varchar(50) NOT NULL,
    `date` date NOT NULL,
    `rating` int(1) NOT NULL,
    `comment` text NOT NULL,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- Dumping data for table `reviews` 
-- generic placeholder data
INSERT INTO `reviews` (`id`, `first_name`, `last_name`, `date`, `rating`, `comment`) VALUES
(1, 'John', 'Doe', '1999-01-01', 5, 'Great product!'),
(2, 'Jane', 'Smith', '2005-02-15', 4, 'Very useful.'),
(3, 'Emily', 'Jones', '2023-03-22', 3, 'It’s okay.');