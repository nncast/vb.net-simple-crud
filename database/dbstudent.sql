-- ============================================================================
--  simpleCRUD — database schema
--  Database: dbstudent   (matches every form's Connect(...) call)
--  Engine:   InnoDB
--
--  This file was reverse-engineered from the app's own CRUD code — every
--  table and column here exists because a SELECT/INSERT/UPDATE/DELETE in the
--  VB.NET forms actually reads or writes it. Referenced from:
--    Conn.vb          -> Connect(..., "dbstudent", ...)
--    Classrooms.vb    -> classrooms
--    Courses.vb       -> courses
--    Departments.vb   -> departments
--    Instructors.vb   -> instructors
--    Schedules.vb     -> schedules
--
--  The five tables are independent — no form joins or looks up another
--  table, so there are no foreign keys between them.
--
--  NOTE: the Add forms send the (empty, disabled) ID textbox as '' for the
--  id column, relying on MySQL turning that into the next AUTO_INCREMENT
--  value. That only works when the server is NOT in strict mode. If saving
--  a new record fails with "Incorrect integer value: '' for column ...",
--  turn strict mode off (see README > Troubleshooting).
--
--  Import this before running the app (SQLYog / phpMyAdmin / mysql CLI):
--      mysql -u root -p < dbstudent.sql
-- ============================================================================

CREATE DATABASE IF NOT EXISTS dbstudent
  CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE dbstudent;

-- ----------------------------------------------------------------------------
-- classrooms
--   Full CRUD in Classrooms.vb. bldgname values come from cmbbldgname
--   (Building A–E).
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS classrooms;
CREATE TABLE classrooms (
  classid    INT UNSIGNED NOT NULL AUTO_INCREMENT,
  bldgname   VARCHAR(50)  NOT NULL,
  roomnum    VARCHAR(20)  NOT NULL,
  capacity   INT UNSIGNED NOT NULL,
  equipment  VARCHAR(255) NOT NULL,
  PRIMARY KEY (classid)
) ENGINE=InnoDB;

-- ----------------------------------------------------------------------------
-- courses
--   Full CRUD in Courses.vb. credits comes from the numcredits NumericUpDown;
--   coursetype from cmbcoursetype (Core / Elective).
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS courses;
CREATE TABLE courses (
  courseid    INT UNSIGNED     NOT NULL AUTO_INCREMENT,
  coursename  VARCHAR(100)     NOT NULL,
  credits     TINYINT UNSIGNED NOT NULL,
  coursetype  VARCHAR(20)      NOT NULL,
  PRIMARY KEY (courseid)
) ENGINE=InnoDB;

-- ----------------------------------------------------------------------------
-- departments
--   Full CRUD in Departments.vb. officelocation values come from
--   cmbofficelocation (Building A–D). phonenum is text so leading zeros,
--   dashes and "+" survive.
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS departments;
CREATE TABLE departments (
  deptid          INT UNSIGNED NOT NULL AUTO_INCREMENT,
  deptname        VARCHAR(100) NOT NULL,
  depthead        VARCHAR(100) NOT NULL,
  phonenum        VARCHAR(20)  NOT NULL,
  officelocation  VARCHAR(50)  NOT NULL,
  PRIMARY KEY (deptid)
) ENGINE=InnoDB;

-- ----------------------------------------------------------------------------
-- instructors
--   Full CRUD in Instructors.vb.
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS instructors;
CREATE TABLE instructors (
  instrid  INT UNSIGNED NOT NULL AUTO_INCREMENT,
  fname    VARCHAR(50)  NOT NULL,
  lname    VARCHAR(50)  NOT NULL,
  email    VARCHAR(100) NOT NULL,
  PRIMARY KEY (instrid)
) ENGINE=InnoDB;

-- ----------------------------------------------------------------------------
-- schedules
--   Full CRUD in Schedules.vb. dayofweek comes from cmbdayofweek
--   (Monday–Friday). timeslot is stored as text because the form saves
--   dtptimeslot.Text verbatim (e.g. "9:30:00 AM") and reads it back into the
--   same picker — a TIME column would reject or mangle the AM/PM suffix.
-- ----------------------------------------------------------------------------
DROP TABLE IF EXISTS schedules;
CREATE TABLE schedules (
  schedid    INT UNSIGNED NOT NULL AUTO_INCREMENT,
  dayofweek  VARCHAR(10)  NOT NULL,
  timeslot   VARCHAR(20)  NOT NULL,
  PRIMARY KEY (schedid)
) ENGINE=InnoDB;

-- ============================================================================
--  Seed data — a few sample rows so each form's list isn't empty on first
--  run. Values match the forms' combo box options. Safe to delete.
-- ============================================================================

INSERT INTO classrooms (bldgname, roomnum, capacity, equipment) VALUES
  ('Building A', '101', 40, 'Projector, Whiteboard'),
  ('Building B', '205', 30, 'Computers');

INSERT INTO courses (coursename, credits, coursetype) VALUES
  ('Introduction to Programming', 3, 'Core'),
  ('Web Development', 3, 'Elective');

INSERT INTO departments (deptname, depthead, phonenum, officelocation) VALUES
  ('Computer Science', 'Maria Santos', '0917-123-4567', 'Building A'),
  ('Mathematics', 'Jose Reyes', '0918-765-4321', 'Building C');

INSERT INTO instructors (fname, lname, email) VALUES
  ('Ana', 'Cruz', 'ana.cruz@example.com'),
  ('Mark', 'Dela Rosa', 'mark.delarosa@example.com');

INSERT INTO schedules (dayofweek, timeslot) VALUES
  ('Monday', '8:00:00 AM'),
  ('Wednesday', '1:30:00 PM');
