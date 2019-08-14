--USE Airport
--GO

SELECT p.FirstName, p.LastName, COUNT(t.Id) AS [TotalTrips]
  FROM Passengers AS p
  LEFT JOIN Tickets AS t ON t.PassengerId = p.Id
  GROUP BY p.FirstName, p.LastName
  ORDER BY TotalTrips DESC, p.FirstName, p.LastName