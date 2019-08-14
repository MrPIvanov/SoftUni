--USE Airport
--GO

SELECT p.FirstName + ' ' + p.LastName AS [FullName], pl.Name, CONCAT(f.Origin, ' - ', f.Destination) AS Trip, lt.Type
  FROM Passengers AS p
  JOIN Tickets AS t On t.PassengerId = p.Id
  JOIN Flights AS f ON f.Id = t.FlightId
  JOIN Planes AS pl ON pl.Id = f.PlaneId
  JOIN Luggages AS l ON l.Id = t.LuggageId
  JOIN LuggageTypes AS lt ON lt.Id = l.luggageTypeId
  ORDER BY FullName,pl.Name, f.Origin, f.Destination, lt.Type