# Day 11 Notes

## Topics Covered

* Service Layer
* Interfaces
* Dependency Injection (DI)
* Basic Exception Handling
* Logging using ILogger

---

## 1. Service Layer

### Purpose

The Service Layer acts as an intermediate layer between the Controller and Repository.

### Architecture

Before:

Controller → Repository → Database

After:

Controller → Service → Repository → Database

### Responsibilities

* Business Logic
* Validations
* Rules and Calculations
* Data Processing

### Benefits

* Cleaner Controllers
* Better Code Organization
* Easy Maintenance
* Improved Scalability

---

## 2. Interfaces

### IEmployeeService

Created an interface for EmployeeService.

```csharp
public interface IEmployeeService
{
    IEnumerable<Employee> GetEmployees();
    Employee GetEmployeeById(int id);
    int AddEmployee(Employee employee);
    int UpdateEmployee(Employee employee);
    int InactivateEmployee(int id);
}
```

### IEmployeeRepository

Created an interface for EmployeeRepository.

```csharp
public interface IEmployeeRepository
{
    IEnumerable<Employee> GetEmployees();
    Employee GetEmployeeById(int id);
    int AddEmployee(Employee employee);
    int UpdateEmployee(Employee employee);
    int InactivateEmployee(int id);
}
```

### Benefits of Interfaces

* Loose Coupling
* Easier Testing
* Better Maintainability
* Flexibility to replace implementations

---

## 3. Dependency Injection (DI)

### Definition

Dependency Injection is a design pattern where dependencies are provided from outside instead of being created inside a class.

### Registration

```csharp
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
```

### Injection

```csharp
public EmployeeController(IEmployeeService service)
{
    _service = service;
}
```

### Advantages

* Loose Coupling
* Reusability
* Better Testing
* Easier Maintenance

---

## 4. Business Validation

Added validation inside Service Layer.

Example:

```csharp
if(employee.Salary < 0)
{
    throw new Exception("Salary cannot be negative.");
}
```

### Why Service Layer?

Business rules should be handled in the Service Layer instead of Controllers or Repositories.

Examples:

* Salary cannot be negative
* Employee must be active
* Age restrictions
* Email validation

---

## 5. Exception Handling

### Purpose

Prevents application crashes and provides meaningful error messages.

### Example

```csharp
try
{
    int rows = _service.AddEmployee(employee);
}
catch(Exception ex)
{
    return BadRequest(ex.Message);
}
```

### Benefits

* Better User Experience
* Easier Debugging
* Controlled Error Responses

---

## 6. Logging

### ILogger

Used ILogger to track API activity.

### Injection

```csharp
private readonly ILogger<EmployeeController> _logger;
```

```csharp
public EmployeeController(
    IEmployeeService service,
    ILogger<EmployeeController> logger)
{
    _service = service;
    _logger = logger;
}
```

### Log Levels

```csharp
_logger.LogInformation("Employee fetched");

_logger.LogWarning("Invalid salary entered");

_logger.LogError("Database connection failed");
```

### Benefits

* Application Monitoring
* Troubleshooting
* Debugging
* Audit Tracking

---

## Architecture Achieved

Postman
↓
EmployeeController
↓
IEmployeeService
↓
EmployeeService
↓
IEmployeeRepository
↓
EmployeeRepository
↓
Dapper
↓
SQL Server

---

## Challenges Faced

* Understanding the purpose of Service Layer.
* Understanding Dependency Injection and Interfaces.
* Differentiating responsibilities of Controller, Service, and Repository.
* Learning how logging works in ASP.NET Core.
* Understanding where business validations should be implemented.

---

## Key Learning

A Controller should only handle requests and responses.

A Service should handle business logic and validations.

A Repository should handle database operations.

This separation of concerns makes applications easier to maintain, test, and scale.
