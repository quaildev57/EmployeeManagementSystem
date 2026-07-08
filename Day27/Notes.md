# Day 27 – Soft Delete & Security Enhancements

## Topics Covered

### Employee Module
- Implemented Employee Inactivation (Soft Delete).
- Added **Inactivate Employee** API integration in Angular.
- Added **Inactivate** button in Employee List.
- Displayed confirmation dialog before employee inactivation.
- Successfully called the PUT Inactivate API.
- Automatically refreshed the employee list after successful inactivation.
- Refactored Employee List by creating a reusable `loadEmployees()` method to avoid duplicate code.

---

## Security Module

### Angular Route Guards
- Created **Auth Guard** using `CanActivate`.
- Protected authenticated routes:
  - Dashboard
  - Employee List
  - Add Employee
  - Edit Employee
- Prevented unauthenticated users from accessing protected pages.

### Login Guard
- Implemented Login Guard to prevent authenticated users from revisiting the Login page.

### Logout
- Implemented Logout functionality.
- Cleared JWT token from Local Storage.
- Redirected users back to the Login page after logout.

### HTTP Interceptor
- Created an Authentication Interceptor.
- Automatically attached JWT tokens to all outgoing HTTP requests.
- Registered the interceptor in `app.config.ts`.
- Removed repetitive Authorization header code from all Employee Service methods.

---

## Refactoring

- Simplified `EmployeeService`.
- Removed duplicate JWT handling logic.
- Centralized authentication using HTTP Interceptor.
- Improved code readability and maintainability by following the **Single Responsibility Principle (SRP)**.

---

## Key Concepts Learned

- Soft Delete vs Hard Delete
- Employee Inactivation
- Angular Route Guards
- Login Guard
- Logout Flow
- JWT Authentication
- HTTP Interceptors
- Automatic Token Injection
- Angular Functional Guards
- Reusable Methods
- Single Responsibility Principle (SRP)

---

## Outcome

Successfully completed the security layer of the Employee Management System by implementing route protection, logout functionality, login restrictions, and centralized JWT authentication using Angular HTTP Interceptors. Also completed the Soft Delete feature for employee management and refactored frontend services to follow cleaner enterprise-level architecture.

## Challenges
Faced issues while configuring route guards, interceptor registration, and dynamic route handling. Successfully resolved configuration mismatches, validated JWT authentication flow, and ensured secure access to protected routes.