USE Bank
GO

CREATE OR ALTER PROCEDURE usp_DepositMoney
(
                 @accountId   INT,
                 @moneyAmount MONEY
)
AS
     BEGIN
         IF(@moneyAmount < 0)
             BEGIN
                 RAISERROR('Cannot deposit negative value', 16, 1);
         END;
             ELSE
             BEGIN
                 IF(@accountId IS NULL
                    OR @moneyAmount IS NULL)
                     BEGIN
                         RAISERROR('Missing value', 16, 1);
                 END;
         END;
         BEGIN TRANSACTION;
         UPDATE Accounts
           SET
               Balance+=@moneyAmount
         WHERE Id = @accountId;
         IF(@@ROWCOUNT < 1)
             BEGIN
                 ROLLBACK;
                 RAISERROR('Account doesn''t exists', 16, 1);
         END;
         COMMIT;
     END;
GO

BEGIN TRANSACTION

EXEC usp_DepositMoney 1, 10
SELECT *
  FROM Accounts
 WHERE Id = 1

ROLLBACK
GO

DROP PROCEDURE usp_DepositMoney
GO