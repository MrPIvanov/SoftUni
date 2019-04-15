--USE Supermarket
--GO

SELECT e.FirstName + ' ' + e.LastName AS [Full Name], DATENAME(weekday, s.CheckIn) AS [Day of week]
  FROM Employees AS e
  JOIN Shifts AS s ON s.EmployeeId = e.Id
LEFT  JOIN Orders AS o ON o.EmployeeId = e.Id
WHERE o.EmployeeId IS NULL AND DATEDIFF(HOUR, s.CheckIn , s.CheckOut ) > 12 
ORDER BY e.Id
