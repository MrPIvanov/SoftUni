USE SoftUni
GO

--We need this old function for this solution
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
--End 

--This is the solution
CREATE OR ALTER PROCEDURE usp_EmployeesBySalaryLevel @salaryLevel VARCHAR(10) AS
BEGIN
	 SELECT FirstName, LastName
	   FROM Employees
      WHERE dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel
END
GO
--End

EXEC usp_EmployeesBySalaryLevel 'High'
GO

DROP PROCEDURE usp_EmployeesBySalaryLevel
GO

DROP FUNCTION ufn_GetSalaryLevel
GO