CREATE DATABASE TableRelationsDB
GO

USE TableRelationsDB
GO

CREATE TABLE Teachers(
	TeacherID INT CONSTRAINT PK_Teachers PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	ManagerID INT CONSTRAINT FK_Teachers_Teachers FOREIGN KEY REFERENCES Teachers(TeacherID)
)
GO

INSERT INTO Teachers VALUES
(101, 'John', NULL),
(102, 'Maya', 106),
(103, 'Silvia', 106),
(104, 'Ted', 105),
(105, 'Mark', 101),
(106, 'Greta', 101)
GO

USE master
GO

DROP DATABASE TableRelationsDB
GO