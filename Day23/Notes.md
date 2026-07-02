# Day 23 Notes – JWT Authentication & Protected APIs

## Topics Covered
• Angular Router
• Navigation after Login
• Protected APIs
• Authorization Header
• JWT Authentication
• ngOnInit()
• Angular Lifecycle Hooks
• Displaying Logged-in User
• TypeScript Interfaces (Introduction)

--------------------------------------------------

1. Angular Router

Used Router service for page navigation.

Import:

import { Router } from '@angular/router';

Inject:

constructor(
  private authService: AuthService,
  private router: Router
) {}

Navigate:

this.router.navigate(['/dashboard']);

--------------------------------------------------

2. Why Navigate After Login?

Flow:

Login
↓
Receive JWT
↓
Store JWT
↓
Navigate to Dashboard

Reason:
Dashboard immediately needs the JWT to access protected APIs. Navigating before storing the token may result in a 401 Unauthorized error.

--------------------------------------------------

3. JWT Authentication

JWT contains authenticated user information (claims).

Example Claims:
• UserID
• Username
• Role
• Department

The backend verifies the JWT before allowing access to protected endpoints.

--------------------------------------------------

4. Protected API

Endpoint:

GET /api/Auth/me

Protected using:

[Authorize]

Only authenticated users with a valid JWT can access it.

--------------------------------------------------

5. Authorization Header

Angular reads the JWT from Local Storage.

const token = localStorage.getItem("token");

Request Header:

Authorization: Bearer <JWT>

"Bearer" tells ASP.NET Core that the token is a JWT Bearer Token.

--------------------------------------------------

6. AuthService

Added reusable method:

getCurrentUser()

Purpose:
• Reads JWT from Local Storage
• Calls GET /api/Auth/me
• Returns current user details

--------------------------------------------------

7. ngOnInit()

Implemented:

export class Dashboard implements OnInit

Angular automatically calls:

ngOnInit()

when the component loads.

Used for:
• API Calls
• Loading Data
• Initialization

--------------------------------------------------

8. Dashboard

Fetched current user using:

this.authService.getCurrentUser()

Displayed:

Welcome {{username}}

Role: {{role}}

Department: {{department}}

using Angular Interpolation.

--------------------------------------------------

9. Local Storage

Store:

localStorage.setItem("token", response.token);

Read:

localStorage.getItem("token");

JWT persists even after page refresh until removed.

--------------------------------------------------

10. Authentication Flow

Login
↓
POST /login
↓
JWT Generated
↓
Local Storage
↓
Dashboard
↓
GET /api/Auth/me
↓
Authorization: Bearer <JWT>
↓
User Details Returned
↓
Display on Dashboard

--------------------------------------------------

Challenges Faced
• Understood Bearer Authentication.
• Debugged Angular navigation after login.
• Fixed issues while displaying user details.
• Verified protected API using Swagger.
• Successfully displayed authenticated user's profile on the Dashboard.

--------------------------------------------------

Key Learning

Authentication proves the user's identity once during login using a JWT. After that, every protected API request sends the JWT in the Authorization header instead of repeatedly sending the username and password. Angular components focus on displaying data, while services handle all communication with backend APIs.