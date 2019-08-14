USE SoftUni
GO

CREATE OR ALTER PROCEDURE usp_GetEmployeesFromTown @townName VARCHAR(50) AS (
SELECT e.FirstName, e.LastName
  FROM Employees AS e
  JOIN Addresses AS a ON a.AddressID = e.AddressID
  JOIN Towns AS t ON t.TownID = a.TownID
 WHERE t.[Name] LIKE @townName
)
GO

EXEC usp_GetEmployeesFromTown 'Sofia'
GO

DROP PROCEDURE usp_GetEmployeesFromTown
GO