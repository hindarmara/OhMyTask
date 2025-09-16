# TasksManagerWeb - ASP.NET Razor Pages

This is the web-based version of the Oh My Tasks application, built with ASP.NET Core Razor Pages and Entity Framework Core.

## Features

- **Create Tasks**: Add new tasks with descriptions
- **View Tasks**: See all tasks in a clean, organized interface
- **Edit Tasks**: Modify task descriptions and completion status
- **Mark Complete**: Mark tasks as completed directly from the list
- **Delete Tasks**: Remove tasks with confirmation
- **Persistent Storage**: All data is stored in SQL Server database

## Technology Stack

- ASP.NET Core 9.0
- Razor Pages
- Entity Framework Core
- SQL Server (LocalDB)
- Bootstrap 5

## Database Configuration

The application is configured to use SQL Server LocalDB by default. The connection string is located in `appsettings.Development.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=OhMyTasksDb;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

## Running the Application

1. Ensure you have .NET 9.0 SDK installed
2. Navigate to the TasksManagerWeb directory
3. Run `dotnet restore` to restore NuGet packages
4. Run `dotnet run` to start the application
5. Open your browser to `https://localhost:7xxx` or `http://localhost:5xxx`

The database will be automatically created on first run.

## Project Structure

- `Models/` - Entity models (TaskItem)
- `Data/` - Database context (TaskDbContext)
- `Pages/` - Razor Pages (Index, Create, Edit, Privacy)
- `wwwroot/` - Static files (CSS, JavaScript)