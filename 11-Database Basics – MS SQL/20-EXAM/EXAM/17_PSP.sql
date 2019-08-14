 --USE Airport
--GO
 
  SELECT p.Name, p.Seats, COUNT(t.Id) AS [Count]
    FROM Tickets AS t
	JOIN Flights AS f ON f.Id = t.FlightId
	RIGHT JOIN Planes AS p ON p.Id = f.PlaneId
	GROUP BY p.Id, p.Seats, p.Name
ORDER BY Count DESC, p.Name, p.Seats