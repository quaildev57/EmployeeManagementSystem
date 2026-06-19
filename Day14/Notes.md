# Day 14 Notes

## Topics Covered

* JWT Authentication
* Claims-Based Identity
* Authentication Middleware
* Protected APIs using Authorize Attribute

## Components Added

### JWT Configuration

* Jwt settings in appsettings.json
* JwtBearer Authentication

### Services

* IJwtService
* JwtService

### Authentication Flow

Login Request
↓
Validate User
↓
Generate JWT Token
↓
Return Token

### Authorization Flow

Client Request
↓
Bearer Token
↓
Authentication Middleware
↓
Authorization Middleware
↓
Protected Controller

## Key Learnings

Authentication = Verifying user identity.

Authorization = Controlling access to resources.

JWT Tokens contain Claims such as UserID, Username, and RoleID and are digitally signed to prevent tampering.

ASP.NET Core Middleware order is critical:
UseAuthentication() must execute before UseAuthorization().
