USE SoftUni
GO

SELECT TOP (10) FirstName, LastName, DepartmentID
  FROM Employees AS main
WHERE Salary > (SELECT AVG(Salary) 
				FROM Employees AS e
				WHERE main.DepartmentID = e.DepartmentID 
				GROUP BY DepartmentID ) 
ORDER BY DepartmentID