USE Geography
GO

WITH CTE_CurrencyInfo (ContinentCode, CurrencyCode, CurrencyUsage) AS (
SELECT c.ContinentCode, c.CurrencyCode, COUNT(c.CurrencyCode) AS [CurrencyUsage]
  FROM Countries AS c
GROUP BY c.ContinentCode, c.CurrencyCode
HAVING COUNT(c.CurrencyCode) >1)

SELECT e.ContinentCode, ct.CurrencyCode, ct.CurrencyUsage FROM (
SELECT ContinentCode, MAX(CurrencyUsage) AS MaxCurrency
  FROM CTE_CurrencyInfo
GROUP BY ContinentCode) AS e
JOIN CTE_CurrencyInfo AS ct ON ct.CurrencyUsage = e.MaxCurrency AND ct.ContinentCode = e.ContinentCode
ORDER BY e.ContinentCode ASC
GO