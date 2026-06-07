create procedure GetEmployeeById @EmpID INT
AS 
BEGIN
	SELECT * From Employees where EmpID = @EmpID;
END;
GO
EXEC GetEmployeeById 1;
GO