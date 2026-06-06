select DeptID, count(*) as EmployeeCount 
from Employees
GROUP BY DeptID;

SELECT DeptID, AVG(Salary) AS AverageSalary
from Employees
GROUP BY DeptID;

SELECT D.DeptName, COUNT(*) AS EmployeeCount
FROM Employees E
INNER JOIN Departments D
ON E.DeptID = D.DeptID
GROUP BY D.DeptName;

SELECT D.DeptName, COUNT(*) AS EmployeeCount
FROM Employees E
INNER JOIN Departments D
ON E.DeptID = D.DeptID
GROUP BY D.DeptName
HAVING COUNT(*) > 1;

SELECT
    D.DeptName,
    AVG(E.Salary) AS AverageSalary
FROM Employees E
INNER JOIN Departments D
ON E.DeptID = D.DeptID
GROUP BY D.DeptName
HAVING AVG(E.Salary) > 50000;

SELECT
    E.FullName,
    D.DeptName
FROM Employees E
LEFT JOIN Departments D  -- return everything from Employees table
ON E.DeptID = D.DeptID;

SELECT
    E.FullName,
    D.DeptName
FROM Employees E
RIGHT JOIN Departments D
ON E.DeptID = D.DeptID;

SELECT
    E.FullName,
    D.DeptName
FROM Employees E
FULL JOIN Departments D
ON E.DeptID = D.DeptID;

SELECT
    DeptID,
    COUNT(*) AS EmployeeCount
FROM Employees
GROUP BY DeptID;