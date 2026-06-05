--sp_help 'Roles';
ALTER TABLE Users
ADD CONSTRAINT UQ_Users_Username UNIQUE(Username);

ALTER TABLE Employees
ADD CONSTRAINT UQ_Employees_Email UNIQUE(Email);


ALTER TABLE Users
ADD CONSTRAINT FK_Users_Roles
FOREIGN KEY (RoleID) REFERENCES Roles(RoleID);

ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_Departments
FOREIGN KEY (DeptID) REFERENCES Departments(DeptID);


ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_Users
FOREIGN KEY (UserID) REFERENCES Users(UserID);

ALTER TABLE Documents
ADD EmpID INT;

ALTER TABLE Documents
ADD CONSTRAINT FK_Documents_Employees
FOREIGN KEY (EmpID) REFERENCES Employees(EmpID);

