INSERT INTO Roles(RoleName, Description)
VALUES ('Admin', 'System Administrator'), 
('HR', 'Human Resource'), 
('Employee', 'Regular Employee');


INSERT INTO Users
(
Username,
PasswordHash,
RoleID
)
values ('hrishita','hashed123',1),
('rahul','hashed456',2),
('priya','hashed789',3);

select * from Users;

INSERT INTO Departments(DeptName, Location)
VALUES ('IT','Delhi'),
('HR','Mumbai'),
('Finance','Bangalore');
Select * from Departments;


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
values (
'Hrishita',
'Female',
'2004-01-15',
'Delhi',
'9999999999',
'hrishita@gmail.com',
1,
1,
GETDATE(),
50000
),
(
'Rahul Sharma',
'Male',
'1998-05-20',
'Mumbai',
'8888888888',
'rahul@gmail.com',
2,
2,
GETDATE(),
45000
);
select * from Employees;


-- i ran the insert statement twice that's why deleted from here
delete from Roles where RoleID IN (7,8,9,10,11,12);
select * from Roles;

select TOP 1* from Documents; --ensuring if my Documents table has EmpID or not

INSERT INTO Documents
(
EmpID,
DocType,
FileName,
FilePath
)
values
(
1,
'Resume',
'resume.pdf',
'/docs/resume.pdf'
),
(
1,
'Aadhar',
'aadhar.pdf',
'/docs/aadhar.pdf'
);

select * from Documents;