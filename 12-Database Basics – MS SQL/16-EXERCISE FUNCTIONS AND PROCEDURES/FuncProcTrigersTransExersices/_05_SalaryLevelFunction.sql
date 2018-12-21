USE SoftUni
GO

CREATE OR ALTER FUNCTION ufn_GetSalaryLevel (@salary DECIMAL(18,4)) 
RETURNS VARCHAR(10)
AS 
BEGIN
DECLARE @salaryLevel VARCHAR(10)

IF(@salary < 30000)
BEGIN
	SET @salaryLevel = 'Low'
END

ELSE IF(@salary <= 50000)
BEGIN
	SET @salaryLevel = 'Average'
END

ELSE
BEGIN
	SET @salaryLevel = 'High'
END

RETURN @salaryLevel
END;
GO

SELECT Salary, dbo.ufn_GetSalaryLevel(Salary) AS [Salary Level]
  FROM Employees
GO

DROP FUNCTION ufn_GetSalaryLevel
GO