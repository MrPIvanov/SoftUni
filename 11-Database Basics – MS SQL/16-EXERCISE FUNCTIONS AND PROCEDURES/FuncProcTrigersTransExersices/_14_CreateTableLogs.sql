USE Bank
GO

CREATE TABLE Logs(
LogId INT IDENTITY NOT NULL,
AccountId INT NOT NULL,
OldSum DECIMAL(15,2) NOT NULL,
NewSum DECIMAL(15,2) NOT NULL
)
GO

CREATE OR ALTER TRIGGER tr_Accounts
ON Accounts
AFTER UPDATE
AS
BEGIN
	DECLARE @accountID INT = (
		SELECT Id FROM inserted
	)

	DECLARE @oldSum DECIMAL (15,2) = (
		SELECT Balance FROM deleted
	)

	DECLARE @newSum DECIMAL (15,2) = (
		SELECT Balance FROM inserted
	)

	INSERT INTO Logs VALUES 
	(@accountID, @oldSum, @newSum)
END
GO

UPDATE Accounts
   SET Balance = 99.12
 WHERE Id = 1
GO

SELECT *
  FROM Logs
GO