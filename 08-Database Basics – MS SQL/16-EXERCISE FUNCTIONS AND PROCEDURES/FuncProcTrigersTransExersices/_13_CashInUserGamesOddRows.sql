USE Diablo
GO

CREATE OR ALTER FUNCTION ufn_CashInUsersGames (@gameName VARCHAR(50))
RETURNS TABLE
AS 
RETURN (
	SELECT SUM(e.Cash) AS [SumCash] FROM (
	SELECT ug.Cash, ROW_NUMBER() OVER(ORDER BY ug.Cash DESC) AS [RowNumber]
	  FROM Games AS g
	  JOIN UsersGames AS ug ON ug.GameId = g.Id 
	  WHERE g.Name = @gameName ) AS e
	  WHERE e.RowNumber % 2 = 1
	)
GO

SELECT * FROM dbo.ufn_CashInUsersGames ('Lily Stargazer')
GO

DROP FUNCTION ufn_CashInUsersGames
GO