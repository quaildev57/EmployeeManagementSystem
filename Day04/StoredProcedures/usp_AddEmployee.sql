USE EmployeeManagementDB;
GO

DROP PROCEDURE IF EXISTS AddEmployee;
GO

CREATE PROCEDURE AddEmployee
(
    @FullName VARCHAR(100),
    @Gender VARCHAR(10),
    @DOB DATE,
    @Address VARCHAR(255),
    @Phone VARCHAR(255),
    @Email VARCHAR(100),
    @DeptID INT,
    @UserID INT,
    @JoinDate DATE,
    @Salary DECIMAL(10,2),
    @IsActive BIT
)
AS
BEGIN
    INSERT INTO Employees
    (
        FullName,
        Gender,
        DOB,
        Address,
        Phone,
        Email,
        DeptID,
        UserID,
        JoinDate,
        Salary,
        IsActive
    )
    VALUES
    (
        @FullName,
        @Gender,
        @DOB,
        @Address,
        @Phone,
        @Email,
        @DeptID,
        @UserID,
        @JoinDate,
        @Salary,
        @IsActive
    )
END
GO