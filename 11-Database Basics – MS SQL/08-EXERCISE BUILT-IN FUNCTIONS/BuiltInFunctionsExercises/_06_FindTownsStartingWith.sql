USE SoftUni
GO

SELECT *
  FROM Towns
 WHERE [Name] LIKE '[M, K, B, E]%'
ORDER BY [Name] ASC