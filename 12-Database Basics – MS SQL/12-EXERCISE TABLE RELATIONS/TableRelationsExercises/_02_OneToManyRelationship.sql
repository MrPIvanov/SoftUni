CREATE DATABASE TableRelationsDB
GO

USE TableRelationsDB
GO

CREATE TABLE Manufacturers(
	ManufacturerID INT CONSTRAINT PK_Manufacturers PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	EstablishedOn DATE NOT NULL
)
GO

CREATE TABLE Models(
	ModelID INT CONSTRAINT PK_Models PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	ManufacturerID INT CONSTRAINT FK_Models_Manufacturers REFERENCES Manufacturers(ManufacturerID) NOT NULL
)
GO

INSERT INTO Manufacturers VALUES
(1, 'BMW', '07/03/1916'),
(2, 'Tesla', '01/01/2003'),
(3, 'Lada', '01/05/1966')
GO

INSERT INTO Models VALUES
(101, 'X1', 1),
(102, 'i6', 1),
(103, 'Model S', 2),
(104, 'Model X', 2),
(105, 'Model 3', 2),
(106, 'Nova', 3)
GO

USE master
GO

DROP DATABASE TableRelationsDB
GO