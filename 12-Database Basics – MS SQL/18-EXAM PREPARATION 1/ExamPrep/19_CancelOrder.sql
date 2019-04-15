--USE Supermarket
--GO

CREATE PROCEDURE usp_CancelOrder(@OrderId INT, @CancelDate DATETIME)
AS
BEGIN
	DECLARE @order INT = (SELECT Id FROM Orders WHERE Id = @OrderId)

	IF (@order IS NULL)
	BEGIN
		;THROW 51000, 'The order does not exist!', 1
	END

	DECLARE @OrderDate DATETIME = (SELECT [DateTime] FROM Orders WHERE Id = @OrderId)
	DECLARE @DateDiff INT = (SELECT DATEDIFF(DAY, @OrderDate, @CancelDate))

	IF (@DateDiff > 3)
	BEGIN
		;THROW 51000, 'You cannot cancel the order!', 2
	END

	DELETE FROM OrderItems
	WHERE OrderId = @OrderId

	DELETE FROM Orders
	WHERE Id = @OrderId
END