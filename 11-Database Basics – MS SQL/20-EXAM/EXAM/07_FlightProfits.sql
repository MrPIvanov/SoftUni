--USE Airport
--GO

SELECT f.Id, SUM(t.Price) AS Price
FROM Flights AS f
JOIN Tickets AS t ON t.FlightId = f.Id
GROUP BY f.id
ORDER BY Price DESC, f.Id