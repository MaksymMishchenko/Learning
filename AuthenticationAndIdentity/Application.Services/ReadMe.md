Project Overview

The project includes a layer called Application.Services that contains shared services used across the UI, API, and Auth projects. This layer encompasses essential functionalities like business logic and repository patterns.

Dependencies
Ensure you install the following NuGet packages:

- Microsoft.AspNetCore.Authentication.Cookies
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.AspNetCore.Identity.UI
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.AspNetCore.Authentication.JwtBearer
- Newtonsoft.Json

Setup Instructions
1. Service Registration
Create a service registration class and implement the following extension methods for proper service configuration:

- AddApplicationCookieAuth: Configures cookie-based authentication.
- AddApplicationServices: Registers shared services.
- AddApplicationIdentity: Configures Identity services.
- SeedDataAsync: Seeds initial data for Identity, such as an admin user or default roles.

2. Identity Database Context
Implement a custom IdentityDbContext to integrate with your application's database. Ensure that this context handles Identity entities like users, roles, and claims.

3. Authentication and User Management
Implement the following functionality in the AuthService to manage the Identity database:

- Login: Authenticate users and manage their sessions.
- Logout: Clear user sessions securely.
- GenerateCookieAuthentication: Create cookie-based authentication for user sessions.
- RegisterUser: Allow users to register new accounts.
- AddUserClaims: Assign and manage claims for users.
- GenerateTokenString