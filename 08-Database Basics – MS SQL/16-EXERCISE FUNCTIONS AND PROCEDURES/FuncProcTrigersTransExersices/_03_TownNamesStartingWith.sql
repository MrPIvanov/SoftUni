USE SoftUni
GO

CREATE OR ALTER PROCEDURE usp_GetTownsStartingWith @text VARCHAR(50) AS (
SELECT [Name]
  FROM Towns
 WHERE [Name] LIKE @text + '%'
)
GO

EXEC usp_GetTownsStartingWith 'b'
GO

DROP PROCEDURE usp_GetTownsStartingWith
GO