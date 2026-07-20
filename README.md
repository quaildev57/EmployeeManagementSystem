![Angular](https://img.shields.io/badge/Angular-20-red)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-10-blue)
![SQL Server](https://img.shields.io/badge/SQL_Server-Database-red)
![License](https://img.shields.io/badge/License-MIT-green)

# Employee Management System

A modern Employee Management System built using **ASP.NET Core Web API**, **Angular**, **SQL Server**, and **Dapper**. The application enables secure employee management through JWT-based authentication, role-based authorization, and a responsive enterprise-style user interface.

---

## Overview

This project was developed to demonstrate a complete full-stack employee management solution following modern software development practices. It provides secure authentication, employee lifecycle management, and an intuitive dashboard for administrators.

---

## Features

### Authentication & Authorization
- JWT-based Authentication
- Role-Based Authorization
- Protected Routes
- Secure Login
- Logout Functionality

### Employee Management
- Add Employee
- Update Employee Details
- View Employee Records
- Soft Delete (Employee Inactivation)
- Search Employees
- Filter Employees
- Sort Employee Records

### Dashboard
- Employee Statistics
- Quick Actions
- Modern Dashboard Layout
- Responsive Design

### User Interface
- Responsive Sidebar Navigation
- Enterprise-style Dashboard
- Modern Employee Forms
- Search Functionality
- Bootstrap Icons
- SCSS Styling

---

# Technology Stack

## Frontend

- Angular (Standalone Components)
- TypeScript
- HTML5
- SCSS
- Angular Router
- Bootstrap Icons

## Backend

- ASP.NET Core Web API
- C#
- Dapper ORM
- JWT Authentication
- Dependency Injection
- Repository Pattern
- Middleware

## Database

- Microsoft SQL Server
- SQL Stored Procedures

---

# Project Architecture

```
Angular Frontend
        │
        ▼
ASP.NET Core Web API
        │
        ▼
 Repository Layer (Dapper)
        │
        ▼
 SQL Server Database
```

---

# Folder Structure

```
EmployeeManagementSystem

├── Backend
│   ├── Controllers
│   ├── Repository
│   ├── Services
│   ├── Middleware
│   ├── Models
│   ├── DTOs
│   ├── Stored Procedures
│   └── Program.cs
│
├── Frontend
│   ├── Pages
│   ├── Layouts
│   ├── Components
│   ├── Services
│   ├── Guards
│   ├── Interceptors
│   ├── Models
│   └── Themes
│
└── Database
```

---

# UI Modules

- Login
- Dashboard
- Employee List
- Add Employee
- Edit Employee
- Sidebar
- Top Navigation
- Authentication

---

# API Features

- JWT Authentication
- CRUD APIs
- Soft Delete APIs
- Role-Based Authorization
- Exception Handling Middleware
- RESTful Endpoints

---

# Database Features

- Normalized Database Design
- Primary & Foreign Keys
- Stored Procedures
- Identity Columns
- Constraints
- Soft Delete Implementation

---

# Development Practices

- Repository Pattern
- Dependency Injection
- REST API Design
- Component-Based Architecture
- Modular Angular Structure
- Responsive UI Design
- Code Reusability
- Clean Folder Organization

---

# Prerequisites

Install the following before running the project:

- .NET SDK
- Node.js
- Angular CLI
- SQL Server
- Visual Studio / VS Code

---

# Installation

## Backend

```bash
git clone <repository-url>

cd Backend

dotnet restore

dotnet run
```

---

## Frontend

```bash
cd Frontend

npm install

ng serve
```

---

# Database Setup

1. Create the SQL Server database.
2. Execute the provided SQL scripts.
3. Update the SQL Server connection string inside:

```
appsettings.json
```

4. Run the backend application.

---

# Authentication

The application uses JWT authentication.

Workflow:

```
Login
      ↓
Generate JWT Token
      ↓
Store Token
      ↓
Attach Token to Requests
      ↓
Protected APIs
```

---

# Screenshots

Add screenshots of:

- Login Page
- Dashboard
- Employee List
- Add Employee Form
- Edit Employee Form

---

# Future Improvements

- Employee Profile Images
- Department Management
- Role Management
- Export to Excel
- PDF Reports
- Pagination
- Audit Logs
- Email Notifications
- Dark Mode

---

# Tools Used

| Tool | Purpose |
|-------|----------|
| Visual Studio | Backend Development |
| Visual Studio Code | Frontend Development |
| SQL Server Management Studio | Database Management |
| Postman | API Testing |
| Git | Version Control |
| GitHub | Repository Hosting |

---

# Tech Stack Summary

| Category | Technology |
|----------|------------|
| Frontend | Angular |
| Backend | ASP.NET Core Web API |
| Language | C#, TypeScript |
| Database | SQL Server |
| ORM | Dapper |
| Authentication | JWT |
| Styling | SCSS |
| Icons | Bootstrap Icons |

---

# License

This project is licensed under the MIT License.

See the LICENSE file for more details.

---

# Author

**Hrishita Raj Singh**

B.Tech Computer Science Engineering  
Jaypee Institute of Information Technology

## Connect with Me

- [LinkedIn](https://www.linkedin.com/in/https://www.linkedin.com/in/hrishita-raj-singh-1392a7417?utm_source=share_via&utm_content=profile&utm_medium=member_ios/)
- [GitHub](https://github.com/your-username)
GitHub: https://github.com/<https://github.com/quaildev57>


---

## Acknowledgements 

This project was developed as part of an internship to gain hands-on experience in full-stack web application development using Angular, ASP.NET Core, SQL Server, and modern software engineering practices.