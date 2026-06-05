select * from Employees where Salary>45800;
select count(*) as totalEmp from Employees;
select * from Employees order by Salary Asc;

UPDATE Employees
set salary += 60000
where EmpID = 2;
SELECT * FROM Employees
WHERE EmpID = 1;

UPDATE Employees
set salary += 12000
where EmpID = 2;
SELECT * FROM Employees;

UPDATE Employees
set Email ='hrishita604@gmail.com'
where EmpID =1;
SELECT * FROM Employees;

select E.FullName, E.Email, d.DeptName 
from Employees E INNER JOIN Departments D on E.DeptID = D.DeptID;