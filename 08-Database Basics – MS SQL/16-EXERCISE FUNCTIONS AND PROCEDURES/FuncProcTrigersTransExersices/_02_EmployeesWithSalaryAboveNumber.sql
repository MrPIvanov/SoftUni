USE SoftUni
GO

CREATE OR ALTER PROCEDURE usp_GetEmployeesSalaryAboveNumber @number DECIMAL(18,4) AS (
SELECT FirstName, LastName
  FROM Employees
 WHERE Salary >= @number
)
GO

EXEC usp_GetEmployeesSalaryAboveNumber 48100
GO

DROP PROCEDURE usp_GetEmployeesSalaryAboveNumber
GO