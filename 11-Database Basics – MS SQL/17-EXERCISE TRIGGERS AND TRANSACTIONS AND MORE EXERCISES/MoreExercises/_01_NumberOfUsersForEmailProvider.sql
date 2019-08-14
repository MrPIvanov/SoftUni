USE Diablo
GO

SELECT [Email Provider],
       COUNT([Email Provider]) AS [Number Of Users]
FROM
(
    SELECT Email,
           SUBSTRING(Email, CHARINDEX('@', Email, 1)+1, LEN(Email)-CHARINDEX('@', Email, 1)) AS [Email Provider]
    FROM Users
) AS ins
GROUP BY [Email Provider]
ORDER BY [Number Of Users] DESC,
         [Email Provider];
GO