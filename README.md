# Online Book Library System(ASP.NET Core MVC)
A simple web application where users can manage a list of books in a library. The application supports basic **CRUD operations** using a **single controller**, stores data in a **SQL Server database**, and follows the **ASP.NET Core MVC** pattern.

## Table of Contents
-[Features](#features)  
-[Technologies Used](#technologies-used)  
-[Database Schema](#database-schema)  
-[Controller](#controller)  
-[Views](#views)  
-[Folder Structure](#folder-structure) 
-[Prerequisites](Prerequisites)
-[Setup Instructions](#setup-instructions)  
-[Screenshots](#screenshots)  


##  Features
- Add a new book
- View a list of all books
- Edit book details
- View book details
- Delete a book

##  Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server / Azure SQL
- Razor Views + Bootstrap 5
- Azure App Service (for deployment)
- Git & GitHub (for version control)

  ##  Database Schema
**Table: Book**

| Field Name    | Type     | Description              |
|---------------|----------|--------------------------|
| Id            | `int`    | Primary Key              |
| Title         | `string` | Title of the book        |
| Author        | `string` | Book author's name       |
| Genre         | `string` | Genre of the book        |
| PublishedYear | `int`    | Year of publication      |
| IsAvailable   | `bool`   | Availability status      |

##  Controller
**Controller: `BooksController.cs`**  
This controller handles all user actions with a single controller.

- `Index()` – Display all books
- `Create()` – Add a new book (GET + POST)
- `Edit(id)` – Edit book details (GET + POST)
- `Details(id)` – View individual book details
- `Delete(id)` – Confirm and delete a book

  ## Views
All views are stored in `Views/Books/`:
Each view corresponds to a method in the controller.

## Folder Structure

OnlineBookLibrary/
├── Controllers/
│ └── BooksController.cs
├── Models/
│ └── Book.cs
├── Views/
│ └── Books/
│ ├── Index.cshtml
│ ├── Create.cshtml
│ ├── Edit.cshtml
│ ├── Details.cshtml
│ └── Delete.cshtml
├── Data/
│ └── ApplicationDbContext.cs
├── appsettings.json

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) (with ASP.NET workload)
- Azure Account (for deployment)

##  How to Run Locally
1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/WiproProject-OnlineLibrarySystem.git
   cd OnlineLibrarySystem
2. Update the database connection string in appsettings.json
3. Apply Entity Framework migrations
4. Run the application
5. Visit in browser


