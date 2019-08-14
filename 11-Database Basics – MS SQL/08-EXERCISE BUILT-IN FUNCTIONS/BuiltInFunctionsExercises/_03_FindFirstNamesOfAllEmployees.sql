USE SoftUni
GO

SELECT FirstName
  FROM Employees
 WHERE  DATEPART(year,HireDate) < 2006 AND DATEPART(year,HireDate) > 1995 AND DepartmentID IN (3, 10)