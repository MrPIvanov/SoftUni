CREATE DATABASE TableRelationsDB
GO

USE TableRelationsDB
GO

CREATE TABLE Students(
	StudentID INT CONSTRAINT PK_Students PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Exams(
	ExamID INT CONSTRAINT PK_Exams PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)
GO

CREATE TABLE StudentsExams(
	StudentID INT CONSTRAINT FK_StudentsExams_Students FOREIGN KEY REFERENCES Students(StudentID) NOT NULL,
	ExamID INT CONSTRAINT FK_StudentsExams_Exams FOREIGN KEY REFERENCES Exams(ExamID) NOT NULL,

	CONSTRAINT PK_StudentsExams PRIMARY KEY (StudentID, ExamID)
)
GO

INSERT INTO Students VALUES
(1, 'Mila'),
(2, 'Toni'),
(3, 'Ron')
GO

INSERT INTO Exams VALUES
(101, 'SpringMVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g')
GO

INSERT INTO StudentsExams VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)
GO

USE master
GO

DROP DATABASE TableRelationsDB
GO