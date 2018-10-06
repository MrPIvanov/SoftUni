USE Bank
GO

CREATE OR ALTER PROCEDURE usp_WithdrawMoney
(
                 @accountId   INT,
                 @moneyAmount MONEY
)
AS
     BEGIN
         IF(@moneyAmount < 0)
             BEGIN
                 RAISERROR('Cannot withdraw negative value', 16, 1);
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
               Balance-=@moneyAmount
         WHERE Id = @accountId;
         IF(@@ROWCOUNT < 1)
             BEGIN
                 ROLLBACK;
                 RAISERROR('Account doesn''t exists', 16, 1);
         END;
             ELSE
             BEGIN
                 IF(0 >
                   (
                       SELECT Balance
                       FROM Accounts
                       WHERE Id = @accountId
                   ))
                     BEGIN
                         ROLLBACK;
                         RAISERROR('Balance not enough', 16, 1);
                 END;
         END;
         COMMIT;
     END;
GO

BEGIN TRANSACTION

EXEC usp_WithdrawMoney 5, 25
SELECT *
  FROM Accounts
 WHERE Id = 5

ROLLBACK
GO

DROP PROCEDURE usp_WithdrawMoney
GO