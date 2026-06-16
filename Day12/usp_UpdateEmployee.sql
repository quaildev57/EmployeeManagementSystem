DROP PROCEDURE IF EXISTS UpdateEmployee;
GO

CREATE PROCEDURE UpdateEmployee
(
    @EmpID INT,
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
    UPDATE Employees
    SET
        FullName = @FullName,
        Gender = @Gender,
        DOB = @DOB,
        Address = @Address,
        Phone = @Phone,
        Email = @Email,
        DeptID = @DeptID,
        UserID = @UserID,
        JoinDate = @JoinDate,
        Salary = @Salary,
        IsActive = @IsActive
    WHERE EmpID = @EmpID
END
GO