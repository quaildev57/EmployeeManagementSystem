use EmployeeManagementDB;
go

CREATE PROCEDURE DeleteEmployee
(
    @FullName VARCHAR(100),
    @Email VARCHAR(100),
    @Salary DECIMAL(10,2)
)
AS
BEGIN
    DELETE FROM Employees
    WHERE FullName = @FullName
      AND Email = @Email
      AND Salary = @Salary;
END;
GO

EXEC DeleteEmployee
    'Mahi',
    'mahi@gmail.com',
    70000;
SELECT * FROM Employees;