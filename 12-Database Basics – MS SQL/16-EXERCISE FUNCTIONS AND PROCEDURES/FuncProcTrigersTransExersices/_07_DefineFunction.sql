USE SoftUni
GO

CREATE OR ALTER FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(30), @word VARCHAR(30)) 
RETURNS BIT
AS 
BEGIN
DECLARE @counter INT = 1
DECLARE @result BIT = 1
DECLARE @currentChar CHAR(1)
DECLARE @isComprised INT

WHILE(@counter <= LEN(@word))
BEGIN
	SET @currentChar = SUBSTRING(@word, @counter, 1)
	SET @isComprised = CHARINDEX(@currentChar, @setOfLetters)
	IF(@isComprised = 0)
	BEGIN
		SET @result = 0
	END
	SET @counter += 1
END
RETURN @result
END;
GO

SELECT 'oistmiahf' AS [SetOfLetters], 'Sofia' AS [Word], dbo.ufn_IsWordComprised('oistmiahf', 'Sofia') AS [Result]
GO

DROP FUNCTION ufn_IsWordComprised
GO