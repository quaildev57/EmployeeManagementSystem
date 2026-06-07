select getdate();
select year(getdate()) as year ;

select FullName, Datediff(year, JoinDate, getdate()) as YearsOfservice from Employees;