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

In appsettings.json:
 - Add a connection string for ASP.NET Core Identity
