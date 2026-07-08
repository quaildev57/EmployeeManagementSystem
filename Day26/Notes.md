Day 26

Topics Covered
Implemented Update Employee functionality using Angular and ASP.NET Core.
Reused the Add Employee component for both Add and Edit operations.
Implemented Angular Route Parameters (/edit/:id) to identify the employee being edited.
Retrieved employee details using GET Employee By ID API.
Pre-filled the form using API response and Angular two-way data binding.
Implemented PUT API for updating employee details.
Learned the difference between POST (Create) and PUT (Update).
Understood the role of Primary Key (EmpID) during update operations.
Fixed Angular rendering issue using ChangeDetectorRef.detectChanges().
Debugged SQL Stored Procedure parameter mismatch and corrected the update workflow.
Key Learning
The same component can be reused for Create and Update by checking whether EmpID is 0.
POST creates a new record, whereas PUT modifies an existing record identified by its primary key.
EmpID is auto-generated during insertion but is mandatory during updates.
Route parameters allow Angular to load the correct employee for editing