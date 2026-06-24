# Day 16 Notes

## Topics Covered

* JWT Claims
* ClaimsPrincipal
* User Object in ASP.NET Core
* Current User Endpoint (/me)
* Custom Claims

## Key Concepts

### Claims

Claims are pieces of information stored inside a JWT token about the authenticated user.

Examples:

* Username
* UserID
* Role
* Department

### ClaimsPrincipal

ASP.NET Core automatically extracts claims from a validated JWT and stores them inside the User object (ClaimsPrincipal).

### Accessing Claims

```csharp
User.FindFirst(ClaimTypes.Name)?.Value
User.FindFirst("UserID")?.Value
User.FindFirst(ClaimTypes.Role)?.Value
User.FindFirst("Department")?.Value
```

### Current User Endpoint

Implemented:

GET /api/auth/me

Returns information about the currently authenticated user directly from JWT claims without querying the database.

### Claims Inspection Endpoint

Implemented:

GET /api/auth/claims

Returns all claims present inside the authenticated user's JWT token.

### Custom Claims

Added a custom Department claim during token generation:

```csharp
new Claim("Department", "IT")
```

Retrieved the custom claim using:

```csharp
User.FindFirst("Department")?.Value
```

## Key Learnings

* JWT tokens can store custom user information.
* Claims eliminate unnecessary database lookups.
* ClaimsPrincipal represents the authenticated user.
* The User object is populated automatically after JWT authentication succeeds.
* Custom claims can be used for authorization and personalization.
