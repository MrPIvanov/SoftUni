USE Bank
GO

CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@sum DECIMAL (15,4), @interestRate FLOAT, @years INT)
RETURNS DECIMAL(15,4)
AS 
BEGIN
	DECLARE @result DECIMAL(15,4) = 5

	SET @result = @sum * (POWER((1+@interestRate), @years))

	RETURN @result
END;
GO

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5) AS [Output]
GO

DROP FUNCTION ufn_CalculateFutureValue
GO