# Car Blog Application

## Project Overview
A simple ASP.NET Core MVC blog application focused on cars, featuring the latest news, articles, and car-related magazines.

## Description
This project is a web-based blog built with ASP.NET Core MVC where users can browse articles, view car news, and interact with the application through a user-friendly interface. Administrators can manage posts and categories from the admin panel, and users can send inquiries via a contact form.

## Features
- **CRUD operations:** Manage blog posts and categories using Entity Framework Core.
- **File Handling:** Allows file upload for car magazines and images.
- **Logging:** Built-in logging for monitoring application behavior.
- **Global Exception Handling Middleware:** Centralized error handling throughout the application.
- **Responsive Views:** Mobile-friendly views for users to browse articles and view content.

## Technologies Used
- **ASP.NET Core 7.0**
- **Entity Framework Core 7.0**
- **SQL Server**
- **Razor Views for dynamic web pages**
- **Bootstrap for responsive design**

## Installation

### Step 1: Clone the repository

`git clone https://github.com/MaksymMishchenko/CarBlogApp.git`
`cd CarBlogApp`

### Step 2: Configure the database
Open appsettings.json and update the database connection string:

`
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=CarBlogDB;User Id=sa;Password=your_password;"
}`

## Apply migrations to create the necessary database tables:

`dotnet ef database update`

### Step 3: Run the project
Build and start the application:

`dotnet run`

Navigate to http://localhost:5000 to view the website.

## How to Use

1. Creating a New Post
Navigate to the Admin section in the navigation bar.
Create a new Category for your post.
Add a new Article under the selected category.

2. Viewing Articles
The Home page displays a list of articles.
Click on any article to read the full content.

3. Contact Form
Navigate to the Contact page to send a message to the admin.
Admin can view all contact form submissions in the Admin Panel under Inbox Messages.

### Project Structure

```CarBlogApp/
│
├── README.md               // Documentation for the project
│
├── CarBlogApp/             // ASP.NET Core project
│   ├── Controllers/        // MVC Controllers for handling requests
│   ├── Migrations/         // Database migrations for Entity Framework Core
│   ├── Models/             // Data models representing database entities
│   ├── Services/           // Business logic services for the application
│   ├── Middlewares/        // Custom middleware for the app
│   ├── Views/              // Razor Views (for MVC pages)
│   ├── Interfaces/         // Interfaces for business logic services
│   ├── appsettings.json    // Configuration settings for the application
│   ├── Program.cs          // Main application entry point```

## To-Do
Implement cookie-based authentication for better user experience.
Refactor business logic to apply SOLID principles.
Increase test coverage to 90%.

## Contact
- Author: [Maksym Mishchenko](https://github.com/MaksymMishchenko)
- Email: [mischenkomv@hotmail.com](mailto:mischenkomv@hotmail.com)
- GitHub: [MaksymMishchenko](https://github.com/MaksymMishchenko)