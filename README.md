# RoleBasedAuthenticationSystem
A secure .NET 9 ASP.NET Core Web API implementing JWT authentication and role-based authorization.
This project supports user registration, secure login with hashed passwords, and protected routes for specific roles such as Admin and User.
Includes Swagger for easy testing and API exploration.

## Features

User Registration – securely stores hashed passwords using industry-standard algorithms.

User Login – validates credentials and returns a signed JWT token.

Role-Based Authorization – restricts access to routes based on user roles.

JWT Authentication – token-based session management with expiration.

Protected Endpoints – accessible only to authenticated users with valid roles.

Swagger Integration – interactive API documentation and testing.

## Technologies Used

.NET 9 – ASP.NET Core Web API

Entity Framework Core – Database ORM

SQL Server – Data storage

JWT (JSON Web Token) – Authentication

Swagger / Swashbuckle – API documentation and testing

## Getting Started

### Prerequisites

.NET 9 SDK

SQL Server

Visual Studio 2022 or later

### Installation

1. Clone the repository
git clone https://github.com/yourusername/RoleBasedAuthenticationSystem.git
cd RoleBasedAuthenticationSystem
2. Update the connection string in appsettings.json
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=AuthDB;Trusted_Connection=True;"
}
3. Apply database migrations
dotnet ef database update   
4. Run the application
dotnet run

## Usage

### 1. Register a User
POST /api/Auth/register – Send username, password, and role.

### 2. Login
POST /api/Auth/login – Returns a JWT token if credentials are valid.

### 3. Access Protected Routes
Example:
GET /api/Admin/dashboard requires role Admin and JWT token
Authorization: Bearer YOUR_TOKEN

## Project Structure
RoleBasedAuthenticationSystem/
│   Program.cs
│   appsettings.json
│
├───Controllers
│       AuthController.cs
│       AdminController.cs
│
├───Data
│       AppDbContext.cs
│
├───Models
│       User.cs


## License
This project is licensed under the MIT License.

