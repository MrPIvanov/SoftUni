--USE Airport
--GO

DELETE FROM Tickets
WHERE FlightId = 30

DELETE FROM Flights
WHERE Destination = 'Ayn Halagim'

SELECT *FROM Flights
WHERE Destination = 'Ayn Halagim'