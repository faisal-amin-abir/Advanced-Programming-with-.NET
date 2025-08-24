E-Commerce Backend API

A robust and scalable backend service for an e-commerce platform, developed using the N-Tier (Layered) Architecture on the .NET Framework. This API provides core functionality for managing products, categories, users, orders, and shopping carts.
Architecture 

Overview

This project follows the N-Tier Architecture principle, separating responsibilities into distinct layers to ensure maintainability, testability, and scalability. The main layers include:
- Presentation Layer (ECommerce.Presentation): Contains the ASP.NET Web API controllers. Handles HTTP requests, formats responses, and serves as the entry point. Delegates business logic to lower layers.
- Business Logic Layer (ECommerce.Business): Implements core logic, including services for validations, workflows, and business rules.
- Data Access Layer (ECommerce.Data): Manages database interactions using Repository pattern and Entity Framework, performing CRUD operations while abstracting database logic.
  
Key Features
•	User Management: Registration, authentication, and role-based authorization using JWT tokens.
•	Product & Category Management: Full CRUD operations.
•	Shopping Cart: Users can add/remove items.
•	Order Processing: Create and manage orders based on cart items.
•	RESTful API: Clean and predictable endpoints.
•	Entity Framework Code-First: Database schema managed through C# classes.
•	Dependency Injection: Ensures loose coupling and testability.
Prerequisites
•	.NET Framework 4.8 Developer Pack
•	Microsoft SQL Server (Express or Developer Edition)
•	Visual Studio 2022 with ASP.NET and web development workload
Setup Guide
1.	Clone the Repository:
    git clone https://github.com/faisal-amin-abir/Advanced-Programming-with-.NET.git
    cd "Advanced-Programming-with-.NET/E-Commerce Backend"
2.	Open the Solution: Open ECommerce.sln in Visual Studio.
3.	Restore NuGet Packages: Right-click solution > Restore NuGet Packages.
4.	Configure Database Connection (Web.config):
<connectionStrings>
    <add name="DefaultConnection"
         connectionString="Server=localhost\SQLEXPRESS; Database=ECommerceDb; Integrated Security=True;"
         providerName="System.Data.SqlClient" />
</connectionStrings>
5.	Enable Migrations & Update Database:
    Enable-Migrations
    Add-Migration "InitialCreate"
    Update-Database
6.	Run the Application: Set ECommerce.Presentation as startup project. Press F5 or IIS Express.
API URL: https://localhost:44345/

