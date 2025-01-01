# Refresh Token

## Project Overview

This project demonstrates how to use a **Refresh JWT Token** for authentication and authorization.

## Description

This is a sample web application built using **ASP.NET Core.** The project demonstrates fundamental principles of **Dependency Injection, Entity Framework Core, authorization and authentication**, and implements a **REST API**.

## Features
 - **Authentication and Authorization:** JWT Token
 - **CRUD operations:** Manage data with Entity Framework Core
 - **Swagger:** API documentation for ease of use

## Technologies Used
 - **ASP.NET Core 8.0**
 - **Microsoft.EntityFrameworkCore 8.0**
 - **Microsoft.AspNetCore.Authentication.JwtBearer 8.0**
 - **Microsoft.AspNetCore.Identity.EntityFrameworkCore**
 - **Microsoft.EntityFrameworkCore.SqlServer**
 - **Swagger/OpenAPI**


## Installation

### Step 1: Clone the repository
 `git clone https://github.com/MaksymMishchenko/AspNetCore.git
  cd RefreshToken`

### Step 2: Configure the database
1. Open the appsettings.json file and update the database connection string:

`"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MyDatabase;User Id=sa;Password=your_password;"
}`

2. Apply migrations to create the database tables:

`dotnet ef database update`
  
### Step 3: Run the project
1. Start the application:

`dotnet run`

2. Navigate to http://localhost:5000/swagger to view the Swagger documentation.
 
## How to Use
### REST API
The project provides an API for managing resources. Below are examples of key endpoints:

### 1. Registration
Endpoint: `POST /api/Auth/Register`

**Request body:**
`json
{
  "email": "user@example.com",
  "password": "password123"
}`

**Response:**
`json
{
  "message":"Successfully done" // // Returns Successfully done if registration is successful, or Something went wrong if registration fails.
}`

### 2. Authentication
Endpoint: `POST /api/Auth/Login`

**Request body:**
`json
{
  "email": "user@example.com",
  "password": "password123"
}`

**Response:**
`json
{
  "isLoggedIn": true, // true if authentication is successful, false if not
  "jwtToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "refreshToken": "p6xMmPCX6kFt2DAOLJB8cuZpXsbzpYt8..."
}`

### 3. Refresh a token
Endpoint: `POST /api/Auth/RefreshToken`

**Request body:**
`json
{
  "jwtToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "refreshToken": "p6xMmPCX6kFt2DAOLJB8cuZpXsbzpYt8..."
}`

**Response:**
`json
{
  "isLoggedIn": true, // true if authentication is successful, false if not
  "jwtToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "refreshToken": "p6xMmPCX6kFt2DAOLJB8cuZpXsbzpYt8..."
}`

### 4. Test endpoint
Endpoint: `GET /api/Test/Test`

**Response:**

- Status: `200 OK`
- Response body: Empty

### 5. Authorized Test Endpoint
Endpoint: `GET /api/Test/AuthorizedTest`

**Headers:**

- `Authorization: Bearer <your_token> // Authentication token for accessing the endpoint.` 

**Response:**

- Status: `200 OK`
- Response body: A string indicating successful authentication along with the expiration time of the token and the current UTC time.

Example response:

Authenticated!

Exp Time: 12:45:00, Time: 12:40:00

## Project Structure

```
Solution Refresh Token/
│
├── Solution Items/            // Solution-wide items (e.g., documentation, scripts)
│   ├── README.md              // Documentation or other related files for the entire solution
│   └── RefreshToken.postman_collection.json  // Postman collection for testing the Refresh Token API endpoint
│       // Contains requests to refresh JWT tokens using the refresh token
│       // Each request includes the necessary request body and headers for successful token refresh
│       // Useful for testing and validating the Refresh Token functionality in your API
│
├── AuthServer.Api/            // ASP.NET Core project
│   ├── Controllers/           // API controllers
│   ├── Contextes/             // DbContext and migrations
│   ├── Models/                // Data models
│   ├── Services/              // Business logic (services)
│   ├── Migrations/            // Database migrations
│   ├── appsettings.json       // Application configuration
│   └── Program.cs             // Application entry point
```

## Contact
- Author: [Maksym Mishchenko](https://github.com/MaksymMishchenko)
- Email: [mischenkomv@hotmail.com](mailto:mischenkomv@hotmail.com)
- GitHub: [MaksymMishchenko](https://github.com/MaksymMishchenko)