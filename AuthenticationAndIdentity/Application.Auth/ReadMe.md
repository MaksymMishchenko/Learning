Project Overview

The Application.Auth project is responsible for generating a JWT token and sending it to the client, Application.Api.

Steps:
1. In appSettings.json:
 - Add connection a string to connect Identity database
 - Define base JwtToken settings like, Key, Issuer, Audience

2. Implement Login method in AuthController and use implemented method from Application.Services like:
 - Configure JwtConfiguration object
 - AddApplicationServices (register Identity Database and Authentication services)
 - AddApplicationIdentity