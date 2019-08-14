USE SoftUni
GO

CREATE OR ALTER PROCEDURE usp_AssignProject
(
                 @emloyeeId INT,
                 @projectID INT
)
AS
     BEGIN
         BEGIN TRANSACTION;
         INSERT INTO EmployeesProjects(EmployeeID,
                                       ProjectID
                                      )
         VALUES
         (
                @emloyeeId,
                @projectID
         );
         IF(
           (
               SELECT COUNT(EmployeeID)
               FROM EmployeesProjects
               WHERE EmployeeID = @emloyeeId
           ) > 3)
             BEGIN
                 ROLLBACK;
                 RAISERROR('The employee has too many projects!', 16, 1);
         END;
         COMMIT;
     END;
GO

DROP PROCEDURE usp_AssignProject
GO