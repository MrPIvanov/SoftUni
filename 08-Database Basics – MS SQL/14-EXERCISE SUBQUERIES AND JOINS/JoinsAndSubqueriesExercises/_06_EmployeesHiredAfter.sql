USE SoftUni
GO

SELECT e.FirstName, e.LastName, e.HireDate, d.Name
  FROM Employees AS e
  JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
WHERE d.Name IN ('Sales','Finance')
ORDER BY e.HireDate
GO