# Day 25 Notes – Add Employee (POST API)

• Built Add Employee component using Angular Forms.
• Used [(ngModel)] for two-way data binding.
• Created a single Employee object instead of multiple variables.
• Implemented POST /api/Employee using EmployeeService.
• Sent JWT Bearer Token in Authorization header.
• Learned model binding using [FromBody].
• Debugged 401 (Expired JWT), 400 (Validation Error), and DateTime conversion issues.
• Successfully inserted employee data into SQL Server.

Flow:
Angular Form
↓
Employee Object
↓
EmployeeService
↓
POST API
↓
ASP.NET Core Controller
↓
Service
↓
Repository
↓
SQL Server
↓
200 OK

Key Learning:
Components handle UI, Services handle API communication, and JWT secures every protected request. POST requests send complete business objects rather than individual fields for better maintainability.