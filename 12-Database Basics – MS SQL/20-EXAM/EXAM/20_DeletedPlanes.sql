--USE Airport
--GO

--CREATE TABLE DeletedPlanes
--(
--	Id INT,
--	[Name] NVARCHAR(MAX),
--	Seats INT,
--	[Range] INT
--)

GO
CREATE TRIGGER t_DeletePlanes
    ON Planes AFTER DELETE
    AS
    BEGIN
	  INSERT INTO DeletedPlanes (Id, [Name], Seats, Range)
	  SELECT d.Id, d.Name, d.Seats, d.Range
	    FROM deleted AS d
    END
GO

DELETE Tickets
WHERE FlightId IN (SELECT Id FROM Flights WHERE PlaneId = 8)

DELETE FROM Flights
WHERE PlaneId = 8

DELETE FROM Planes
WHERE Id = 8
