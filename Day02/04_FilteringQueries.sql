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
Salary
)
values
(
'Aman Verma',
'Male',
'1999-04-10',
'Delhi',
'7777771111',
'aman@gmail.com',
1,
NULL,
GETDATE(),
40000
),
(
'Neha Gupta',
'Female',
'2001-07-22',
'Mumbai',
'7777772222',
'neha@gmail.com',
2,
NULL,
GETDATE(),
65000
),
(
'Rohan Singh',
'Male',
'1998-11-15',
'Pune',
'7777773333',
'rohan@gmail.com',
3,
NULL,
GETDATE(),
55000
);
select * from Employees;

select * from Employees where Salary>50000;
select * from Employees where Salary>50000 AND Gender = 'Female';
select * from Employees where DeptID IN (1,2);
select * from Employees where Salary BETWEEN 40000 AND 60000;
select * from Employees where FullName LIKE 'R%';
select * from Employees Order by Salary DESC;

