USE Bank
GO

CREATE OR ALTER PROCEDURE usp_GetHoldersWithBalanceHigherThan (@money DECIMAL (15,4))
AS 
BEGIN
WITH CTE_AccountHolderBalance (AccountHolderId, Balance) AS (
	SELECT AccountHolderId, SUM(Balance) AS [TotalBalance]
	  FROM Accounts
  GROUP BY AccountHolderId )

  SELECT ah.FirstName, ah.LastName
    FROM AccountHolders AS ah
	JOIN CTE_AccountHolderBalance AS cte ON cte.AccountHolderId = ah.Id
	WHERE cte.Balance > @money
	ORDER BY ah.LastName ASC, ah.FirstName ASC
END;
GO

EXEC usp_GetHoldersWithBalanceHigherThan 7000
GO

DROP PROCEDURE usp_GetHoldersWithBalanceHigherThan
GO