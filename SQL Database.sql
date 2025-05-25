CREATE TABLE Users (
    Id           INT           IDENTITY(1,1) PRIMARY KEY,
    FirstName    NVARCHAR(100) NOT NULL,
    LastName     NVARCHAR(100) NOT NULL,
    UserName     NVARCHAR(100) NOT NULL  UNIQUE,
    Email        NVARCHAR(100) NOT NULL UNIQUE,
    Department   NVARCHAR(100) NOT NULL,
    Role         NVARCHAR(50)  NOT NULL,     -- e.g. 'Student', 'Teacher', 'Admin'
    Password     NVARCHAR(256) NOT NULL,     -- consider hashing+salt; avoid plain text
    DateOfBirth  DATE          NULL
);




CREATE TABLE TimeTables (
    TimeTableId INT      IDENTITY(1,1) PRIMARY KEY,
    Department   NVARCHAR(100) NOT NULL,
	TeacherId    INT      NOT NULL,
    TeacherName  NVARCHAR(200) NOT NULL,
    RoomNumber  INT      NOT NULL,
    Day         NVARCHAR(20) NOT NULL,      -- e.g. 'Monday'
    CourseCode  NVARCHAR(20)      NOT NULL,
    CourseName  NVARCHAR(100) NOT NULL,
    Date        DATE     NOT NULL,
	Lecture		NVARCHAR(100) NOT NULL,
    StartTime   TIME     NOT NULL,
    EndTime     TIME     NOT NULL
);



CREATE TABLE Students (
    Id INT PRIMARY KEY,  -- Same as User's Id
    FOREIGN KEY (Id) REFERENCES Users(Id)  -- Foreign Key Reference to Users table
);

CREATE TABLE Teachers (
    Id INT PRIMARY KEY,  -- Same as User's Id
    FOREIGN KEY (Id) REFERENCES Users(Id)  -- Foreign Key Reference to Users table
);


SELECT * FROM Users
SELECT * FROM Students
SELECT * FROM Teachers
SELECT * FROM TimeTables

-- Step 1: Delete from child tables
DELETE FROM Teachers;
DELETE FROM Students;
DELETE FROM TimeTables;

-- Step 2: Delete from Users
DELETE FROM Users;

-- Step 3: Reset identity (if needed)
DBCC CHECKIDENT ('Users', RESEED, 0);


