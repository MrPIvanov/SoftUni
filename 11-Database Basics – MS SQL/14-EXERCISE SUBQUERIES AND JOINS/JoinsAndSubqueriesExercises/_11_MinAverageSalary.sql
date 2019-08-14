USE SoftUni
GO

SELECT MIN(e.AverageSalary) AS [MinAverageSalary]
  FROM(
SELECT AVG(Salary) AS [AverageSalary]
  FROM Employees
GROUP BY DepartmentID) AS e
GO