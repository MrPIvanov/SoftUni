--USE Supermarket
--GO

SELECT TOP(1) oi.OrderId, SUM(i.Price * oi.Quantity) AS [TotalPrice]
   FROM OrderItems AS oi
   JOIN Items AS i ON i.Id = oi.ItemId
   GROUP BY OrderId
  ORDER BY TotalPrice DESC