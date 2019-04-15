--USE Supermarket
--GO

SELECT i.Name AS Item, c.Name AS [Category], SUM(oi.Quantity) AS [Count], SUM(i.Price * oi.Quantity) AS [TotalPrice]
  FROM Items AS i
  JOIN Categories AS c ON c.Id = i.CategoryId
  LEFT JOIN OrderItems AS oi ON oi.ItemId = i.Id
  LEFT JOIN Orders AS o ON o.Id = oi.OrderId
  GROUP BY i.Name, c.Name
  ORDER BY TotalPrice DESC