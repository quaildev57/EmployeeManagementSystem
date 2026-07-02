# Day 22 Notes – Angular HTTP Client & API Integration

## Topics Covered
• Angular Services
• Dependency Injection (DI)
• HttpClient
• Authentication Service
• API Integration
• CORS
• JWT Token
• Local Storage

--------------------------------------------------

1. Angular Service
- Used to handle reusable business logic.
- Keeps API calls separate from components.

Architecture:
Login Component
      ↓
AuthService
      ↓
HttpClient
      ↓
ASP.NET Core API

--------------------------------------------------

2. Dependency Injection (DI)

Example:
constructor(private http: HttpClient) { }

- Angular automatically provides required objects.
- Similar to ASP.NET Core DI.

--------------------------------------------------

3. Registering HttpClient

File:
app.config.ts

Added:

provideHttpClient()

This allows Angular to make HTTP requests.

--------------------------------------------------

4. Authentication Service

Created:
services/auth.service.ts

Used @Injectable({
    providedIn: 'root'
})

One shared AuthService instance is used across the application.

--------------------------------------------------

5. Login API

Endpoint:
POST https://localhost:7033/api/Auth/login

Method:

login(username:string,password:string){
    return this.http.post(
        `${this.apiUrl}/login`,
        {
            username,
            password
        });
}

--------------------------------------------------

6. Calling API

this.authService.login(username,password)
.subscribe({

next:(response)=>{
    console.log(response);
},

error:(error)=>{
    console.log(error);
}

});

.subscribe() executes the HTTP request.

--------------------------------------------------

7. CORS

Angular:
http://localhost:4200

Backend:
https://localhost:7033

Since both have different origins, CORS must be enabled.

Program.cs:

builder.Services.AddCors(...);

app.UseCors("AllowAngular");

--------------------------------------------------

8. JWT Token

Successful Login Response:

{
   "message":"Login Successful",
   "token":"eyJhbGc..."
}

--------------------------------------------------

9. Local Storage

Store Token:

localStorage.setItem("token",response.token);

Retrieve:

localStorage.getItem("token");

Remove:

localStorage.removeItem("token");

--------------------------------------------------

10. Authentication Flow

User
 ↓
Login Component
 ↓
AuthService
 ↓
HttpClient
 ↓
ASP.NET Core API
 ↓
JWT Token
 ↓
Local Storage

--------------------------------------------------

Challenges Faced
• Fixed AuthService generation and naming issues.
• Configured HttpClient in Angular standalone application.
• Resolved CORS issue.
• Debugged authentication using Swagger and Browser DevTools.
• Successfully integrated Angular with ASP.NET Core Login API.

--------------------------------------------------

Key Learning

Angular components should focus on UI, while services handle API communication. HttpClient, Dependency Injection, JWT, and CORS together enable secure communication between Angular and ASP.NET Core applications.