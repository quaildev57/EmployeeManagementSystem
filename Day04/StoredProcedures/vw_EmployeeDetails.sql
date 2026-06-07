create view vw_EmployeeDetails
as 
select E.EmpID, E.FullName, E.Email, D.DeptName
from 
Employees E join Departments D on E.DeptID = D.DeptID;
go
select * from vw_EmployeeDetails;
