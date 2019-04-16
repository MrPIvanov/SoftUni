--USE Airport
--GO

SELECT lt.Type, COUNT(p.Id) AS [MostUsedLuggage]
  FROM LuggageTypes AS lt
  JOIN Luggages AS l ON l.LuggageTypeId = lt.Id
  JOIN Passengers AS p ON p.Id = l.PassengerId
  GROUP BY lt.Type
  ORDER BY MostUsedLuggage DESC, lt.Type