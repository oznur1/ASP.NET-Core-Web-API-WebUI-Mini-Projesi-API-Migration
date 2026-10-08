# BookProject.Api

A RESTful Web API built with **ASP.NET Core** for managing books using CRUD operations.

This project was created to practice and demonstrate backend development fundamentals, RESTful API design, Entity Framework Core, database migrations, and SQLite.

## 🚀 Features

- Get all books
- Get a book by ID
- Create a new book
- Update an existing book
- Delete a book
- Entity Framework Core database integration
- SQLite database
- EF Core migrations
- Swagger/OpenAPI API documentation

## 🛠️ Technologies

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger / OpenAPI
- Git & GitHub

## 📁 Project Structure

```text
BookProject
│
└── BookProject.Api
    ├── Controllers
    │   └── BookController.cs
    │
    ├── Data
    │   └── AppDbContext.cs
    │
    ├── Migrations
    │   ├── Initializer.cs
    │   ├── Initializer.Designer.cs
    │   └── AppDbContextModelSnapshot.cs
    │
    ├── Models
    │   └── Book.cs
    │
    ├── Program.cs
    └── BookProject.Api.csproj
```

## 📚 Book Model

Each book contains:

| Property | Type | Description |
|---|---|---|
| Id | int | Unique identifier |
| Title | string | Book title |
| Author | string | Book author |
| Price | decimal | Book price |

## 🔗 API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/Book` | Get all books |
| GET | `/api/Book/{id}` | Get a book by ID |
| POST | `/api/Book` | Create a new book |
| PUT | `/api/Book/{id}` | Update a book |
| DELETE | `/api/Book/{id}` | Delete a book |

## 🗄️ Database

The project uses **SQLite** with Entity Framework Core.

The database schema is managed using EF Core migrations.

To apply migrations:

```bash
Update-Database
```

Or using the .NET CLI:

```bash
dotnet ef database update
```

## ▶️ Running the Project

Clone the repository:

```bash
git clone https://github.com/oznur1/BookProject.Api.git
```

Navigate to the project directory:

```bash
cd BookProject
```

Restore dependencies:

```bash
dotnet restore
```

Apply database migrations:

```bash
dotnet ef database update
```

Run the application:

```bash
dotnet run
```

Once the application is running, you can test the API through Swagger.

## 🎯 Learning Goals

This project focuses on understanding the fundamentals of building a backend API with ASP.NET Core, including:

- RESTful API architecture
- CRUD operations
- Entity Framework Core
- Database migrations
- SQLite integration
- Dependency Injection
- Controller-based API development
- API testing with Swagger

## 🔮 Future Improvements

Possible improvements for future versions:

- DTOs
- Service layer
- Repository pattern
- Async database operations
- Input validation
- Global exception handling
- Authentication and authorization
- Unit and integration tests
- Docker support
- CI/CD with GitHub Actions



Full Stack Developer | ASP.NET Core | Node.js | TypeScript | React

GitHub: [oznur1](https://github.com/oznur1)
