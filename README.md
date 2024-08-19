# Inventory Management System

This project consists of a backend built with ASP.NET Core and a frontend built with Angular.

## Setup and Execution

### Backend (ASP.NET Core)
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).
2. Navigate to the backend folder.
3. Run `dotnet restore` to restore packages.
4. Update the `appsettings.json` with your SQL Server connection string.
5. Apply database migrations:
   ```bash
   dotnet ef database update
To run the Project
   dotnet run
The backend will start at http://localhost:7272
