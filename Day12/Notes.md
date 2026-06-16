# Day 12 Notes

## Topics Covered

* Stored Procedures
* Dapper with Stored Procedures
* Parameterized Stored Procedures
* CRUD Migration from Raw SQL to Stored Procedures
* API Testing using Postman

---

# Why Stored Procedures?

Previously:

API → Repository → Dapper → SQL Query → Database

Example:

```sql
SELECT * FROM Employees;
```

Now:

API → Repository → Dapper → Stored Procedure → Database

Example:

```sql
EXEC GetEmployees;
```

---

# Real-Life Analogy

Think of a Restaurant.

Without Stored Procedures:

Customer walks into kitchen and tells chef exactly how to cook the food.

With Stored Procedures:

Customer orders from a menu.

The recipe is already prepared inside the kitchen.

Stored Procedures are like predefined recipes stored inside SQL Server.

---

# Stored Procedures Created

## GetEmployees

```sql
CREATE PROCEDURE GetEmployees
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE IsActive = 1;
END
```

Purpose:
Returns all active employees.

---

## GetEmployeeById

```sql
CREATE PROCEDURE GetEmployeeById
    @EmpID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE EmpID = @EmpID;
END
```

Purpose:
Returns employee details for a specific employee.

---

## AddEmployee

Created Stored Procedure for employee insertion.

Purpose:
Adds a new employee record into Employees table.

---

## UpdateEmployee

Created Stored Procedure for updating employee information.

Purpose:
Updates employee details.

---

## InactivateEmployee

Created Stored Procedure for soft deletion.

Purpose:
Marks employee as inactive instead of deleting the record.

---

# Dapper Integration

## Calling Stored Procedure without Parameters

```csharp
return connection.Query<Employee>(
    "GetEmployees",
    commandType: CommandType.StoredProcedure);
```

---

## Calling Stored Procedure with Parameters

```csharp
return connection.QueryFirstOrDefault<Employee>(
    "GetEmployeeById",
    new { EmpID = id },
    commandType: CommandType.StoredProcedure);
```

---

# Parameter Passing

```csharp
new { EmpID = id }
```

Dapper automatically maps:

```text
EmpID → @EmpID
```

inside SQL Server.

---

# CRUD Migration

Converted all CRUD operations from raw SQL queries to Stored Procedures.

### Before

```csharp
SELECT * FROM Employees
```

```csharp
INSERT INTO Employees
```

```csharp
UPDATE Employees
```

---

### After

```csharp
GetEmployees
```

```csharp
AddEmployee
```

```csharp
UpdateEmployee
```

```csharp
InactivateEmployee
```

---

# Challenges Faced

## 1. SQL DateTime Overflow

Error:

```text
SqlDateTime overflow
```

Cause:

Default DateTime value:

```text
01/01/0001
```

SQL Server datetime supports:

```text
01/01/1753 onwards
```

Solution:

Sent valid DOB and JoinDate values.

---

## 2. Maximum Stored Procedure Nesting Level Exceeded

Error:

```text
Maximum stored procedure nesting level exceeded (limit 32)
```

Cause:

Stored Procedure accidentally called itself recursively.

Example:

```sql
EXEC GetEmployeeById 1
```

was included inside procedure definition.

Solution:

Dropped and recreated Stored Procedure correctly.

---

## 3. 415 Unsupported Media Type

Cause:

Postman request was not being sent as JSON.

Solution:

Selected:

Body → Raw → JSON

and ensured:

```text
Content-Type: application/json
```

---

## 4. 404 Error on Inactivate API

Cause:

Incorrect API testing configuration.

Solution:

Verified route and HTTP method.

---

# Key Learning

Stored Procedures centralize SQL logic inside the database.

Dapper can execute Stored Procedures just as easily as SQL queries.

Using Stored Procedures improves:

* Maintainability
* Security
* Reusability
* Performance

---

# Architecture Achieved

Postman
↓
Controller
↓
Service
↓
Repository
↓
Dapper
↓
Stored Procedures
↓
SQL Server

---

# Analogy for my understanding
Imagine ordering food in a restaurant:

Customer = Postman
Waiter = Controller
Restaurant Manager = Service Layer
Kitchen Staff = Repository
Recipe Book = Stored Procedures
Kitchen = SQL Server
Food = Data returned to user

Each layer has a specific responsibility, making the system organized and easy to maintain.
