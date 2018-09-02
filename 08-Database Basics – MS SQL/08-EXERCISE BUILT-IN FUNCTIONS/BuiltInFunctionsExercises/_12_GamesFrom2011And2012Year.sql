USE Diablo
GO

SELECT TOP(50) [Name], FORMAT([Start], 'yyyy-MM-dd') AS [Start]
  FROM Games
 WHERE DATEPART(year, [Start]) IN (2011, 2012)
ORDER BY [Start] ASC, [Name] ASC