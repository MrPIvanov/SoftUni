CREATE DATABASE CarRental
GO

USE CarRental
GO

CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
CategoryName NVARCHAR(50) NOT NULL,
DailyRate DECIMAL(15,2) NOT NULL,
WeeklyRate DECIMAL(15,2) NOT NULL,
MonthlyRate DECIMAL(15,2) NOT NULL,
WeekendRate DECIMAL(15,2) NOT NULL,
)
GO

INSERT INTO Categories(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
('Category1', 1.1, 2.2, 3.3, 4.4),
('Category2', 1.1, 2.2, 3.3, 4.4),
('Category3', 1.0, 2.1, 3.2, 4.3)
GO

CREATE TABLE Cars(
Id INT PRIMARY KEY IDENTITY,
PlateNumber NVARCHAR(50) NOT NULL,
Manufacturer NVARCHAR(50) NOT NULL,
Model NVARCHAR(50) NOT NULL,
CarYear DATETIME NOT NULL,
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
Doors INT NOT NULL,
Picture VARBINARY(MAX),
Condition NVARCHAR(50) NOT NULL,
Available BIT NOT NULL
)
GO

INSERT INTO Cars(PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) VALUES
('CA 23 54 TC', 'Test', 'Tesla', CONVERT(DATETIME, 23-4-2012, 103), 1, 3, NULL, 'Perfect', 0), 
('CA 21 54 TC', 'Test', 'Tesla', CONVERT(DATETIME, 23-4-2012, 103), 2, 3, NULL, 'Perfect', 0), 
('CA 22 54 TC', 'Test', 'Tesla', CONVERT(DATETIME, 23-4-2012, 103), 3, 3, NULL, 'Perfect', 0)
GO

CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL,
Title NVARCHAR(50) NOT NULL,
Notes NVARCHAR(50)
)
GO

INSERT INTO Employees(FirstName, LastName, Title, Notes) VALUES
('Ivan', 'Ivanov', 'Shef', NULL),
('Ivan', 'Ivanov', 'Shef', NULL),
('Ivan', 'Ivanov', 'Shef', NULL)
GO

CREATE TABLE Customers(
Id INT PRIMARY KEY IDENTITY,
DriverLicenceNumber INT NOT NULL,
FullName NVARCHAR(50) NOT NULL,
[Address] NVARCHAR(50) NOT NULL,
City NVARCHAR(50) NOT NULL,
ZIPCode INT NOT NULL,
Notes NVARCHAR(50)
)
GO

INSERT INTO Customers(DriverLicenceNumber, FullName, [Address], City, ZIPCode, Notes) VALUES
(12345, 'Pesho', 'SLatina', 'Sofia', 1234, Null),
(123222245, 'Pesho2', 'SLatina5', 'Sofi5a', 1234, Null),
(123323245, 'Pesho2', 'SLatina1', 'Sofi5a', 1234, Null)
GO

CREATE TABLE RentalOrders(
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
CarId INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
TankLevel DECIMAL(15,2) NOT NULL,
KilometrageStart DECIMAL(15,2) NOT NULL,
KilometrageEnd DECIMAL(15,2) NOT NULL,
TotalKilometrage DECIMAL(15,2) NOT NULL,
StartDate DATETIME NOT NULL,
EndDate DATETIME NOT NULL,
TotalDays INT NOT NULL,
RateApplied DECIMAL(15,2) NOT NULL, 
TaxRate DECIMAL(15,2) NOT NULL, 
OrderStatus BIT NOT NULL,
Notes NVARCHAR(50)
)
GO

INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage,
StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes) VALUES
(1, 2, 3, 45, 12345, 12348, 3, CONVERT(DATETIME, 23-4-2012, 103), CONVERT(DATETIME, 25-4-2012, 103), 2, 1.4, 0.6, 0, NULL),
(1, 2, 3, 45, 12345, 12348, 3, CONVERT(DATETIME, 23-4-2012, 103), CONVERT(DATETIME, 25-4-2012, 103), 2, 1.4, 0.6, 0, NULL),
(1, 2, 3, 45, 12345, 12348, 3, CONVERT(DATETIME, 23-4-2012, 103), CONVERT(DATETIME, 25-4-2012, 103), 2, 1.4, 0.6, 0, NULL)
GO