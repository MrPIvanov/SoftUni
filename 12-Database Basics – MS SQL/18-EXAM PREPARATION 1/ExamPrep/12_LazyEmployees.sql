--USE Supermarket
--GO

SELECT DISTINCT e.Id, e.FirstName + ' ' + e.LastName AS [Full Name]
  FROM Employees AS e
  JOIN Shifts AS s ON s.EmployeeId = e.Id
  WHERE DATEDIFF(hour, s.CheckIn, s.CheckOut) < 4
  ORDER BY e.Id
