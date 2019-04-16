--USE Airport
--GO

SELECT f.Destination, COUNT(t.Id) AS [Count]
  FROM Flights AS f
  LEFT JOIN Tickets AS t ON t.FlightId = f.Id
  GROUP BY f.Destination
  ORDER BY Count DESC, f.Destination
