USE SoftUni
GO

SELECT *
  INTO NewEmployees
  FROM Employees
 WHERE Salary > 30000
 GO

DELETE 
  FROM NewEmployees
 WHERE ManagerID = 42
 GO

UPDATE NewEmployees
SET Salary += 5000
WHERE DepartmentID = 1
GO

SELECT DepartmentID, AVG(Salary)
  FROM NewEmployees
GROUP BY DepartmentID
GO

DROP TABLE NewEmployees
GO