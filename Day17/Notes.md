# Day 17 Notes

## Topics Covered

* OpenAPI and Swagger
* API Documentation
* Swagger UI Configuration
* API Testing using Swagger

## What is Swagger?

Swagger is an API documentation and testing framework that generates interactive API documentation from application code using the OpenAPI specification.

## Benefits of Swagger

* Automatic API documentation
* Interactive API testing
* Easy collaboration between frontend and backend teams
* Simplifies API consumption for third-party developers
* Provides request and response schemas automatically

## Configuration Performed

### Added Swagger Support

```csharp
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
```

### Enabled Swagger Middleware

```csharp
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
```

## Key Observations

* Swagger automatically discovered all controllers and endpoints.
* Request and response models were generated automatically.
* APIs could be tested directly from the browser without Postman.
* OpenAPI specifications are generated from controller metadata and attributes.

## Swagger vs Postman

### Swagger

* Auto-generated from code
* Provides API documentation
* Interactive API testing
* Useful for development and collaboration

### Postman

* Manual API testing tool
* Supports collections and automation
* Useful for advanced testing scenarios

## Key Learning

Swagger acts as a self-documenting interface for APIs, making development, testing, and integration easier across teams.
