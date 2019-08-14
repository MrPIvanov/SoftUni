--USE Supermarket
--GO



SELECT DAY(o.DateTime) AS [Day], CAST(AVG(i.Price * oi.Quantity)  AS decimal(15, 2)) AS [TotalProfit]
  FROM Orders AS o
  JOIN OrderItems AS oi ON oi.OrderId = o.Id
  JOIN Items AS i ON i.Id = oi.ItemId
GROUP BY DAY(o.DateTime)
ORDER BY [Day] ASC