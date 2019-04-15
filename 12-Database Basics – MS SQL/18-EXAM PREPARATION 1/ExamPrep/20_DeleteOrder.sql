--USE Supermarket
--GO


--CREATE TABLE DeletedOrders
--(
--	OrderId INT,
--	ItemId INT,
--	ItemQuantity INT
--)

GO
CREATE TRIGGER t_DeleteOrders
    ON OrderItems AFTER DELETE
    AS
    BEGIN
	  INSERT INTO DeletedOrders (OrderId, ItemId, ItemQuantity)
	  SELECT d.OrderId, d.ItemId, d.Quantity
	    FROM deleted AS d
    END


