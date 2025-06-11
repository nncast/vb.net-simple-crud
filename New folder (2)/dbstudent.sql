/*
SQLyog Ultimate - MySQL GUI v8.22 
MySQL - 5.5.27 : Database - dbstudent
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dbstudent` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `dbstudent`;

/*Table structure for table `addresses` */

DROP TABLE IF EXISTS `addresses`;

CREATE TABLE `addresses` (
  `addressid` int(11) NOT NULL,
  `street` varchar(100) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` varchar(50) DEFAULT NULL,
  `zipcode` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`addressid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `addresses` */

/*Table structure for table `category` */

DROP TABLE IF EXISTS `category`;

CREATE TABLE `category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `categoryname` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `categoryname` (`categoryname`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `category` */

/*Table structure for table `classrooms` */

DROP TABLE IF EXISTS `classrooms`;

CREATE TABLE `classrooms` (
  `classid` int(11) NOT NULL AUTO_INCREMENT,
  `bldgname` varchar(50) DEFAULT NULL,
  `roomnum` varchar(10) DEFAULT NULL,
  `capacity` int(11) DEFAULT NULL,
  `equipment` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`classid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `classrooms` */

insert  into `classrooms`(`classid`,`bldgname`,`roomnum`,`capacity`,`equipment`) values (1,'Building A','101',30,'Projector, Whiteboard'),(2,'Building B','202',50,'Computers, Projector'),(3,'Building C','303',40,'Smartboard'),(4,'Building D','404',60,'Projector, Speakers'),(5,'Building E','505',45,'Whiteboard, Speakers'),(6,'Building C','322',213,'1w'),(7,'Building C','500',10,'jrwiqo'),(8,'Building E','303',11,'jhkhk');

/*Table structure for table `courses` */

DROP TABLE IF EXISTS `courses`;

CREATE TABLE `courses` (
  `courseid` int(11) NOT NULL AUTO_INCREMENT,
  `coursename` varchar(100) DEFAULT NULL,
  `credits` int(11) DEFAULT NULL,
  `coursetype` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`courseid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `courses` */

insert  into `courses`(`courseid`,`coursename`,`credits`,`coursetype`) values (1,'Introduction to IT',3,'Core'),(2,'Data Structures',4,'Core'),(3,'Calculus I',4,'Elective'),(4,'Physics',3,'Core');

/*Table structure for table `departments` */

DROP TABLE IF EXISTS `departments`;

CREATE TABLE `departments` (
  `deptid` int(11) NOT NULL AUTO_INCREMENT,
  `deptname` varchar(100) DEFAULT NULL,
  `depthead` varchar(100) DEFAULT NULL,
  `phonenum` varchar(15) DEFAULT NULL,
  `officelocation` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`deptid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `departments` */

insert  into `departments`(`deptid`,`deptname`,`depthead`,`phonenum`,`officelocation`) values (1,'Computer Science','Dr. Alan Turing','555-1234','Building A'),(2,'Information System','Dr. Grace Hopper','555-5678','Building B'),(3,'Mathematics','Dr. Carl Gauss ','555-9876','Building C');

/*Table structure for table `enrollments` */

DROP TABLE IF EXISTS `enrollments`;

CREATE TABLE `enrollments` (
  `enrollmentid` int(11) NOT NULL,
  `semester` varchar(10) DEFAULT NULL,
  `grade` char(2) DEFAULT NULL,
  PRIMARY KEY (`enrollmentid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `enrollments` */

insert  into `enrollments`(`enrollmentid`,`semester`,`grade`) values (1,'Fall 2024','A'),(2,'Spring 202','B'),(3,'Fall 2024','B+'),(4,'Spring 202','A-');

/*Table structure for table `instructors` */

DROP TABLE IF EXISTS `instructors`;

CREATE TABLE `instructors` (
  `instrid` int(11) NOT NULL AUTO_INCREMENT,
  `fname` varchar(50) DEFAULT NULL,
  `lname` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`instrid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `instructors` */

insert  into `instructors`(`instrid`,`fname`,`lname`,`email`) values (1,'Alan','Turing','alan.turing@uni.com'),(2,'Grace','Hopper','grace.hopper@uni.com'),(3,'Carl','Gauss','carl.gauss@uni.com'),(4,'Marie','Curie','marie.curie@uni.com'),(5,'Nikola','Tesla','nikola.tesla@email.com');

/*Table structure for table `libraries` */

DROP TABLE IF EXISTS `libraries`;

CREATE TABLE `libraries` (
  `libraryid` int(11) NOT NULL,
  `libname` varchar(100) DEFAULT NULL,
  `location` varchar(100) DEFAULT NULL,
  `capacity` int(11) DEFAULT NULL,
  `headlibrarian` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`libraryid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `libraries` */

/*Table structure for table `payments` */

DROP TABLE IF EXISTS `payments`;

CREATE TABLE `payments` (
  `paymentid` int(11) NOT NULL,
  `paydate` date DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `paymethod` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`paymentid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `payments` */

/*Table structure for table `schedules` */

DROP TABLE IF EXISTS `schedules`;

CREATE TABLE `schedules` (
  `schedid` int(11) NOT NULL AUTO_INCREMENT,
  `dayofweek` varchar(10) DEFAULT NULL,
  `timeslot` time DEFAULT NULL,
  PRIMARY KEY (`schedid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `schedules` */

insert  into `schedules`(`schedid`,`dayofweek`,`timeslot`) values (1,'Monday','10:00:00'),(2,'Tuesday','12:00:00'),(3,'Wednesday','09:00:00'),(4,'Thursday','11:00:00'),(5,'Friday','02:00:00');

/*Table structure for table `students` */

DROP TABLE IF EXISTS `students`;

CREATE TABLE `students` (
  `studentid` int(11) NOT NULL,
  `fname` varchar(50) DEFAULT NULL,
  `lname` varchar(50) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`studentid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `students` */

insert  into `students`(`studentid`,`fname`,`lname`,`dob`,`email`) values (1,'John','Doe','1998-01-15','john.doe@email.com'),(2,'Jane','Smith','1995-05-20','jane.smith@email.com'),(3,'Mark','Lee','1997-11-02','mark.lee@email.com'),(4,'Emily','Davis','1998-09-25','emily.davis@email.com'),(5,'Robert','Brown','2002-02-02','robert.brown@email.com');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
