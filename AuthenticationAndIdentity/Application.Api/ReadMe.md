Project Overview

This project, Application.Api, obtains a token from Application.Auth, includes it in its request headers, and sends the request to validate the user.

Steps:
1. In appSettings.json:
 - Add connection a string to connect Identity database
 - Define base JwtToken settings like, Key, Issuer, Audience

2. Controllers folder:
 -  Define four controller with CRUD operations:
	- ClassRoomController
	- ModuleController
	- StudentController
	- TeacherController

3. Add reference to the Application.Services

4. In Program.cs:
 - Add Jwt Authentication to the container and setup custom options
 - Add Authentication middleware

5. Using role base authorization to ClassRoomController (TypeSafe)