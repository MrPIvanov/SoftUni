USE Geography
GO

WITH CTE_CountryPeaks ( [Country], [Highest Peak Name], [Highest Peak Elevation], [Mountain]) AS (
SELECT c.CountryName AS [Country], p.PeakName AS [Highest Peak Name],
	   MAX(p.Elevation) AS [Highest Peak Elevation], m.MountainRange AS [Mountain]	
  FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
LEFT JOIN Peaks AS p ON p.MountainId = m.Id
GROUP BY c.CountryName, p.PeakName, m.MountainRange)

SELECT TOP (5) c.Country, 
		ISNULL(cte.[Highest Peak Name], '(no highest peak)') AS [Highest Peak Name],
		ISNULL(cte.[Highest Peak Elevation], 0) AS [Highest Peak Elevation],
		ISNULL(cte.Mountain, '(no mountain)' ) AS [Mountain]
FROM (
SELECT Country, MAX([Highest Peak Elevation]) AS MaxPeakElevation
  FROM CTE_CountryPeaks
GROUP BY Country) AS c
LEFT JOIN CTE_CountryPeaks AS cte ON cte.Country = c.Country AND cte.[Highest Peak Elevation] = c.MaxPeakElevation
ORDER BY c.Country, cte.[Highest Peak Name]
GO