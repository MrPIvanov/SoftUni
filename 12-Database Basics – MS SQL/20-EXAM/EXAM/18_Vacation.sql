--USE Airport
--GO

GO
CREATE FUNCTION udf_CalculateTickets(@origin VARCHAR(MAX), @destination VARCHAR(MAX), @peopleCount INT)
RETURNS VARCHAR(MAX)
AS
BEGIN
	DECLARE @FirstItemPrice DECIMAL(15,2) = (SELECT t.Price * @peopleCount
    FROM Flights AS f
	JOIN Tickets AS t ON t.FlightId = f.Id
	WHERE f.Origin = @origin AND f.Destination = @destination)

	IF (@peopleCount <= 0)
	BEGIN
	 RETURN 'Invalid people count!'
	END

	IF (@FirstItemPrice IS NULL)
	BEGIN
	 RETURN 'Invalid flight!'
	END
	

	RETURN 'Total price ' + CAST(ROUND(@FirstItemPrice,2) as varchar)
END
GO

SELECT dbo.udf_CalculateTickets('Kolyshley','Rancabolang', 33)
SELECT dbo.udf_CalculateTickets('Kolyshley','Rancabolang', -1)
SELECT dbo.udf_CalculateTickets('Invalid','Rancabolang', 33)
