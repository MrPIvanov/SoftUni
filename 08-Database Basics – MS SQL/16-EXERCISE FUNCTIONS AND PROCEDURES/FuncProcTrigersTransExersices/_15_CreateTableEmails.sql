USE Bank
GO

CREATE TABLE NotificationEmails
(
             Id        INT NOT NULL IDENTITY,
             Recipient INT NOT NULL,
             Subject   NVARCHAR(50) NOT NULL,
             Body      NVARCHAR(255) NOT NULL,
             CONSTRAINT PK_NotificationEmails PRIMARY KEY(Id)
);
GO

CREATE OR ALTER TRIGGER tr_Logs_NotificationEmails ON Logs
FOR INSERT
AS
     BEGIN
         INSERT INTO NotificationEmails
         VALUES
         (
         (
             SELECT AccountId
             FROM Logs
         ),
         CONCAT('Balance change for account: ',
               (
                   SELECT AccountId
                   FROM Logs
				 
               )),
         CONCAT('On ', FORMAT(GETDATE(), 'dd-MM-yyyy HH:mm'), ' your balance was changed from ',
               (
                   SELECT OldSum
                   FROM Logs
               ), ' to ',
               (
                   SELECT NewSum
                   FROM Logs
               ), '.')
         );
     END;
	 GO

UPDATE Accounts
   SET Balance = 99.12
 WHERE Id = 1
GO

SELECT *
  FROM NotificationEmails
GO