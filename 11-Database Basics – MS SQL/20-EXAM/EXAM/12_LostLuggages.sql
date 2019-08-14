--USE Airport
--GO

SELECT p.PassportId, p.Address
  FROM Passengers AS p
  LEFT JOIN Luggages AS l ON l.PassengerId = p.Id
  WHERE l.Id IS NULL
  ORDER BY p.PassportId, p.Address