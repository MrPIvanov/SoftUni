USE Minions

CREATE TABLE People(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(200) NOT NULL,
Picture VARBINARY(MAX),
Height DECIMAL(15,2),
[Weight] DECIMAL(15,2),
Gender VARCHAR NOT NULL,
Birthdate DATETIME NOT NULL,
Biography NVARCHAR(MAX)
)

INSERT INTO People([Name], Picture, Height, [Weight], Gender, Birthdate, Biography) VALUES
('Ivan', NULL, 4.5, 6.7, 'm', CONVERT(DATETIME, '25-5-2012', 103), NULL),
('Gosho', NULL, 6.5, 2.7, 'm', CONVERT(DATETIME, '5-5-2012', 103), NULL),
('Pesho', NULL, 7.5, 6.7, 'f', CONVERT(DATETIME, '25-6-2012', 103), NULL),
('Stamat', NULL, 8.5, 9.7, 'm', CONVERT(DATETIME, '25-9-2010', 103), NULL),
('Niki', NULL, 9.5, 3.7, 'm', CONVERT(DATETIME, '5-5-2002', 103), NULL)