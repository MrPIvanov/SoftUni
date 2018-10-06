USE Diablo
GO

DECLARE @minMind INT =
(
    SELECT AVG(Mind)
    FROM [Statistics]
);

DECLARE @minLuck INT =
(
    SELECT AVG(Luck)
    FROM [Statistics]
);

DECLARE @minSpeed INT =
(
    SELECT AVG(Speed)
    FROM [Statistics]
);

SELECT i.[Name],
       i.Price,
       i.MinLevel,
       s.Strength,
       s.Defence,
       s.Speed,
       s.Luck,
       s.Mind
FROM Items AS i
     JOIN [Statistics] AS s ON s.Id = i.StatisticId
WHERE s.Mind > @minMind
      AND s.Luck > @minLuck
      AND s.Speed > @minSpeed
ORDER BY i.[Name];
GO