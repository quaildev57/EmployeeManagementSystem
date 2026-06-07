CREATE Procedure AddEmployee
(@FullName VARCHAR(100), @Email VARCHAR(100), @Salary Decimal(10,2)) 
AS
Begin 
	Insert into Employees (FullName, Email, Salary)
	Values(@FullName, @Email, @Salary);
END;

Exec AddEmployee 'Mahi', 'mahi@gmail.com', 70000;
select * from Employees;
