--USE Supermarket
--GO

SELECT FirstName + ' ' + LastName AS [Full Name], Phone AS [Phone Number]
  FROM Employees
  WHERE phone LIKE ('3%')
  ORDER BY FirstName, Phone