Project overview

Application.Ui: Frontend/UI application for user interaction.
 - Implement some basic pages for example:
	- Login 
	- Logout
	- AccessDenied
	- OnlyAdminPage - use authorize attribute and Admin role
	- PartialLogin	

In Program.cs:
 - Add Cookie Authentication to the container and setup custom options
 - Add Authentication middleware

After configuring shared services in the Application.Services project, use the following methods in your Program.cs file to register them:

- AddApplicationServices: Registers application-specific services like business logic and repository patterns.
- AddApplicationIdentity: Configures Identity services, such as user and role management.
- AddApplicationCookieAuth: Sets up cookie-based authentication for secure user sessions.

In appsettings.json:
 - Add a connection string for ASP.NET Core Identity
