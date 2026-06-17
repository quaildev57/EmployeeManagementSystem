# Day 13 Notes

## Topics Covered

* Authentication Basics
* Login API Development
* User Validation using Stored Procedures
* Service Layer Integration for Authentication

## Components Created

### Models

* LoginRequest
* User

### Stored Procedure

* ValidateUser

### Services

* IAuthService
* AuthService

### Controller

* AuthController

## Login Flow

User
↓
AuthController
↓
AuthService
↓
Repository
↓
ValidateUser Stored Procedure
↓
Users Table

## API Endpoint

POST /api/auth/login

Request:

{
"username": "hrishita",
"password": "hashed123"
}

Response:

{
"message": "Login Successful",
"userID": 1,
"username": "hrishita",
"roleID": 1
}

## Key Learning

Authentication = Verifying who the user is.

Authorization = Determining what the user can access.

Today's login API forms the foundation for JWT Authentication and Role-Based Access Control.
