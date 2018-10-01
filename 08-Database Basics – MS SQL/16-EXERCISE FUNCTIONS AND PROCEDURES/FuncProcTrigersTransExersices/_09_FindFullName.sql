USE Bank
GO

CREATE OR ALTER PROCEDURE usp_GetHoldersFullName
AS 
BEGIN
	SELECT FirstName + ' ' + LastName AS [Full Name]
	  FROM AccountHolders
END;
GO

EXEC usp_GetHoldersFullName
GO

DROP PROCEDURE usp_GetHoldersFullName
GO