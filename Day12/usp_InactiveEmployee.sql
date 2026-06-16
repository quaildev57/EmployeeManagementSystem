DROP PROCEDURE IF EXISTS InactivateEmployee;
GO

CREATE PROCEDURE InactivateEmployee
(
    @EmpID INT
)
AS
BEGIN
    UPDATE Employees
    SET IsActive = 0
    WHERE EmpID = @EmpID
END
GO