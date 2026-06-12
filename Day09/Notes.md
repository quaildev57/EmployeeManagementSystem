# Day 9 Notes

## Topics Covered

* Dapper Introduction
* SQL Connection in ASP.NET Core
* Repository Pattern
* CRUD API Development
* Postman API Testing

## Key Concepts

### Dapper

* Lightweight ORM for .NET.
* Maps SQL query results directly to C# objects.
* Simplifies database operations compared to ADO.NET.

### Repository Pattern

* Separates database logic from controllers.
* Improves code maintainability and readability.

### Connection String

Stored in appsettings.json.

Example:
Server=localhost;Database=EmployeeManagementDB;Trusted_Connection=True;TrustServerCertificate=True;

## APIs Implemented

### GET All Employees

Returns all active employee records.

### GET Employee By ID

Returns a specific employee based on EmpID.

### POST Employee

Adds a new employee record to the database.

### UPDATE Employee

Updates employee details.

### INACTIVATE Employee

Sets IsActive = 0 instead of deleting the employee.

## Activities Performed

* Installed Dapper and Microsoft.Data.SqlClient.
* Configured SQL Server connection.
* Created EmployeeRepository.
* Implemented GET All Employees API.
* Implemented GET Employee By ID API.
* Implemented POST Employee API.
* Implemented UPDATE Employee API.
* Implemented Inactivate Employee API.
* Tested APIs using Postman.
* Verified database updates in SQL Server.

## Challenges Faced

* JSON syntax issues in appsettings.json prevented API startup.
* Understanding API flow between Controller, Repository, Dapper, and SQL Server.
* Foreign key constraint error while inserting employee due to invalid UserID.
* Learned how SQL Server enforces data integrity using foreign keys.

## Outcome

Successfully connected ASP.NET Core Web API to SQL Server using Dapper and implemented CRUD operations for Employees.
