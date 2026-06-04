# Day 1 Notes

## Topics Covered

* RDBMS Concepts
* Database Design
* Normalization
* SQL Server Setup
* Data Types
* ER Diagram Design

## Normalization

### First Normal Form (1NF)

Rules:

* Each column contains atomic values
* No repeating groups

### Second Normal Form (2NF)

Rules:

* Must be in 1NF
* Remove partial dependencies

Store Department information in a separate Department table instead of repeating it in Employee records.

### Third Normal Form (3NF)

Rules:

* Must be in 2NF
* Remove transitive dependencies

Store data only where it belongs.

## Database Tables Designed

* Roles
* Users
* Departments
* Employees
* Documents

## Relationships

* Roles (1) → (M) Users
* Departments (1) → (M) Employees
* Users (1) → (1) Employees
* Employees (1) → (M) Documents

## Activities Performed

* Installed SQL Server Developer Edition
* Installed SSMS
* Connected to SQL Server
* Created EmployeeManagementDB
* Designed ER Diagram
* Created database tables

## Challenges Faced

* SSL certificate trust issue while connecting through SSMS
* Resolved using Trust Server Certificate option

## Outcome

Successfully configured SQL Server environment and created the initial database structure.
