USE Diablo
GO

SELECT [Name],
CASE
    WHEN DATEPART(hour, Start) >= 0 AND DATEPART(hour, Start) < 12 THEN 'Morning'
    WHEN DATEPART(hour, Start) >= 12 AND DATEPART(hour, Start) < 18 THEN 'Afternoon'
    ELSE 'Evening'
END AS [Part of the Day],
CASE
    WHEN Duration <= 3 THEN 'Extra Short'
    WHEN Duration IN (4,5,6) THEN 'Short'
	WHEN Duration > 6 THEN 'Long'
	WHEN Duration IS NULL THEN 'Extra Long'
END AS [Duration]
  FROM Games
ORDER BY [Name] ASC, [Duration] ASC, [Part of the Day] ASC