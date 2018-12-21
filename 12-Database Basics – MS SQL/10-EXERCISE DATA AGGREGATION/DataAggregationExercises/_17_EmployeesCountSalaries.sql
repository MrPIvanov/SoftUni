USE SoftUni
GO

SELECT COUNT(EmployeeID) AS [Count]
  FROM Employees
 WHERE ManagerID IS NULL