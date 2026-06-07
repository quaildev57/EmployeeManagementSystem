--rowNumber
select FullName, Salary, ROW_NUMBER() OVER(ORDER BY Salary Desc) as RankNo
from Employees;

--rank
select FullName, Salary, RANK() over(order by Salary desc) as RankNo 
from Employees;

--dense rank
SELECT FullName,Salary,
DENSE_RANK() OVER(ORDER BY Salary DESC) AS RankNo
FROM Employees;