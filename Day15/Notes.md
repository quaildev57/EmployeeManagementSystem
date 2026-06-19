# Day 15 Notes

## Topics Covered

* Role-Based Authorization (RBAC)
* Claims-Based Identity
* Authorization Attributes
* Access Control using JWT Claims

## JWT Claims

Name
UserID
Role

## Role Mapping

RoleID 1 → Admin

RoleID 2 → HR

RoleID 3 → Employee

## Authorization Rules

Admin:

* Add Employee
* Update Employee
* Inactivate Employee
* View Employees

HR:

* Update Employee
* View Employees

Employee:

* View Employees

## ASP.NET Attributes Used

[Authorize]

[Authorize(Roles = "Admin")]

[Authorize(Roles = "Admin,HR")]

## Key Learning

Authentication verifies identity.

Authorization determines permissions.

JWT claims can be used to implement Role-Based Access Control and secure APIs based on user roles.
