CREATE DATABASE Movies
GO

USE Movies
GO

CREATE TABLE Directors(
Id INT PRIMARY KEY IDENTITY,
DirectorName NVARCHAR(50) NOT NULL,
Notes NVARCHAR(MAX)
)
GO

INSERT INTO Directors(DirectorName, Notes) VALUES
('Ivan', NULL),
('Niki', 'Nqkvi notes'),
('Ivan2', NULL),
('Niki2', 'Nqkvi notes2'),
('Ivan3', NULL)
GO

CREATE TABLE Genres(
Id INT PRIMARY KEY IDENTITY,
GenreName NVARCHAR(50) NOT NULL,
Notes NVARCHAR(MAX)
)
GO

INSERT INTO Genres(GenreName, Notes) VALUES
('horror', NULL),
('comedy', 'Nqkvi notes'),
('horror2', NULL),
('comedy2', 'Nqkvi notes2'),
('horror3', NULL)
GO

CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
CategoryName NVARCHAR(50) NOT NULL,
Notes NVARCHAR(MAX)
)
GO

INSERT INTO Categories(CategoryName, Notes) VALUES
('horrors', NULL),
('comedys', 'Nqkvi notes'),
('horrors2', NULL),
('comedys2', 'Nqkvi notes2'),
('horrors3', NULL)
GO

CREATE TABLE Movies(
Id INT PRIMARY KEY IDENTITY,
Title NVARCHAR(50) NOT NULL,
DirectorId INT FOREIGN KEY REFERENCES Directors(Id) NOT NULL,
CopyrightYear DATETIME NOT NULL,
Lenght INT NOT NULL,
GenreId INT FOREIGN KEY REFERENCES Genres(Id) NOT NULL,
CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
Rating DECIMAL(15,2) NOT NULL,
Notes NVARCHAR(MAX)
)
GO

INSERT INTO Movies(Title, DirectorId, CopyrightYear, Lenght, GenreId, CategoryId, Rating, Notes) VALUES
('Movie1', 1, CONVERT(DATETIME, '23-5-2014', 103), 56, 1, 1, 5.1, 'Notes1'),
('Movie2', 2, CONVERT(DATETIME, '21-5-2014', 103), 56, 2, 2, 5.2, 'Notes2'),
('Movie3', 3, CONVERT(DATETIME, '28-5-2014', 103), 56, 3, 3, 5.3, 'Notes3'),
('Movie4', 4, CONVERT(DATETIME, '4-2-2014', 103), 56, 4, 4, 5.4, 'Notes4'),
('Movie5', 5, CONVERT(DATETIME, '1-8-2014', 103), 56, 5, 5, 5.5, 'Notes5')
GO