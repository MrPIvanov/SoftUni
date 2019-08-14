--USE Airport
--GO

SELECT temp.FirstName, temp.LastName, temp.Destination, temp.Price
  FROM (
			SELECT p.FirstName, p.LastName, t.FlightId, f.Destination, t.Price,
			ROW_NUMBER() OVER (PARTITION BY p.Id ORDER BY t.Price DESC ) AS [Rank]
			 FROM Passengers AS p
			 JOIN Tickets AS t ON t.PassengerId = p.Id
			 JOIN Flights AS f ON f.Id = t.FlightId) AS temp 
WHERE temp.[Rank] = 1
ORDER BY Price DESC, FirstName, LastName, Destination