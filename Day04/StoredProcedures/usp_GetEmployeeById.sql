USE EmployeeManagementDB;
GO

DROP PROCEDURE IF EXISTS GetEmployeeById;
GO

CREATE PROCEDURE GetEmployeeById
    @EmpID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE EmpID = @EmpID;
END
GO