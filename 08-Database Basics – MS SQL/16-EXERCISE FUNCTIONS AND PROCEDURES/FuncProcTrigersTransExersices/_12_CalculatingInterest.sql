USE Bank
GO

--We need this fuction to finish this solution
CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@sum DECIMAL (15,4), @interestRate FLOAT, @years INT)
RETURNS DECIMAL(15,4)
AS 
BEGIN
	DECLARE @result DECIMAL(15,4) = 5

	SET @result = @sum * (POWER((1+@interestRate), @years))

	RETURN @result
END;
GO
--END

CREATE OR ALTER PROCEDURE usp_CalculateFutureValueForAccount (@accountId INT, @interestRate FLOAT)
AS 
BEGIN
	SELECT  ah.Id AS [Account Id], 
			ah.FirstName AS [First Name], 
			ah.LastName AS [Last Name], 
			a.Balance AS [Current Balance], 
			dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, 5) AS [Balance in 5 years]
	  FROM AccountHolders AS ah
	  JOIN Accounts AS a ON a.Id = ah.Id
	 WHERE ah.Id= @accountId
END;
GO

EXEC usp_CalculateFutureValueForAccount 1, 0.1
GO

DROP PROCEDURE usp_CalculateFutureValueForAccount
GO

DROP FUNCTION ufn_CalculateFutureValue
GO