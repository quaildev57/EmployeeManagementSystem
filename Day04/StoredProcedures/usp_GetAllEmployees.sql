USE EmployeeManagementDB;
GO
create procedure GetAllEmployees
as 
begin
	select * from Employees;
end;
GO


EXEC GetAllEmployees;
GO

