USE Geography
GO

SELECT cont.ContinentName,
       SUM(CAST(cntr.AreaInSqKm AS BIGINT)) AS CountriesArea,
       SUM(CAST(cntr.[Population] AS BIGINT)) AS CountriesPopulation
FROM Continents AS cont
     JOIN Countries AS cntr ON cntr.ContinentCode = cont.ContinentCode
	GROUP BY ContinentName
ORDER BY CountriesPopulation DESC;
GO