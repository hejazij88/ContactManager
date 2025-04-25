# ContactManager

A simple contact management system built with ASP.NET Core MVC. This project demonstrates basic CRUD (Create, Read, Update, Delete) operations using Entity Framework Core and a layered architecture.

## 🚀 Features

- Add, edit, delete, and view contacts
- Clean architecture with separation of concerns
- Entity Framework Core with Code First approach
- Responsive UI with Bootstrap
- Validation using Data Annotations

## 🛠️ Tech Stack

- ASP.NET Core MVC (.NET 7)
- Entity Framework Core
- SQL Server / LocalDB
- Bootstrap 5
- Visual Studio 2022

## 📂 Project Structure

ContactManager/ │ ├── Controllers/ # MVC controllers ├── Models/ # Entity and view models ├── Data/ # EF Core DbContext and migrations ├── Views/ # Razor views ├── wwwroot/ # Static files (CSS, JS, etc.) ├── appsettings.json # Configuration settings └── Program.cs # Application startup

markdown
Copy
Edit

## 💻 Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with ASP.NET and web development workload
- SQL Server Express or LocalDB

### Steps

1. **Clone the repository**

```bash
git clone https://github.com/hejazij88/ContactManager.git
cd ContactManager
Update the connection string

Edit appsettings.json to match your SQL Server configuration:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ContactManagerDb;Trusted_Connection=True;"
}
Apply migrations

bash
Copy
Edit
dotnet ef database update
Run the application

bash
Copy
Edit
dotnet run
Open your browser and navigate to https://localhost:5001 (or the port shown in the console).

🧪 Screenshots
(You can include screenshots here to showcase the UI of your application)

📌 To Do / Improvements
Add search and filtering options

Implement user authentication and authorization

Unit and integration testing

API support
